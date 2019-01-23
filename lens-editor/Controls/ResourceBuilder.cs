using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace lens_editor
{
    public partial class ResourceBuilder : UserControl
    {
        public ResourceBuilder()
        {
            InitializeComponent();
        }

        private void OnBuild(object sender, EventArgs e)
        {
            var source = field_src_path.Text;
            if(string.IsNullOrEmpty(source))
            {
                return;
            }
            switch(Path.GetExtension(source))
            {
                case ".obj":
                case ".fbx":
                    m_proc = CreateModelBuilder(source);
                    break;
                case ".bmp":
                    m_proc = CreateTextureBuilder(source);
                    break;
                default:
                    m_proc = null;
                    break;
            }
            if(m_proc == null)
            {
                field_stdout.Text = Properties.Resources.BuilderUnsupportedFormatHelp;
                return;
            }
            var res = m_proc.Start();

            m_proc.WaitForExit();
            while(m_proc.StandardOutput.Peek() != -1)
            {
                field_stdout.Text += m_proc.StandardOutput.ReadLine() + "\r\n";
            }
            while(m_proc.StandardError.Peek() != -1)
            {
                field_stdout.Text += m_proc.StandardError.ReadLine() + "\r\n";
            }

            field_stdout.Text += string.Format("\r\nProcess has exited with code {0}\r\n", m_proc.ExitCode);

            m_proc.Dispose();
            m_proc = null;
        }

        private Process CreateModelBuilder(string filename)
        {
            Process ret = new Process();
            var dest = Path.ChangeExtension(filename, "lrf");
            field_stdout.Text = "";
            ret.StartInfo.FileName = Path.Combine(Properties.Settings.Default.GameDataPath, "mdlc.exe");
            ret.StartInfo.Arguments = string.Format("{0} {1}", filename, dest);
            ret.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            ret.StartInfo.CreateNoWindow = false;
            ret.StartInfo.UseShellExecute = false;
            ret.StartInfo.RedirectStandardOutput = true;
            ret.StartInfo.RedirectStandardError = true;

            return ret;
        }

        private Process CreateTextureBuilder(string filename)
        {
            Process ret = new Process();

            ret.StartInfo.FileName = Path.Combine(Properties.Settings.Default.GameDataPath, "texpack.exe");
            ret.StartInfo.Arguments = filename;
            ret.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            ret.StartInfo.CreateNoWindow = false;
            ret.StartInfo.UseShellExecute = false;
            ret.StartInfo.RedirectStandardOutput = true;
            ret.StartInfo.RedirectStandardError = true;

            return ret;
        }

        private void OnSourceBrowse(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.InitialDirectory = Path.Combine(Properties.Settings.Default.GameDataPath, "data");
            var res = dialog.ShowDialog();
            if(res == DialogResult.OK)
            {
                field_src_path.Text = dialog.FileName;
                field_dst_path.Text = Path.ChangeExtension(dialog.FileName, "lrf");
            }

        }

        Process m_proc;
    }
}
