using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lens_editor
{
    public partial class CasaViewer : UserControl
    {
        public CasaViewer()
        {
            InitializeComponent();
        }

        public CasaViewer(string filename) : this()
        {
            try
            {
                m_archive = new CasablancaArchive(filename);

                foreach (var file in m_archive)
                {
                    var elem = new ListViewItem(file.Path);
                    elem.SubItems.Add(file.Hash.ToString("X16"));
                    elem.SubItems.Add(file.Size.ToString() + " bytes");
                    if (file.HasNextVersion)
                    {
                        elem.SubItems.Add(file.NextVersion.ToString("X16"));
                    }
                    list_files.Items.Add(elem);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        CasablancaArchive m_archive;
    }
}
