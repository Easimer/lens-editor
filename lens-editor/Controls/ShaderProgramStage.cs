﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lens_editor.Controls
{
    public partial class ShaderProgramStage : UserControl
    {
        public ShaderProgramStage()
        {
            InitializeComponent();

            OnTypeChange();
        }

        private void OnTypeChange()
        {
            switch(m_type)
            {
                case Type.Vertex:
                    group.Text = "Vertex shader";
                    icon_stage.Image = Properties.Resources.stage_vertex;
                    break;
                case Type.Geometry:
                    group.Text = "Geometry shader";
                    icon_stage.Image = Properties.Resources.stage_geometry;
                    break;
                case Type.Fragment:
                    group.Text = "Fragment shader";
                    icon_stage.Image = Properties.Resources.stage_fragment;
                    break;
            }
        }

        public enum Type
        {
            Vertex, Geometry, Fragment
        }

        public Type Stage
        {
            get
            {
                return m_type;
            }
            set
            {
                m_type = value;
                OnTypeChange();
            }
        }

        public string Filename
        {
            get
            {
                return field_path.Text;
            }
            set
            {
                field_path.Text = value;
            }
        }

        Type m_type = Type.Vertex;

        private string GetExtension()
        {
            switch(m_type)
            {
                case Type.Vertex: return "*.src.vert";
                case Type.Geometry: return "*.src.geom";
                case Type.Fragment: return "*.src.frag";
                default: return "*.txt";
            }
        }

        private void OpenForEditing(string filename)
        {
            System.Diagnostics.Process.Start(Path.Combine(Properties.Settings.Default.GameDataPath, filename));
        }

        private string ShaderDialog(FileDialog d)
        {
            d.Filter = string.Format("Shader source|{0}|All files (*.*)|*.*", GetExtension());
            d.InitialDirectory = Path.Combine(Properties.Settings.Default.GameDataPath, "data\\shaders");

            var res = d.ShowDialog();

            if(res == DialogResult.OK)
            {
                field_path.Text = Editor.ResourceShortName(d.FileName);
                return d.FileName;
            }
            return null;
        }

        private void OnCreate(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            var fn = ShaderDialog(dialog);
            File.Create(fn).Dispose();
        }

        private void OnOpen(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            ShaderDialog(dialog);
        }

        private void OnEdit(object sender, EventArgs e)
        {
            if(field_path.Text.Length == 0)
            {
                return;
            }
            OpenForEditing(field_path.Text);
        }
    }
}
