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

        const string lrf_magic = "Lrf ";
        const UInt32 lrf_magic_i = 0x4C726620;
        const string lrf_chunk_header = "LrfH";
        const string lrf_chunk_3d_palette = "LrP3";
        const string lrf_chunk_4d_palette = "LrP4";
        const string lrf_chunk_3d_mesh = "LrM3";
        const string lrf_chunk_shader = "LrS ";
        const string lrf_chunk_shaderprogram = "LrSP";
        const string lrf_chunk_texture = "LrTx";

        private static bool ReadChunkHeader(BinaryReader br, out string id, out UInt64 siz)
        {
            int pk = -1;
            try
            {
                pk = br.PeekChar();
            }
            catch (Exception)
            {
                id = null;
                siz = 0;
                return false;
            }
            if (pk == -1)
            {
                id = null;
                siz = 0;
                return false;
            }
            var bid = br.ReadChars(4);
            Array.Reverse(bid);
            siz = br.ReadUInt64();
            id = new string(bid);

            return true;
        }

        private static Type HeaderTypeToType(UInt32 type)
        {
            switch(type)
            {
                case 1: return Type.Model;
                case 2: return Type.Shader;
                case 3: return Type.Texture;
            }
            return Type.Unknown;
        }

        public static Type ArchiveType(string path)
        {
            FileStream fs = File.OpenRead(path);
            using (BinaryReader br = new BinaryReader(fs))
            {
                var magic = br.ReadUInt32(); // magic

                if (magic != lrf_magic_i)
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
                return HeaderTypeToType(type);
            }
            return Type.Unknown;
        }

        struct LRFHeader
        {
            UInt32 type;
        }

        class LRF3DMesh
        {
            public string name;
            public UInt64 faces;
            public string material;
            public float[] bb_min = new float[3];
            public float[] bb_max = new float[3];
            public UInt64 bones;
            public UInt64 anims;
        }

        class LRFTexture
        {
            [Flags]
            public enum Flags
            {
                DXT1 = 1
            }
            public UInt32 width, height, components, flags, level;
            public UInt64 size;
        }

        public static Dictionary<string, string> ExtractDetails(string path)
        {
            var ret = new Dictionary<string, string>();

            FileStream fs = File.OpenRead(path);
            using (BinaryReader br = new BinaryReader(fs))
            {
                var magic = br.ReadUInt32(); // magic

                if (magic != 0x4C726620)
                {
                    ret["Warning"] = "Not a valid LRF file!";
                    return ret;
                }

                string id;
                UInt64 siz;

                int mesh_count = 0;

                while (true)
                {
                    if (!ReadChunkHeader(br, out id, out siz))
                    {
                        return ret;
                    }
                    long jmp_to = 0;
                    switch(id)
                    {
                        case lrf_chunk_header:
                            var type = br.ReadUInt32();
                            var stype = HeaderTypeToType(type).ToString();
                            ret["Archive type"] = stype;
                            break;
                        case lrf_chunk_3d_mesh:
                            jmp_to = br.BaseStream.Position + (long)siz;
                            mesh_count++;
                            ret[string.Format("Mesh {0} name", mesh_count)] = new string(br.ReadChars(256));
                            ret[string.Format("Mesh {0} face count", mesh_count)] = br.ReadUInt64().ToString();
                            ret[string.Format("Mesh {0} material", mesh_count)] = new string(br.ReadChars(256));
                            float[] bb_min = new float[3];
                            float[] bb_max = new float[3];
                            bb_min[0] = br.ReadSingle();
                            bb_min[1] = br.ReadSingle();
                            bb_min[2] = br.ReadSingle();
                            bb_max[0] = br.ReadSingle();
                            bb_max[1] = br.ReadSingle();
                            bb_max[2] = br.ReadSingle();
                            ret[string.Format("Mesh {0} bounding box", mesh_count)] =
                                string.Format("({0}, {1}, {2}), ({3}, {4}, {5})",
                                bb_min[0], bb_min[1], bb_min[2], bb_max[0], bb_max[1], bb_max[2]);
                            ret[string.Format("Mesh {0} bone count", mesh_count)] = br.ReadUInt64().ToString();
                            ret[string.Format("Mesh {0} animation count", mesh_count)] = br.ReadUInt64().ToString();
                            br.BaseStream.Seek(jmp_to, SeekOrigin.Begin);
                            break;
                        case lrf_chunk_texture:
                            jmp_to = br.BaseStream.Position + (long)siz;
                            ret["Resolution"] = string.Format("{0}x{1}x{2}", br.ReadUInt32(), br.ReadUInt32(), br.ReadUInt32());
                            var flags = br.ReadUInt32();
                            if((flags & (UInt32)(LRFTexture.Flags.DXT1)) != 0)
                            {
                                ret["Format"] = "DXT1";
                            }
                            else
                            {
                                ret["Format"] = "RGB";
                            }
                            ret["Mipmap level"] = br.ReadUInt32().ToString();
                            ret["Size"] = br.ReadUInt64().ToString();
                            br.BaseStream.Seek(jmp_to, SeekOrigin.Begin);
                            
                            break;
                    }
                }
            }

            return ret;
        }
    }
}
