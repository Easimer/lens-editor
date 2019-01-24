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
    public partial class ResourcePickerDialog : Form
    {
        public ResourcePickerDialog()
        {
            InitializeComponent();

            details.Setup(this);
            resourceList1.details_box = details;
            filter_restype.ResourceList = resourceList1;
        }

        public string FileName
        {
            get
            {
                return details.FileName;
            }
        }
    }
}
