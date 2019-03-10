using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace lens_editor
{
    public class RemoteDebugClient
    {
        public RemoteDebugClient(string addr = "127.0.0.1")
        {
            m_client = new UdpClient();
            m_endpoint = new IPEndPoint(IPAddress.Parse(addr), 28065);
            m_client.Connect(m_endpoint);
        }

        enum RequestType
        {
            Ping = 0,
            EntityList = 1,
            CreateEntity = 2,
        }

        enum RequestSubType
        {
            None = 0,

        }

        enum StatusCode
        {
            Null = 0,
            Ok = 1,
            BadRequest = 2,
            NotImplemented = 3,
        }

        void WriteRequestHeader(BinaryWriter bw, RequestType t, RequestSubType st)
        {
            bw.Write(new char[] { 'R', 'D', 'R', 'Q' });
            bw.Write((UInt32)t);
            bw.Write((UInt32)st);
        }

        class BaseResponse
        {
            public BaseResponse(BinaryReader br)
            {
                var idbuf = br.ReadChars(4);
                Valid = (idbuf[0] == 'R' && idbuf[1] == 'D' && idbuf[2] == 'R' && idbuf[3] == 'S');
                if (Valid)
                {
                    Status = (StatusCode)br.ReadUInt32();
                }
            }

            public bool Valid;
            public StatusCode Status;
        }

        public class Entity
        {
            [Flags]
            public enum Status
            {
                Invalid = 0,
                Alive = 1 << 0,
                Drawable = 1 << 1,
                NonStandardDrawable = 1 << 2,
                PointLight = 1 << 3,
                IgnoredInRoomTest = 1 << 4,
                Looping = 1 << 5,
            }

            public Entity() {
                classname = "DEADCAFE";
                status = Status.Invalid;
            }

            public Entity(BinaryReader br)
            {
                id = br.ReadUInt64();
                rev = br.ReadUInt64();
                var buf_classname = br.ReadBytes(64);
                classname = new string(Encoding.ASCII.GetChars(buf_classname));
                position = new float[] { br.ReadSingle(), br.ReadSingle(), br.ReadSingle() };
                quaternion = new float[] { br.ReadSingle(), br.ReadSingle(), br.ReadSingle(), br.ReadSingle()};
                status = (Status)br.ReadUInt32();
            }

            public void Write(BinaryWriter bw)
            {
                bw.Write(id);
                bw.Write(rev);
                char[] buf_classname = new char[64];
                classname.CopyTo(0, buf_classname, 0, classname.Length < 63 ? classname.Length : 63);
                bw.Write(buf_classname, 0, 64);
                bw.Write(position[0]);
                bw.Write(position[1]);
                bw.Write(position[2]);
                bw.Write(quaternion[0]);
                bw.Write(quaternion[1]);
                bw.Write(quaternion[2]);
                bw.Write(quaternion[3]);
                bw.Write((UInt32)status);
            }

            public UInt64 id, rev;
            public string classname;
            public float[] position;
            public float[] quaternion;
            public Status status;
        }

        byte[] ReceiveWithTimeout(double millis)
        {
            byte[] buf = null;
            var wait_start = DateTime.Now;
            while (DateTime.Now - wait_start < TimeSpan.FromMilliseconds(millis))
            {
                if (m_client.Available > 0)
                {
                    try
                    {
                        buf = m_client.Receive(ref m_endpoint);
                    } catch(Exception)
                    {
                        break;
                    }
                    break;
                }
            }
            return buf;
        }

        public Entity[] RequestEntityList()
        {
            Entity[] ret = null;

            using (var ms = new MemoryStream())
            {
                using (var bw = new BinaryWriter(ms))
                {
                    WriteRequestHeader(bw, RequestType.EntityList, RequestSubType.None);
                    bw.Flush();
                    var buf = ms.GetBuffer();
                    m_client.Send(buf, buf.Length);
                }
            }
            var recv_buf = ReceiveWithTimeout(500);
            if(recv_buf != null)
            {
                using (var ms = new MemoryStream(recv_buf))
                {
                    using (var br = new BinaryReader(ms))
                    {
                        var res = new BaseResponse(br);
                        if(res.Valid)
                        {
                            var count = br.ReadUInt64();
                            ret = new Entity[count];
                            for(UInt64 i = 0; i < count; i++)
                            {
                                ret[i] = new Entity(br);
                            }
                        }
                    }
                }

            }

            return ret;
        }

        public bool Ping()
        {
            byte[] buf = null;
            using (var ms = new MemoryStream())
            {
                using (var bw = new BinaryWriter(ms))
                {
                    WriteRequestHeader(bw, RequestType.Ping, RequestSubType.None);
                    bw.Flush();
                    buf = ms.GetBuffer();
                    m_client.Send(buf, buf.Length);
                }
            }
            buf = ReceiveWithTimeout(500);
            if (buf == null)
            {
                return false;
            }
            using (var ms = new MemoryStream(buf))
            {
                using (var br = new BinaryReader(ms))
                {
                    var id = br.ReadChars(4);
                    if (id[0] != 'R' || id[1] != 'D' || id[2] != 'R' || id[3] != 'S')
                    {
                        return false;
                    }
                    var status = br.ReadUInt32();
                    switch((StatusCode)status)
                    {
                        case StatusCode.Ok: return true;
                        case StatusCode.BadRequest: Console.Error.WriteLine("RemoteDebugClient: received BadRequest response for a ping request!!"); return false;
                        default: return false;
                    }
                }
            }
        }

        public bool CreateEntity(string classname, float[] pos, float[] quaternion)
        {
            using (var ms = new MemoryStream())
            {
                using (var bw = new BinaryWriter(ms))
                {
                    WriteRequestHeader(bw, RequestType.CreateEntity, RequestSubType.None);
                    bw.Flush();
                    Entity ent = new Entity();
                    ent.classname = classname;
                    ent.position = pos;
                    ent.quaternion = quaternion;
                    ent.status = Entity.Status.Alive;
                    ent.Write(bw);

                    var buf = ms.GetBuffer();
                    m_client.Send(buf, buf.Length);
                }
            }
            var recv_buf = ReceiveWithTimeout(500);
            if(recv_buf != null)
            {
                using (var ms = new MemoryStream(recv_buf))
                {
                    using (var br = new BinaryReader(ms))
                    {
                        var res = new BaseResponse(br);
                        if(res.Valid)
                        {
                            return res.Status == StatusCode.Ok;
                        }
                    }
                }
            }
            return false;
        }


        UdpClient m_client;
        IPEndPoint m_endpoint;
    }
}
