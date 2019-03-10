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

            m_entity = new Entity();
            m_entity.classname = ent.classname;

            m_entity.keyvalues.Add(new Keyvalue("position", ent.position));
            m_entity.keyvalues.Add(new Keyvalue("rotation", ent.quaternion));

            UpdateList();
        }

        public GameEntity(Entity ent)
        {
            InitializeComponent();

            m_entity = ent;

            UpdateList();
        }

        void UpdateList()
        {
            var row_cn = new ListViewItem();
            row_cn.Text = "(classname)";
            row_cn.SubItems.Add("");
            row_cn.SubItems.Add(m_entity.classname);
            list_keyvalue.Items.Add(row_cn);
            foreach(var kv in m_entity.keyvalues)
            {
                var row = new ListViewItem();
                row.Text = kv.name;
                if(kv.value is string)
                {
                    row.SubItems.Add("string");
                    row.SubItems.Add(kv.value as string);
                }
                else if(kv.value is float[])
                {
                    var a = kv.value as float[];
                    string v = "(";
                    foreach(var f in a)
                    {
                        v = v + f.ToString() + ", ";
                    }
                    v = v + ")";
                    row.SubItems.Add("vec" + a.Length.ToString());
                    row.SubItems.Add(v);
                }
                else if(kv.value is float)
                {
                    row.SubItems.Add("float");
                    row.SubItems.Add(kv.value.ToString());
                }
                else if(kv.value is int)
                {
                    row.SubItems.Add("int");
                    row.SubItems.Add(kv.value.ToString());
                }
                list_keyvalue.Items.Add(row);
            }
        }

        Entity m_entity;
    }
}
