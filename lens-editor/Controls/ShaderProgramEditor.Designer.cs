namespace lens_editor
{
    partial class ShaderProgramEditor
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_save = new System.Windows.Forms.ToolStripButton();
            this.field_name = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.stage_fragment = new lens_editor.Controls.ShaderProgramStage();
            this.stage_geometry = new lens_editor.Controls.ShaderProgramStage();
            this.stage_vertex = new lens_editor.Controls.ShaderProgramStage();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_save});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(403, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_save
            // 
            this.btn_save.Image = global::lens_editor.Properties.Resources.save;
            this.btn_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(51, 22);
            this.btn_save.Text = "Save";
            this.btn_save.Click += new System.EventHandler(this.OnSave);
            // 
            // field_name
            // 
            this.field_name.Location = new System.Drawing.Point(87, 28);
            this.field_name.Name = "field_name";
            this.field_name.Size = new System.Drawing.Size(296, 20);
            this.field_name.TabIndex = 4;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(3, 31);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(78, 13);
            this.label_name.TabIndex = 5;
            this.label_name.Text = "Program name:";
            // 
            // stage_fragment
            // 
            this.stage_fragment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stage_fragment.Filename = "";
            this.stage_fragment.Location = new System.Drawing.Point(3, 206);
            this.stage_fragment.MaximumSize = new System.Drawing.Size(380, 70);
            this.stage_fragment.MinimumSize = new System.Drawing.Size(380, 70);
            this.stage_fragment.Name = "stage_fragment";
            this.stage_fragment.Size = new System.Drawing.Size(380, 70);
            this.stage_fragment.Stage = lens_editor.Controls.ShaderProgramStage.Type.Fragment;
            this.stage_fragment.TabIndex = 2;
            // 
            // stage_geometry
            // 
            this.stage_geometry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stage_geometry.Filename = "";
            this.stage_geometry.Location = new System.Drawing.Point(3, 130);
            this.stage_geometry.MaximumSize = new System.Drawing.Size(380, 70);
            this.stage_geometry.MinimumSize = new System.Drawing.Size(380, 70);
            this.stage_geometry.Name = "stage_geometry";
            this.stage_geometry.Size = new System.Drawing.Size(380, 70);
            this.stage_geometry.Stage = lens_editor.Controls.ShaderProgramStage.Type.Geometry;
            this.stage_geometry.TabIndex = 1;
            // 
            // stage_vertex
            // 
            this.stage_vertex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stage_vertex.Filename = "";
            this.stage_vertex.Location = new System.Drawing.Point(3, 54);
            this.stage_vertex.MaximumSize = new System.Drawing.Size(380, 70);
            this.stage_vertex.MinimumSize = new System.Drawing.Size(380, 70);
            this.stage_vertex.Name = "stage_vertex";
            this.stage_vertex.Size = new System.Drawing.Size(380, 70);
            this.stage_vertex.Stage = lens_editor.Controls.ShaderProgramStage.Type.Vertex;
            this.stage_vertex.TabIndex = 0;
            // 
            // ShaderProgramEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.field_name);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.stage_fragment);
            this.Controls.Add(this.stage_geometry);
            this.Controls.Add(this.stage_vertex);
            this.Name = "ShaderProgramEditor";
            this.Size = new System.Drawing.Size(403, 360);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.ShaderProgramStage stage_vertex;
        private Controls.ShaderProgramStage stage_geometry;
        private Controls.ShaderProgramStage stage_fragment;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_save;
        private System.Windows.Forms.TextBox field_name;
        private System.Windows.Forms.Label label_name;
    }
}
