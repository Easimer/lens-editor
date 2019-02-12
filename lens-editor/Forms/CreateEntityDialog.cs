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
    public partial class CreateEntityDialog : Form
    {
        public CreateEntityDialog(RemoteDebugClient cli)
        {
            InitializeComponent();

            m_client = cli;
        }

        private void OnSetClassname(object sender, EventArgs e)
        {
            var cls = field_classname.Text;
            ent_desc.Classname = cls;
        }

        private void OnAccept(object sender, EventArgs e)
        {
            m_client.CreateEntity(ent_desc.Classname, ent_desc.Position, ent_desc.Rotation);
        }

        public GameEntity Entity
        {
            get => ent_desc; set => ent_desc = value;
        }

        private RemoteDebugClient m_client;
    }
}
