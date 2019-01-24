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

        public void AddDetail(string property, string value)
        {
            var it = new ListViewItem();
            it.Text = property;
            it.SubItems.Add(value);
            list_details.Items.Add(it);
        }

        public void Clear()
        {
            list_details.Items.Clear();
        }

        public string FileName { get => field_path.Text; private set { } }
        public TextBox PathTextBox { get => field_path; private set { } }
    }
}
