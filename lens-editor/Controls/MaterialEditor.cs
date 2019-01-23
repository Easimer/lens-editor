using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace lens_editor
{
    public partial class MaterialEditor : UserControl
    {
        public MaterialEditor(string filename, Material mat, TabPage tab, TabControl tabctl)
        {
            InitializeComponent();

            m_filename = filename;
            m_material = mat;
            m_tab = tab;
            m_tab_control = tabctl;
        }

        public MaterialEditor(Material mat, TabPage tab, TabControl tabctl) : this(null, mat, tab, tabctl)
        {
        }

        private void SaveMaterial(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    var k = row.Cells[0].Value.ToString();
                    var v = row.Cells[1].Value.ToString();
                    m_material.AddField(k, v);
                }
            }

            Material.WriteToFile(m_filename, m_material);
        }

        private void DiscardMaterial(object sender, EventArgs e)
        {
            m_tab_control.TabPages.Remove(m_tab);
            m_tab.Controls.Remove(this);
        }

        public bool HasKey(string key)
        {
            return GetKey(key) != null;
        }

        public string GetKey(string key)
        {
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
            }

            return null;
        }

        public void AddField(string key, string value)
        {
            int idx = dataGridView1.Rows.Add(key, value);
            if (key == "shader")
            {
                dataGridView1.Rows[idx].ReadOnly = false;
            }
        }

        private Material m_material;
        private string m_filename;
        private TabPage m_tab;
        private TabControl m_tab_control;

        private void SetShader(object sender, EventArgs e)
        {
            ShaderDialog d = new ShaderDialog();
            var res = d.ShowDialog();
            if(res == DialogResult.OK)
            {
                m_material.AddField("shader", d.Selected);
                bool rowset = false;
                foreach(DataGridViewRow row in dataGridView1.Rows)
                {
                    if(row.IsNewRow) continue;
                    if(row.Cells[0].Value.ToString() == "shader")
                    {
                        row.Cells[1].Value = d.Selected;
                        rowset = true;
                    }
                }
                if(!rowset)
                {
                    var row = new DataGridViewRow();
                    dataGridView1.Rows.Add("shader", d.Selected);
                }
            }
        }
    }

    public class DataGridViewPathCell : DataGridViewTextBoxCell
    {
        protected override void OnClick(DataGridViewCellEventArgs e)
        {
            ReadOnly = true;
            base.OnClick(e);

            var dialog = new ResourcePickerDialog();
            var res = dialog.ShowDialog();

            if(res == DialogResult.OK)
            {
                Value = dialog.FileName;
            }
            return;
            /*
            var dialog = new OpenFileDialog();
            dialog.InitialDirectory = Editor.GetResourceDirectory(Editor.ResourceType.Texture);
            dialog.Multiselect = false;
            dialog.Title = "Select a texture";
            dialog.Filter = "LENS Texture Format|*.lrf|RGB Bitmap|*.bmp|All files (*.*)|*.*";
            dialog.AutoUpgradeEnabled = true;
            var res = dialog.ShowDialog();

            if(res == DialogResult.OK)
            {
                Value = Editor.ResourceShortName(dialog.FileName);
            }
            */
        }
    }

    public class DataGridViewPathCellColumn : DataGridViewColumn
    {
        public DataGridViewPathCellColumn()
        {
            CellTemplate = new DataGridViewPathCell();
        }
    }
}
