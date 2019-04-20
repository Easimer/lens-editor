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
    public partial class LevelEditorDialog : Form
    {
        List<Entity> m_entities = new List<Entity>();
        public LevelEditorDialog()
        {
            InitializeComponent();
            grid.Entities = m_entities;
            var test_ent = new Entity();
            var kv_post = new Keyvalue("position", new float[] { 0, 0, 0 });
            test_ent.classname = "test";
            test_ent.keyvalues.Add(kv_post);
            m_entities.Add(test_ent);
        }
    }
}
