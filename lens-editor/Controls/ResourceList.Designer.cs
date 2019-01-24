namespace lens_editor.Controls
{
    partial class ResourceList
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
            this.tree_dir = new System.Windows.Forms.TreeView();
            this.list_files = new System.Windows.Forms.ListView();
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
            // 
            // split_root.Panel1
            // 
            this.split_root.Panel1.Controls.Add(this.tree_dir);
            // 
            // split_root.Panel2
            // 
            this.split_root.Panel2.Controls.Add(this.list_files);
            this.split_root.Size = new System.Drawing.Size(624, 315);
            this.split_root.SplitterDistance = 208;
            this.split_root.TabIndex = 0;
            // 
            // tree_dir
            // 
            this.tree_dir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tree_dir.Location = new System.Drawing.Point(0, 0);
            this.tree_dir.Name = "tree_dir";
            this.tree_dir.Size = new System.Drawing.Size(208, 315);
            this.tree_dir.TabIndex = 0;
            this.tree_dir.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.OnNodeSelected);
            // 
            // list_files
            // 
            this.list_files.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_files.Location = new System.Drawing.Point(0, 0);
            this.list_files.MultiSelect = false;
            this.list_files.Name = "list_files";
            this.list_files.Size = new System.Drawing.Size(412, 315);
            this.list_files.TabIndex = 0;
            this.list_files.UseCompatibleStateImageBehavior = false;
            this.list_files.SelectedIndexChanged += new System.EventHandler(this.OnResourceSelected);
            // 
            // ResourceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.split_root);
            this.Name = "ResourceList";
            this.Size = new System.Drawing.Size(624, 315);
            this.split_root.Panel1.ResumeLayout(false);
            this.split_root.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split_root)).EndInit();
            this.split_root.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer split_root;
        private System.Windows.Forms.TreeView tree_dir;
        private System.Windows.Forms.ListView list_files;
    }
}
