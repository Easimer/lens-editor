using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lens_editor
{
    class LTXT
    {
        public void AddField(string key, string value)
        {
            m_fields.Add(key, value);
        }

        public void WriteToFile(string filename)
        {
            FileStream fs = File.OpenWrite(filename);
            StreamWriter sw = new StreamWriter(fs);

            foreach (var kv in m_fields)
            {
                sw.WriteLine(string.Format("{0}:{1}", kv.Key, kv.Value));
            }

            sw.Close();
        }

        public void ReadFromFile(string filename)
        {
            FileStream fs = File.OpenRead(filename);
            StreamReader sr = new StreamReader(fs);

            while (!sr.EndOfStream)
            {
                var a = sr.ReadLine().Split(':');
                if (a.Length >= 2)
                {
                    m_fields.Add(a[0], a[1]);
                }
            }

            sr.Close();
        }

        public string this[string key]
        {
            get
            {
                if(m_fields.ContainsKey(key))
                {
                    return m_fields[key];
                }
                return null;
            }
            set
            {
                m_fields[key] = value;
            }
        }

        public Dictionary<string, string> Data()
        {
            return m_fields;
        }

        Dictionary<string, string> m_fields = new Dictionary<string, string>();
    }
}
