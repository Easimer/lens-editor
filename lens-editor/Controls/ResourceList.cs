using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lens_editor.Controls
{
    public partial class ResourceList : UserControl
    {
        enum ResourceType
        {
            Unknown = 0, Material = 1, Texture = 2, ShaderProgram = 3, Shader = 4, Sound = 5, Music = 6, Model = 7
        }

        public ResourceFilter.FilterFlag filter = ResourceFilter.FilterFlag.All;
        public string FilenameFilter = "";

        public ResourceList()
        {
            InitializeComponent();
            var root = new TreeNode("[root]");
            root.Tag = ".git"; // marking invalid

            if(string.IsNullOrEmpty(Properties.Settings.Default.GameDataPath))
            {
                root.Text = "Path to game data is unset!";
                return;
            }

            AddDirNode(root, Path.Combine(Properties.Settings.Default.GameDataPath, "data"));
            root.ExpandAll();
            tree_dir.Nodes.Add(root);
        }

        void ResetImageList()
        {
            m_image_list = new ImageList();
            m_image_list.Images.Add(Properties.Resources.restype_unknown);
            m_image_list.Images.Add(Properties.Resources.restype_material);
            m_image_list.Images.Add(Properties.Resources.restype_texture);
            m_image_list.Images.Add(Properties.Resources.restype_shaderprogram);
            m_image_list.Images.Add(Properties.Resources.restype_shader);
            m_image_list.Images.Add(Properties.Resources.restype_sound);
            m_image_list.Images.Add(Properties.Resources.restype_music);
            m_image_list.Images.Add(Properties.Resources.restype_model);
            m_image_list.ImageSize = new Size(64, 64);
            list_files.LargeImageList = m_image_list;
        }

        ResourceType DetermineResourceType(string path)
        {
            if (path.EndsWith(".bmp")) return ResourceType.Texture;
            if (path.EndsWith(".png")) return ResourceType.Texture;
            if (path.EndsWith(".wav")) return ResourceType.Sound;
            if (path.EndsWith(".mp3")) return ResourceType.Music;
            if (path.EndsWith(".mat")) return ResourceType.Material;
            if (path.EndsWith(".src.vert")) return ResourceType.Shader;
            if (path.EndsWith(".src.geom")) return ResourceType.Shader;
            if (path.EndsWith(".src.frag")) return ResourceType.Shader;
            if (path.EndsWith(".def")) return ResourceType.ShaderProgram;
            if (path.EndsWith(".obj")) return ResourceType.Model;
            if (path.EndsWith(".fbx")) return ResourceType.Model;
            if (path.EndsWith(".lrf"))
            {
                var t = LRFReader.ArchiveType(path);
                switch(t)
                {
                    case LRFReader.Type.Model: return ResourceType.Model;
                    case LRFReader.Type.Shader: return ResourceType.ShaderProgram;
                    case LRFReader.Type.Texture: return ResourceType.Texture;
                }
            }

            return ResourceType.Unknown;
        }

        bool FilterFile(ResourceType t, ResourceFilter.FilterFlag f)
        {
            switch(f)
            {
                case ResourceFilter.FilterFlag.All:
                    return true;
                case ResourceFilter.FilterFlag.Materials:
                    return t == ResourceType.Material;
                case ResourceFilter.FilterFlag.Models:
                    return t == ResourceType.Model;
                case ResourceFilter.FilterFlag.ShaderPrograms:
                    return t == ResourceType.ShaderProgram;
                case ResourceFilter.FilterFlag.Shaders:
                    return t == ResourceType.Shader;
                case ResourceFilter.FilterFlag.Textures:
                    return t == ResourceType.Texture;
                case ResourceFilter.FilterFlag.Misc:
                    return t == ResourceType.Unknown;
                case ResourceFilter.FilterFlag.Music:
                    return t == ResourceType.Music;
                case ResourceFilter.FilterFlag.Sound:
                    return t == ResourceType.Sound;
            }
            return false;
        }

        int ImageIndex(ResourceType rest)
        {
            switch (rest)
            {
                case ResourceType.Material: return 1;
                case ResourceType.Texture: return 2;
                case ResourceType.ShaderProgram: return 3;
                case ResourceType.Shader: return 4;
                case ResourceType.Sound: return 5;
                case ResourceType.Music: return 6;
                case ResourceType.Model: return 7;
            }
            return 0;
        }

        void AddDirNode(TreeNode root, string path)
        {
            var dir = Path.GetFileName(path);
            var node = new TreeNode(dir);
            node.Tag = path;
            root.Nodes.Add(node);
            foreach(var file in Directory.EnumerateDirectories(path))
            {
                if (file.EndsWith(".git")) continue;
                AddDirNode(node, file);
            }
        }

        private void OnNodeSelected(object sender, TreeNodeMouseClickEventArgs e)
        {
            var newdir = (string)e.Node.Tag;
            if(newdir != ".git")
            {
                m_working_dir = newdir;
                ResetFileView();
            }
        }

        public Bitmap GeneratePreview(string path)
        {
            Bitmap ret = null;
            if(path.EndsWith(".lrf"))
            {
                var tex = LRFReader.LoadTexture(path);

                if (tex == null) return null;

                DXT1Decompressor dxt1 = new DXT1Decompressor((int)tex.width, (int)tex.height, tex.data);
                ret = dxt1.Bitmap;
            }
            else if(path.EndsWith(".bmp") || path.EndsWith(".png"))
            {
                ret = new Bitmap(path);
            }

            return ret;
        }

        public void ResetFileView()
        {
            list_files.Items.Clear();
            ResetImageList();

            foreach(var file in Directory.EnumerateFiles(m_working_dir))
            {
                var rest = DetermineResourceType(file);
                if (!FilterFile(rest, filter))
                    continue;
                if(!string.IsNullOrEmpty(FilenameFilter) && !string.IsNullOrWhiteSpace(FilenameFilter))
                {
                    if(!file.Contains(FilenameFilter))
                    {
                        continue;
                    }
                }
                var it = new ListViewItem();
                it.Text = Path.GetFileName(file);
                if (rest == ResourceType.Texture)
                {
                    var bm = GeneratePreview(file);
                    if(bm == null)
                    {
                        it.ImageIndex = ImageIndex(rest);
                    }
                    else
                    {
                        var idx = m_image_list.Images.Count;
                        m_image_list.Images.Add(bm);
                        it.ImageIndex = idx;
                    }

                    if(!file.EndsWith(".lrf"))
                    {
                        it.ForeColor = Color.Red;
                    }
                }
                else
                {
                    it.ImageIndex = ImageIndex(rest);
                }
                it.Tag = Editor.ResourceShortName(file);
                list_files.Items.Add(it);
            }
        }

        private string m_working_dir;
        private string m_filename;
        private ImageList m_image_list;

        public string FileName { get => m_filename; }
        public ResourceDetails details_box;

        private void OnResourceSelected(object sender, EventArgs e)
        {
            if(list_files.SelectedIndices.Count == 0)
            {
                m_filename = null;
                return;
            }
            m_filename = (string)list_files.Items[list_files.SelectedIndices[0]].Tag;
            if(details_box != null)
            {
                details_box.PathTextBox.Text = m_filename;
                details_box.Clear();
                var full_path = Path.Combine(Properties.Settings.Default.GameDataPath, m_filename);
                if (m_filename.EndsWith(".lrf"))
                {
                    foreach (var kv in LRFReader.ExtractDetails(full_path))
                    {
                        details_box.AddDetail(kv.Key, kv.Value);
                    }
                }
                else if(m_filename.EndsWith(".mat"))
                {
                    LTXT f = new LTXT();
                    f.ReadFromFile(full_path);
                    if(f.Data().ContainsKey("shader"))
                    {
                        details_box.AddDetail("Shader", f["shader"]);
                    }
                }
            }
        }
    }
}
