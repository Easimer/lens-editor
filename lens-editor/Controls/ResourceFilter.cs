using System;
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
    public partial class ResourceFilter : UserControl
    {
        private ResourceList resourcelist;

        public ResourceList ResourceList { get => resourcelist; set => resourcelist = value; }

        public ResourceFilter()
        {
            InitializeComponent();
        }

        public enum FilterFlag
        {
            All, Materials, Textures, ShaderPrograms, Shaders, Models, Sound, Music, Misc
        }

        private void OnFilterClick(object sender, EventArgs e)
        {
            field_filter.SelectAll();
            field_filter.Focus();
        }

        private void OnFilterSelect(object sender, EventArgs e)
        {
            var radio = (Control)sender;

            FilterFlag filter;

            switch((string)radio.Tag)
            {
                case "Materials": filter = FilterFlag.Materials; break;
                case "Textures": filter = FilterFlag.Textures; break;
                case "Models": filter = FilterFlag.Models; break;
                case "Sounds": filter = FilterFlag.Sound; break;
                case "Music": filter = FilterFlag.Music; break;
                case "Shaders": filter = FilterFlag.Shaders; break;
                case "ShaderPrograms": filter = FilterFlag.ShaderPrograms; break;
                case "All": default: filter = FilterFlag.All; break;
            }

            ResourceList.filter = filter;
            ResourceList.ResetFileView();
        }

        private void OnFilterChanged(object sender, EventArgs e)
        {
            ResourceList.FilenameFilter = field_filter.Text;
            ResourceList.ResetFileView();
        }
    }
}
