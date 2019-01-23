using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lens_editor
{
    public partial class ShaderProgramEditor : UserControl
    {
        public ShaderProgramEditor() : this(null)
        {
        }
        public ShaderProgramEditor(string filename, bool create = false)
        {
            InitializeComponent();
            m_filename = filename;

            if(!create)
            {
                LTXT f = new LTXT();
                f.ReadFromFile(filename);

                stage_vertex.Filename = f["vertex"] ?? "";
                stage_geometry.Filename = f["geometry"] ?? "";
                stage_fragment.Filename = f["fragment"] ?? "";
                field_name.Text = f["name"] ?? "";
            }
        }

        string m_filename;

        private void OnSave(object sender, EventArgs e)
        {
            if(m_filename == null)
            {
                return;
            }

            LTXT f = new LTXT();

            f.AddField("name", field_name.Text);

            if(stage_vertex.Filename.Length > 0)
            {
                f.AddField("vertex", stage_vertex.Filename);
            }
            if(stage_geometry.Filename.Length > 0)
            {
                f.AddField("geometry", stage_geometry.Filename);
            }
            if(stage_fragment.Filename.Length > 0)
            {
                f.AddField("fragment", stage_fragment.Filename);
            }

            f.WriteToFile(m_filename);
        }
    }
}
