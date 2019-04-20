namespace lens_editor
{
    partial class CasaViewer
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
            this.list_files = new System.Windows.Forms.ListView();
            this.hdr_hash = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdr_path = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdr_size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdr_nextver = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // list_files
            // 
            this.list_files.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hdr_path,
            this.hdr_hash,
            this.hdr_size,
            this.hdr_nextver});
            this.list_files.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_files.Location = new System.Drawing.Point(0, 0);
            this.list_files.Name = "list_files";
            this.list_files.Size = new System.Drawing.Size(360, 259);
            this.list_files.TabIndex = 0;
            this.list_files.UseCompatibleStateImageBehavior = false;
            this.list_files.View = System.Windows.Forms.View.Details;
            // 
            // hdr_hash
            // 
            this.hdr_hash.Text = "Hash";
            this.hdr_hash.Width = 80;
            // 
            // hdr_path
            // 
            this.hdr_path.Text = "Path";
            this.hdr_path.Width = 120;
            // 
            // hdr_size
            // 
            this.hdr_size.Text = "Size";
            // 
            // hdr_nextver
            // 
            this.hdr_nextver.Text = "Next version";
            this.hdr_nextver.Width = 80;
            // 
            // CasaViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.list_files);
            this.Name = "CasaViewer";
            this.Size = new System.Drawing.Size(360, 259);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView list_files;
        private System.Windows.Forms.ColumnHeader hdr_path;
        private System.Windows.Forms.ColumnHeader hdr_hash;
        private System.Windows.Forms.ColumnHeader hdr_size;
        private System.Windows.Forms.ColumnHeader hdr_nextver;
    }
}
