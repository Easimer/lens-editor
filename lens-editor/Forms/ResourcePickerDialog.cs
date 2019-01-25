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

        public ResourceFilter.FilterFlag Filter
        {
            get
            {
                return filter_restype.Filter;
            }
            set
            {
                filter_restype.Filter = value;
            }
        }

        public string InitialDirectory
        {
            get => resourceList1.WorkingDirectory;
            set => resourceList1.WorkingDirectory = value;
        }
    }
}
