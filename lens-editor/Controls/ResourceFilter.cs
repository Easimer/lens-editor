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
        public ResourceFilter()
        {
            InitializeComponent();
        }

        public enum FilterFlag
        {
            All, Materials, Textures, ShaderPrograms, Shaders, Models, Misc
        }

        private void OnFilterClick(object sender, EventArgs e)
        {
            field_filter.SelectAll();
            field_filter.Focus();
        }
    }
}
