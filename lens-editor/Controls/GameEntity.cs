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
    public partial class GameEntity : UserControl
    {
        public GameEntity()
        {
            InitializeComponent();
        }

        public GameEntity(RemoteDebugClient.Entity ent)
        {
            InitializeComponent();

            ID = (int)ent.id;
            Revision = (int)ent.rev;
            Classname = ent.classname;
            Position = ent.position;
            Rotation = ent.quaternion;
            Status = ent.status;
        }

        public int ID { get => int.Parse(field_id.Text); set => field_id.Text = value.ToString(); }
        public int Revision { get => int.Parse(field_rev.Text); set => field_rev.Text = value.ToString(); }
        public string Classname { get => label_classname.Text; set => label_classname.Text = value; }
        public float[] Position { get => vec_position.Values; set => vec_position.Values = value; }
        public float[] Rotation { get => vec_rotation.Values; set => vec_rotation.Values = value; }
        public RemoteDebugClient.Entity.Status Status { get => (RemoteDebugClient.Entity.Status)int.Parse(field_status.Text); set => field_status.Text = ((int)value).ToString(); }
    }
}
