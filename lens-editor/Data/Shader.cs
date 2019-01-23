using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lens_editor
{
    struct Shader
    {
        public string path;
        public string name;
        public Dictionary<string, string> files;

        public static Shader FromFile(string filename)
        {
            Shader ret = new Shader();
            ret.files = new Dictionary<string, string>();

            ret.path = Editor.ResourceShortName(filename);
            ret.name = Path.GetFileName(filename);

            LTXT f = new LTXT();
            f.ReadFromFile(filename);

            foreach(var kv in f.Data())
            {
                ret.files[kv.Key] = kv.Value;
            }

            if(ret.files.ContainsKey("name"))
            {
                ret.name = string.Format("{0} ({1})", ret.files["name"], ret.name);
                ret.files.Remove("name");
            }

            return ret;
        }

        public static void WriteToFile(string filename, Shader shader)
        {
            FileStream fs = File.OpenWrite(filename);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine(string.Format("name:{0}", shader.name));

            foreach(var kv in shader.files)
            {
                sw.WriteLine(string.Format("{0}:{1}", kv.Key, kv.Value));
            }

            sw.Close();
        }

        public static List<Shader> GetShaders()
        {
            List<Shader> ret = new List<Shader>();

            foreach(var file in Directory.EnumerateFiles(Path.Combine(Properties.Settings.Default.GameDataPath, "data\\shaders")))
            {
                if(Path.GetExtension(file).EndsWith("def"))
                {
                    ret.Add(Shader.FromFile(file));
                }
            }

            return ret;
        }
    }
}
