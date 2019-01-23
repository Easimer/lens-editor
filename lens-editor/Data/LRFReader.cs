using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lens_editor
{
    class LRFReader
    {
        public enum Type
        {
            Unknown, Model, Shader, Texture

        }

        private static bool ReadChunkHeader(BinaryReader br, out string id, out UInt64 siz)
        {
            if(br.PeekChar() == -1)
            {
                id = null;
                siz = 0;
                return false;
            }
            var bid = br.ReadChars(4);
            siz = br.ReadUInt64();
            id = new string(bid);

            return true;
        }

        public static Type ArchiveType(string path)
        {
            FileStream fs = File.OpenRead(path);
            using (BinaryReader br = new BinaryReader(fs))
            {
                var magic = br.ReadUInt32(); // magic

                if (magic != 0x4C726620)
                {
                    return Type.Unknown;
                }

                string id;
                UInt64 siz;

                if (!ReadChunkHeader(br, out id, out siz))
                {
                    return Type.Unknown;
                }
                var type = br.ReadUInt32();
                switch(type)
                {
                    case 0: return Type.Unknown;
                    case 1: return Type.Model;
                    case 2: return Type.Shader;
                    case 3: return Type.Texture;
                }
            }
            return Type.Unknown;
        }
    }
}
