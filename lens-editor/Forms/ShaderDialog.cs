using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lens_editor
{
    public partial class ShaderDialog : Form
    {
        public ShaderDialog()
        {
            InitializeComponent();
            m_shaders = Shader.GetShaders();

            foreach(var shader in m_shaders)
            {
                var it = new ListViewItem(shader.name);
                it.Tag = shader;
                list_shader.Items.Add(it);
            }
        }

        List<Shader> m_shaders;

        private void OnOKClick(object sender, EventArgs e)
        {
            var sh = (Shader)list_shader.SelectedItems[0].Tag;
            m_selected = sh.path;
        }

        private string m_selected;

        public string Selected
        {
            get
            {
                return m_selected;
            }

            private set
            {
            }
        }

        private void OnItemSelected(object sender, EventArgs e)
        {
            if(list_shader.SelectedIndices.Count == 0)
            {
                btn_ok.Enabled = false;
                m_selected = null;
            }
            else
            {
                btn_ok.Enabled = true;

                list_details.Items.Clear();
                var sh = (Shader)list_shader.SelectedItems[0].Tag;
                list_details.Items.Add(new ListViewItem(new string[] {"Path", sh.path}));
                foreach(var file in sh.files)
                {
                    var key = TranslateShaderProperty(file.Key);

                    var it = new ListViewItem(key);
                    it.SubItems.Add(file.Value);
                    list_details.Items.Add(it);
                }
            }
        }

        private string TranslateShaderProperty(string key)
        {
            switch(key.ToLower())
            {
                case "name": return "Name";
                case "vertex": return "Vertex shader";
                case "geometry": return "Geometry shader";
                case "fragment": return "Fragment shader";
            }
            return key;
        }
    }
}
