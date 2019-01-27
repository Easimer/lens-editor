using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lens_editor
{
    class VectorControl : UserControl
    {
        public VectorControl()
        {
            RecreateFields(N);
        }

        public void UpdateValues(float[] new_values)
        {
            if (new_values == null) return;

            m_values = new_values;
            foreach(TextBox tb in Controls)
            {
                tb.Text = m_values[(int)tb.Tag].ToString();
            }
        }

        void RecreateFields(int N)
        {
            m_n = N;
            Controls.Clear();
            m_values = new float[N];

            for(int i = 0; i < N; i++)
            {
                TextBox tb = new TextBox();
                tb.Size = new System.Drawing.Size(64, 20);
                tb.Location = new System.Drawing.Point(i * 70, 2);
                tb.Text = Values[i].ToString();
                tb.Tag = i;
                Controls.Add(tb);
            }

            Size = MinimumSize = MaximumSize = new System.Drawing.Size((N+0) * 70, 24);
        }

        float[] m_values;
        int m_n;

        public int N { get => m_n; set => RecreateFields(value); }
        public float[] Values { get => m_values; set => UpdateValues(value); }
    }
}
