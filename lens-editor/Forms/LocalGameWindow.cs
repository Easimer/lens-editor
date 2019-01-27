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
    public partial class LocalGameWindow : Form
    {
        public LocalGameWindow()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            m_client = new RemoteDebugClient();
            bool retry = true;
            bool second_try = false;

            while(retry)
            {
                if(!m_client.Ping())
                {
                    var res = MessageBox.Show("Failed to connect to the local game. Is it running in Debug mode?", "Connection Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                    switch(res)
                    {
                        case DialogResult.Abort: 
                        case DialogResult.Ignore: retry = false; break;
                        case DialogResult.Retry: second_try = true; break;
                    }
                }
                else
                {
                    if(second_try)
                    {
                        MessageBox.Show("Success", "Connection Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    retry = false;
                }
            }

        }

        RemoteDebugClient m_client;

        private void OnRefreshEntities(object sender, EventArgs e)
        {
            if(m_client != null)
            {
                var entities = m_client.RequestEntityList();
                if(entities == null)
                {
                    return;
                }
                ent_container.Controls.Clear();
                foreach(var ent in entities)
                {
                    ent_container.Controls.Add(new GameEntity(ent));
                }
            }
        }
    }
}
