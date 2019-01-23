using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace lens_editor
{
    public partial class Editor : Form
    {
        public Editor()
        {
            InitializeComponent();
            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.GameDataPath))
            {
                this.Text = string.Format("LENS Editor - (path to game data is unset)");
            }
            else
            {
                this.Text = string.Format("LENS Editor - {0}", Properties.Settings.Default.GameDataPath);
            }

        }

        public static string ResourceShortName(string path)
        {
            var uri = new Uri(path);
            var root = new Uri(Path.Combine(Properties.Settings.Default.GameDataPath, "data"));
            return root.MakeRelativeUri(uri).ToString();
        }

        private void MenuLoadMaterial(object sender, EventArgs e)
        {
            string filename = "";
            var dialog = new OpenFileDialog();
            dialog.Filter = "LENS material file|*.mat";
            dialog.Multiselect = false;
            dialog.InitialDirectory = GetResourceDirectory(ResourceType.Material);
            //dialog.FileName;
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                filename = dialog.FileName;
            }
            var mat = Material.ReadFromFile(filename);
            if(mat == null)
            {
                MessageBox.Show("Material load has failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            NewMaterialTab(mat, filename);
        }

        private void NewMaterialTab(Material mat, string filename)
        {
            var tab = new TabPage(ResourceShortName(filename));
            var mat_ed = new MaterialEditor(filename, mat, tab, tab_editor);
            mat_ed.Dock = DockStyle.Fill;

            foreach(var kv in mat.GetFields())
            {
                mat_ed.AddField(kv.Key, kv.Value);
            }

            tab.Controls.Add(mat_ed);
            tab_editor.TabPages.Add(tab);
        }

        private void NewShaderTab(Shader shader, string filename, bool create)
        {
            var tab = new TabPage(ResourceShortName(filename));
            var sh_ed = new ShaderProgramEditor(filename, create);
            sh_ed.Dock = DockStyle.Fill;

            tab.Controls.Add(sh_ed);
            tab_editor.TabPages.Add(tab);
        }

        private void MenuOnExit(object sender, EventArgs e)
        {
            Close();
        }

        private void MenuSetGameDataPath(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            dialog.RootFolder = Environment.SpecialFolder.MyComputer;

            var res = dialog.ShowDialog();

            if(res == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
            {
                Properties.Settings.Default.GameDataPath = dialog.SelectedPath;
                Properties.Settings.Default.Save();

                Environment.CurrentDirectory = dialog.SelectedPath;
                this.Text = string.Format("LENS Editor - {0}", Properties.Settings.Default.GameDataPath);
            }
            dialog.Dispose();
        }

        private void BuildModel(string source)
        {
        }

        private void MenuCreateMaterial(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = "LENS material file|*.mat|All files (*.*)|*.*";
            dialog.InitialDirectory = GetResourceDirectory(ResourceType.Material);
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                var filename = dialog.FileName;
                Material mat = new Material();
                NewMaterialTab(mat, filename);
            }
        }

        private void MenuCreateShader(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = "LENS shader definition|*.def|All files (*.*)|*.*";
            dialog.InitialDirectory = GetResourceDirectory(ResourceType.Shader);
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                var filename = dialog.FileName;
                Shader shader = new Shader();
                NewShaderTab(shader, filename, true);
            }
        }

        private void MenuLoadShader(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "LENS shader definition|*.def|All files (*.*)|*.*";
            dialog.InitialDirectory = GetResourceDirectory(ResourceType.Shader);
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                var filename = dialog.FileName;
                var shader = Shader.FromFile(filename);
                NewShaderTab(shader, filename, false);
            }
        }

        public enum ResourceType
        {
            Material, Texture, Shader, Sound
        }

        public static string GetResourceDirectory(ResourceType t)
        {
            switch(t)
            {
                case ResourceType.Material: return Path.Combine(Properties.Settings.Default.GameDataPath, "data", "materials");
                case ResourceType.Texture: return Path.Combine(Properties.Settings.Default.GameDataPath, "data", "textures");
                case ResourceType.Shader: return Path.Combine(Properties.Settings.Default.GameDataPath, "data", "shaders");
                case ResourceType.Sound: return Path.Combine(Properties.Settings.Default.GameDataPath, "data", "sounds");
            }
            return Properties.Settings.Default.GameDataPath;
        }
    }
}
