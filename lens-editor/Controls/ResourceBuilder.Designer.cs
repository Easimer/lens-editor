namespace lens_editor
{
    partial class ResourceBuilder
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
            this.label_source = new System.Windows.Forms.Label();
            this.field_src_path = new System.Windows.Forms.TextBox();
            this.btn_src_browse = new System.Windows.Forms.Button();
            this.label_destination = new System.Windows.Forms.Label();
            this.field_dst_path = new System.Windows.Forms.TextBox();
            this.btn_build = new System.Windows.Forms.Button();
            this.field_stdout = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_source
            // 
            this.label_source.AutoSize = true;
            this.label_source.Location = new System.Drawing.Point(3, 4);
            this.label_source.Name = "label_source";
            this.label_source.Size = new System.Drawing.Size(41, 13);
            this.label_source.TabIndex = 0;
            this.label_source.Text = "Source";
            // 
            // field_src_path
            // 
            this.field_src_path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.field_src_path.Location = new System.Drawing.Point(3, 20);
            this.field_src_path.Name = "field_src_path";
            this.field_src_path.Size = new System.Drawing.Size(157, 20);
            this.field_src_path.TabIndex = 1;
            // 
            // btn_src_browse
            // 
            this.btn_src_browse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_src_browse.Location = new System.Drawing.Point(166, 18);
            this.btn_src_browse.Name = "btn_src_browse";
            this.btn_src_browse.Size = new System.Drawing.Size(75, 23);
            this.btn_src_browse.TabIndex = 2;
            this.btn_src_browse.Text = "Browse";
            this.btn_src_browse.UseVisualStyleBackColor = true;
            this.btn_src_browse.Click += new System.EventHandler(this.OnSourceBrowse);
            // 
            // label_destination
            // 
            this.label_destination.AutoSize = true;
            this.label_destination.Location = new System.Drawing.Point(4, 47);
            this.label_destination.Name = "label_destination";
            this.label_destination.Size = new System.Drawing.Size(60, 13);
            this.label_destination.TabIndex = 3;
            this.label_destination.Text = "Destination";
            // 
            // field_dst_path
            // 
            this.field_dst_path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.field_dst_path.Location = new System.Drawing.Point(3, 64);
            this.field_dst_path.Name = "field_dst_path";
            this.field_dst_path.Size = new System.Drawing.Size(242, 20);
            this.field_dst_path.TabIndex = 4;
            // 
            // btn_build
            // 
            this.btn_build.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_build.Location = new System.Drawing.Point(3, 235);
            this.btn_build.Name = "btn_build";
            this.btn_build.Size = new System.Drawing.Size(75, 23);
            this.btn_build.TabIndex = 6;
            this.btn_build.Text = "Build";
            this.btn_build.UseVisualStyleBackColor = true;
            this.btn_build.Click += new System.EventHandler(this.OnBuild);
            // 
            // field_stdout
            // 
            this.field_stdout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.field_stdout.Enabled = false;
            this.field_stdout.Location = new System.Drawing.Point(4, 91);
            this.field_stdout.Multiline = true;
            this.field_stdout.Name = "field_stdout";
            this.field_stdout.ReadOnly = true;
            this.field_stdout.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.field_stdout.Size = new System.Drawing.Size(241, 138);
            this.field_stdout.TabIndex = 7;
            // 
            // ModelBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.field_stdout);
            this.Controls.Add(this.btn_build);
            this.Controls.Add(this.field_dst_path);
            this.Controls.Add(this.label_destination);
            this.Controls.Add(this.btn_src_browse);
            this.Controls.Add(this.field_src_path);
            this.Controls.Add(this.label_source);
            this.Name = "ModelBuilder";
            this.Size = new System.Drawing.Size(248, 261);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_source;
        private System.Windows.Forms.TextBox field_src_path;
        private System.Windows.Forms.Button btn_src_browse;
        private System.Windows.Forms.Label label_destination;
        private System.Windows.Forms.TextBox field_dst_path;
        private System.Windows.Forms.Button btn_build;
        private System.Windows.Forms.TextBox field_stdout;
    }
}
