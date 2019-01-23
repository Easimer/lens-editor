namespace lens_editor
{
    partial class ResourcePickerDialog
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
            this.split_root = new System.Windows.Forms.SplitContainer();
            this.split_bottom = new System.Windows.Forms.SplitContainer();
            this.resourceList1 = new lens_editor.Controls.ResourceList();
            this.details = new lens_editor.Controls.ResourceDetails();
            this.filter_restype = new lens_editor.Controls.ResourceFilter();
            ((System.ComponentModel.ISupportInitialize)(this.split_root)).BeginInit();
            this.split_root.Panel1.SuspendLayout();
            this.split_root.Panel2.SuspendLayout();
            this.split_root.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.split_bottom)).BeginInit();
            this.split_bottom.Panel1.SuspendLayout();
            this.split_bottom.Panel2.SuspendLayout();
            this.split_bottom.SuspendLayout();
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
            this.split_root.Panel1.Controls.Add(this.resourceList1);
            // 
            // split_root.Panel2
            // 
            this.split_root.Panel2.Controls.Add(this.split_bottom);
            this.split_root.Size = new System.Drawing.Size(800, 450);
            this.split_root.SplitterDistance = 285;
            this.split_root.TabIndex = 0;
            // 
            // split_bottom
            // 
            this.split_bottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split_bottom.Location = new System.Drawing.Point(0, 0);
            this.split_bottom.Name = "split_bottom";
            // 
            // split_bottom.Panel1
            // 
            this.split_bottom.Panel1.Controls.Add(this.details);
            // 
            // split_bottom.Panel2
            // 
            this.split_bottom.Panel2.Controls.Add(this.filter_restype);
            this.split_bottom.Size = new System.Drawing.Size(800, 161);
            this.split_bottom.SplitterDistance = 579;
            this.split_bottom.TabIndex = 0;
            // 
            // resourceList1
            // 
            this.resourceList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resourceList1.Location = new System.Drawing.Point(0, 0);
            this.resourceList1.Name = "resourceList1";
            this.resourceList1.Size = new System.Drawing.Size(800, 285);
            this.resourceList1.TabIndex = 0;
            // 
            // details
            // 
            this.details.Dock = System.Windows.Forms.DockStyle.Fill;
            this.details.Location = new System.Drawing.Point(0, 0);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(579, 161);
            this.details.TabIndex = 0;
            // 
            // filter_restype
            // 
            this.filter_restype.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filter_restype.Location = new System.Drawing.Point(0, 0);
            this.filter_restype.MinimumSize = new System.Drawing.Size(200, 140);
            this.filter_restype.Name = "filter_restype";
            this.filter_restype.Size = new System.Drawing.Size(217, 161);
            this.filter_restype.TabIndex = 0;
            // 
            // ResourcePickerDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.split_root);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResourcePickerDialog";
            this.ShowIcon = false;
            this.Text = "Resources";
            this.split_root.Panel1.ResumeLayout(false);
            this.split_root.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split_root)).EndInit();
            this.split_root.ResumeLayout(false);
            this.split_bottom.Panel1.ResumeLayout(false);
            this.split_bottom.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split_bottom)).EndInit();
            this.split_bottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer split_root;
        private System.Windows.Forms.SplitContainer split_bottom;
        private Controls.ResourceFilter filter_restype;
        private Controls.ResourceList resourceList1;
        private Controls.ResourceDetails details;
    }
}