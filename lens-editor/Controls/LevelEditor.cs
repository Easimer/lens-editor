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
    partial class LevelEditor : UserControl
    {
        public LevelEditor(string filename, bool create)
        {
            InitializeComponent();

            LMFReader r = new LMFReader(filename);

            foreach(var ent in r.Entities())
            {
                entities.Controls.Add(new GameEntity(ent));
            }
        }
    }
}
