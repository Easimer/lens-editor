using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace lens_editor
{
    public class Keyvalue
    {
        public Keyvalue() { }
        public Keyvalue(string n, object v) { name = n; value = n; }
        public string name;
        public object value;
    }

    public class Entity
    {
        public List<Keyvalue> keyvalues = new List<Keyvalue>();
        public string classname;
    }

    public class LMFReader
    {
        public LMFReader(string path)
        {
            FileStream fs = File.OpenRead(path);
            using (BinaryReader br = new BinaryReader(fs))
            {
                if(!ReadHeader(br))
                {
                    return;
                }

                ReadEntitiesHeader(br);

                for(int i = 0; i < m_ent_count; i++)
                {
                    m_entities.Add(ReadEntity(br));
                }
            }
        }

        private bool ReadHeader(BinaryReader br)
        {
            var magic = br.ReadUInt32();
            if(magic != 0x327c114f)
            {
                return false;
            }
            return true;
        }

        private void ReadEntitiesHeader(BinaryReader br)
        {
            m_ent_count = br.ReadInt32();
        }

        private Entity ReadEntity(BinaryReader br)
        {
            UInt32 classname_len;
            byte[] classname_raw;
            Entity ent = new Entity();

            classname_len = br.ReadUInt32();
            classname_raw = br.ReadBytes((Int32)classname_len);
            ent.classname = Encoding.ASCII.GetString(classname_raw);

            UInt32 kvcount = br.ReadUInt32();

            while(kvcount-- > 0)
            {
                ent.keyvalues.Add(ReadKeyvalue(br));
            }

            return ent;
        }

        private Keyvalue ReadKeyvalue(BinaryReader br)
        {
            Keyvalue ret = new Keyvalue();

            UInt32 name_len = br.ReadUInt32();
            ret.name = Encoding.ASCII.GetString(br.ReadBytes((Int32)name_len));

            UInt64 offset = br.ReadUInt64();
            UInt32 type = br.ReadUInt32();

            float[] afl;
            UInt32 str_len;

            switch(type)
            {
                case 1: // kvt_float
                    ret.value = br.ReadSingle();
                    break;
                case 2: // kvt_vec3
                    afl = new float[3];
                    afl[0] = br.ReadSingle();
                    afl[1] = br.ReadSingle();
                    afl[2] = br.ReadSingle();
                    ret.value = afl;
                    break;
                case 3: // kvt_vec4
                    afl = new float[4];
                    afl[0] = br.ReadSingle();
                    afl[1] = br.ReadSingle();
                    afl[2] = br.ReadSingle();
                    afl[3] = br.ReadSingle();
                    ret.value = afl;
                    break;
                case 4: // kvt_int
                    ret.value = br.ReadInt32();
                    break;
                case 5: // kvt_uint
                    ret.value = br.ReadUInt32();
                    break;
                case 6: // kvt_int64
                    ret.value = br.ReadInt64();
                    break;
                case 7: // kvt_uint64
                    ret.value = br.ReadUInt64();
                    break;
                case 8: // kvt_model
                case 9: // kvt_string
                    str_len = br.ReadUInt32();
                    ret.value = System.Text.Encoding.ASCII.GetString(br.ReadBytes((int)str_len));
                    break;
            }

            return ret;
        }

        public List<Entity> Entities()
        {
            return m_entities;
        }

        bool m_is_valid = false;
        int m_ent_count = 0;

        List<Entity> m_entities = new List<Entity>();
    }
}
