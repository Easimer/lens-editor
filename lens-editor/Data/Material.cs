using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lens_editor
{
    public class Material
    {
        public void AddField(string key, string value)
        {
            m_fields[key] = value;
        }

        public static void WriteToFile(string filename, Material mat)
        {
            LTXT f = new LTXT();
            f.AddField("lens", "material");

            foreach(var field in mat.m_fields)
            {
                f.AddField(field.Key, field.Value);
            }

            f.WriteToFile(filename);
        }

        public static Material ReadFromFile(string filename)
        {
            var ret = new Material();

            if(!File.Exists(filename))
            {
                return null;
            }

            LTXT f = new LTXT();

            f.ReadFromFile(filename);

            foreach(var kv in f.Data())
            {
                ret.AddField(kv.Key, kv.Value);
            }

            return ret;
        }

        public Dictionary<string, string> GetFields()
        {
            return m_fields;
        }

        private Dictionary<string, string> m_fields = new Dictionary<string, string>();
    }
}
