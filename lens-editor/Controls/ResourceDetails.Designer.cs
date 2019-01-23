namespace lens_editor.Controls
{
    partial class ResourceDetails
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
            this.split_root = new System.Windows.Forms.SplitContainer();
            this.list_details = new System.Windows.Forms.ListView();
            this.hdr_prop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdr_value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_ok = new System.Windows.Forms.Button();
            this.field_path = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.split_root)).BeginInit();
            this.split_root.Panel1.SuspendLayout();
            this.split_root.Panel2.SuspendLayout();
            this.split_root.SuspendLayout();
            this.SuspendLayout();
            // 
            // split_root
            // 
            this.split_root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split_root.Location = new System.Drawing.Point(0, 0);
            this.split_root.Name = "split_root";
            this.split_root.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // split_root.Panel1
            // 
            this.split_root.Panel1.Controls.Add(this.list_details);
            // 
            // split_root.Panel2
            // 
            this.split_root.Panel2.Controls.Add(this.btn_ok);
            this.split_root.Panel2.Controls.Add(this.field_path);
            this.split_root.Size = new System.Drawing.Size(411, 143);
            this.split_root.SplitterDistance = 113;
            this.split_root.TabIndex = 0;
            // 
            // list_details
            // 
            this.list_details.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hdr_prop,
            this.hdr_value});
            this.list_details.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_details.GridLines = true;
            this.list_details.Location = new System.Drawing.Point(0, 0);
            this.list_details.Name = "list_details";
            this.list_details.Size = new System.Drawing.Size(411, 113);
            this.list_details.TabIndex = 0;
            this.list_details.UseCompatibleStateImageBehavior = false;
            this.list_details.View = System.Windows.Forms.View.Details;
            // 
            // hdr_prop
            // 
            this.hdr_prop.Text = "Property";
            this.hdr_prop.Width = 80;
            // 
            // hdr_value
            // 
            this.hdr_value.Text = "Value";
            this.hdr_value.Width = 240;
            // 
            // btn_ok
            // 
            this.btn_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ok.Location = new System.Drawing.Point(333, 1);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 1;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            // 
            // field_path
            // 
            this.field_path.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.field_path.Location = new System.Drawing.Point(3, 3);
            this.field_path.Name = "field_path";
            this.field_path.Size = new System.Drawing.Size(324, 20);
            this.field_path.TabIndex = 0;
            // 
            // ResourceDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.split_root);
            this.Name = "ResourceDetails";
            this.Size = new System.Drawing.Size(411, 143);
            this.split_root.Panel1.ResumeLayout(false);
            this.split_root.Panel2.ResumeLayout(false);
            this.split_root.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.split_root)).EndInit();
            this.split_root.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer split_root;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.TextBox field_path;
        private System.Windows.Forms.ListView list_details;
        private System.Windows.Forms.ColumnHeader hdr_prop;
        private System.Windows.Forms.ColumnHeader hdr_value;
    }
}
