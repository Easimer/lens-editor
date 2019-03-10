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
            m_fields = new TextBox[N];
            RecreateFields(N);
        }

        public void UpdateValues(float[] new_values)
        {
            if (new_values == null) return;

            m_values = new_values;

            for(int i = 0; i < N; i++)
            {
                m_fields[i].Text = m_values[i].ToString();
            }
        }

        void RecreateFields(int N)
        {
            m_n = N;
            Controls.Clear();
            m_fields = new TextBox[N];
            m_values = new float[N];

            for(int i = 0; i < N; i++)
            {
                m_fields[i] = new TextBox();
                m_fields[i].Size = new System.Drawing.Size(64, 20);
                m_fields[i].Location = new System.Drawing.Point(i * 70, 2);
                m_fields[i].Text = m_values[i].ToString();
                m_fields[i].Tag = i;
                Controls.Add(m_fields[i]);
            }

            Size = MinimumSize = MaximumSize = new System.Drawing.Size((N+0) * 70, 24);
        }

        float[] GetValues()
        {
            for(int i = 0; i < N; i++)
            {
                float nv;
                if(float.TryParse(m_fields[i].Text, out nv))
                {
                    m_values[i] = nv;
                }
                else
                {
                    m_fields[i].Text = "NaN";
                }
            }
            return m_values;
        }

        float[] m_values;
        TextBox[] m_fields;
        int m_n;

        public int N { get => m_n; set => RecreateFields(value); }
        public float[] Values { get => GetValues(); set => UpdateValues(value); }
    }
}
