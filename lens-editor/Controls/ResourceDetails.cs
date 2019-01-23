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
    public partial class ResourceDetails : UserControl
    {
        public ResourceDetails()
        {
            InitializeComponent();
        }

        public void Setup(Form parent)
        {
            parent.AcceptButton = btn_ok;
        }

        public string FileName { get => field_path.Text; private set { } }
    }
}
