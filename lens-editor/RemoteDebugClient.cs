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
    class RemoteDebugClient
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
        }

        enum StatusCode
        {
            Null = 0,
            Ok = 1,
            BadRequest = 2,
            NotImplemented = 3,
        }

        public bool Ping()
        {
            byte[] buf = null;
            using (var ms = new MemoryStream())
            {
                using (var bw = new BinaryWriter(ms))
                {
                    bw.Write(new char[] { 'R', 'D', 'R', 'Q' });
                    bw.Write((UInt32)RequestType.Ping);
                    bw.Write((UInt32)0);
                    bw.Flush();
                    buf = ms.GetBuffer();
                    m_client.Send(buf, buf.Length);
                }
            }
            var wait_start = DateTime.Now;
            //while (DateTime.Now - wait_start > TimeSpan.FromMilliseconds(500))
            while(true)
            {
                if (m_client.Available > 0)
                {
                    buf = m_client.Receive(ref m_endpoint);
                    break;
                }
            }
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


        UdpClient m_client;
        IPEndPoint m_endpoint;
    }
}
