namespace lens_editor
{
    partial class CreateEntityDialog
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.field_classname = new System.Windows.Forms.TextBox();
            this.btn_set_cls = new System.Windows.Forms.Button();
            this.btn_accept = new System.Windows.Forms.Button();
            this.ent_desc = new lens_editor.GameEntity();
            this.SuspendLayout();
            // 
            // field_classname
            // 
            this.field_classname.Location = new System.Drawing.Point(12, 12);
            this.field_classname.Name = "field_classname";
            this.field_classname.Size = new System.Drawing.Size(187, 20);
            this.field_classname.TabIndex = 0;
            this.field_classname.Text = "[classname]";
            // 
            // btn_set_cls
            // 
            this.btn_set_cls.Location = new System.Drawing.Point(205, 10);
            this.btn_set_cls.Name = "btn_set_cls";
            this.btn_set_cls.Size = new System.Drawing.Size(75, 23);
            this.btn_set_cls.TabIndex = 2;
            this.btn_set_cls.Text = "Set";
            this.btn_set_cls.UseVisualStyleBackColor = true;
            this.btn_set_cls.Click += new System.EventHandler(this.OnSetClassname);
            // 
            // btn_accept
            // 
            this.btn_accept.Location = new System.Drawing.Point(276, 187);
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.Size = new System.Drawing.Size(75, 23);
            this.btn_accept.TabIndex = 3;
            this.btn_accept.Text = "Accept";
            this.btn_accept.UseVisualStyleBackColor = true;
            this.btn_accept.Click += new System.EventHandler(this.OnAccept);
            // 
            // CreateEntityDialog
            // 
            this.AcceptButton = this.btn_accept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 222);
            this.Controls.Add(this.btn_accept);
            this.Controls.Add(this.btn_set_cls);
            this.Controls.Add(this.ent_desc);
            this.Controls.Add(this.field_classname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateEntityDialog";
            this.ShowIcon = false;
            this.Text = "CreateEntityDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox field_classname;
        private GameEntity ent_desc;
        private System.Windows.Forms.Button btn_set_cls;
        private System.Windows.Forms.Button btn_accept;
    }
}