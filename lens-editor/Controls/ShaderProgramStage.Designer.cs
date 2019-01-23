namespace lens_editor.Controls
{
    partial class ShaderProgramStage
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
            this.group = new System.Windows.Forms.GroupBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.field_path = new System.Windows.Forms.TextBox();
            this.icon_stage = new System.Windows.Forms.PictureBox();
            this.group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_stage)).BeginInit();
            this.SuspendLayout();
            // 
            // group
            // 
            this.group.Controls.Add(this.btn_edit);
            this.group.Controls.Add(this.btn_open);
            this.group.Controls.Add(this.btn_new);
            this.group.Controls.Add(this.field_path);
            this.group.Controls.Add(this.icon_stage);
            this.group.Dock = System.Windows.Forms.DockStyle.Fill;
            this.group.Location = new System.Drawing.Point(0, 0);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(380, 70);
            this.group.TabIndex = 0;
            this.group.TabStop = false;
            this.group.Text = "(name) shader";
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(319, 40);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(56, 23);
            this.btn_edit.TabIndex = 4;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.OnEdit);
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(257, 40);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(56, 23);
            this.btn_open.TabIndex = 3;
            this.btn_open.Text = "Open";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.OnOpen);
            // 
            // btn_new
            // 
            this.btn_new.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_new.Location = new System.Drawing.Point(195, 40);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(55, 24);
            this.btn_new.TabIndex = 2;
            this.btn_new.Text = "New";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.OnCreate);
            // 
            // field_path
            // 
            this.field_path.Location = new System.Drawing.Point(7, 42);
            this.field_path.Name = "field_path";
            this.field_path.Size = new System.Drawing.Size(182, 20);
            this.field_path.TabIndex = 1;
            // 
            // icon_stage
            // 
            this.icon_stage.Location = new System.Drawing.Point(6, 19);
            this.icon_stage.MaximumSize = new System.Drawing.Size(16, 16);
            this.icon_stage.Name = "icon_stage";
            this.icon_stage.Size = new System.Drawing.Size(16, 16);
            this.icon_stage.TabIndex = 0;
            this.icon_stage.TabStop = false;
            // 
            // ShaderProgramStage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.group);
            this.MaximumSize = new System.Drawing.Size(380, 70);
            this.MinimumSize = new System.Drawing.Size(380, 70);
            this.Name = "ShaderProgramStage";
            this.Size = new System.Drawing.Size(380, 70);
            this.group.ResumeLayout(false);
            this.group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_stage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group;
        private System.Windows.Forms.PictureBox icon_stage;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.TextBox field_path;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_open;
    }
}
