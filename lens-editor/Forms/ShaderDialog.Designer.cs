namespace lens_editor
{
    partial class ShaderDialog
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
            this.list_shader = new System.Windows.Forms.ListView();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.list_details = new System.Windows.Forms.ListView();
            this.hdr_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdr_key = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdr_value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // list_shader
            // 
            this.list_shader.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hdr_name});
            this.list_shader.FullRowSelect = true;
            this.list_shader.GridLines = true;
            this.list_shader.Location = new System.Drawing.Point(12, 12);
            this.list_shader.MultiSelect = false;
            this.list_shader.Name = "list_shader";
            this.list_shader.Size = new System.Drawing.Size(379, 323);
            this.list_shader.TabIndex = 0;
            this.list_shader.UseCompatibleStateImageBehavior = false;
            this.list_shader.View = System.Windows.Forms.View.Details;
            this.list_shader.SelectedIndexChanged += new System.EventHandler(this.OnItemSelected);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(316, 455);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_ok
            // 
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ok.Enabled = false;
            this.btn_ok.Location = new System.Drawing.Point(235, 455);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.OnOKClick);
            // 
            // list_details
            // 
            this.list_details.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hdr_key,
            this.hdr_value});
            this.list_details.GridLines = true;
            this.list_details.Location = new System.Drawing.Point(12, 341);
            this.list_details.MultiSelect = false;
            this.list_details.Name = "list_details";
            this.list_details.Size = new System.Drawing.Size(379, 108);
            this.list_details.TabIndex = 3;
            this.list_details.UseCompatibleStateImageBehavior = false;
            this.list_details.View = System.Windows.Forms.View.Details;
            // 
            // hdr_name
            // 
            this.hdr_name.Text = "Name";
            this.hdr_name.Width = 300;
            // 
            // hdr_key
            // 
            this.hdr_key.Text = "Property";
            this.hdr_key.Width = 100;
            // 
            // hdr_value
            // 
            this.hdr_value.Text = "Value";
            this.hdr_value.Width = 240;
            // 
            // ShaderDialog
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(403, 490);
            this.Controls.Add(this.list_details);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.list_shader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShaderDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Shaders";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView list_shader;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.ListView list_details;
        private System.Windows.Forms.ColumnHeader hdr_name;
        private System.Windows.Forms.ColumnHeader hdr_key;
        private System.Windows.Forms.ColumnHeader hdr_value;
    }
}