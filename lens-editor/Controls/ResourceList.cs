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

            AddDirNode(root, Path.Combine(Properties.Settings.Default.GameDataPath, "data"));
            root.ExpandAll();
            tree_dir.Nodes.Add(root);
        }

        ResourceType DetermineResourceType(string path)
        {
            if (path.EndsWith(".bmp")) return ResourceType.Texture;
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

        private void ResetFileView()
        {
            list_files.Items.Clear();

            foreach(var file in Directory.EnumerateFiles(m_working_dir))
            {
                var it = new ListViewItem();
                it.Text = Path.GetFileName(file);
                it.ImageIndex = ImageIndex(DetermineResourceType(file));
                list_files.Items.Add(it);
            }
        }

        private string m_working_dir;
        private ImageList m_image_list;
    }
}
