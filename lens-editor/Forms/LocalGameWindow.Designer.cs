namespace lens_editor
{
    partial class LocalGameWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalGameWindow));
            this.menu = new System.Windows.Forms.ToolStrip();
            this.btn_refresh_ent_list = new System.Windows.Forms.ToolStripButton();
            this.btn_create = new System.Windows.Forms.ToolStripButton();
            this.split_root = new System.Windows.Forms.SplitContainer();
            this.ent_container = new System.Windows.Forms.FlowLayoutPanel();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.split_root)).BeginInit();
            this.split_root.Panel2.SuspendLayout();
            this.split_root.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_refresh_ent_list,
            this.btn_create});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(500, 25);
            this.menu.TabIndex = 0;
            this.menu.Text = "menu";
            // 
            // btn_refresh_ent_list
            // 
            this.btn_refresh_ent_list.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_refresh_ent_list.Image = global::lens_editor.Properties.Resources.ent_sync;
            this.btn_refresh_ent_list.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_refresh_ent_list.Name = "btn_refresh_ent_list";
            this.btn_refresh_ent_list.Size = new System.Drawing.Size(23, 22);
            this.btn_refresh_ent_list.Text = "Refresh entity list";
            this.btn_refresh_ent_list.Click += new System.EventHandler(this.OnRefreshEntities);
            // 
            // btn_create
            // 
            this.btn_create.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_create.Image = ((System.Drawing.Image)(resources.GetObject("btn_create.Image")));
            this.btn_create.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(23, 22);
            this.btn_create.Text = "Create entity";
            this.btn_create.Click += new System.EventHandler(this.OnCreateEntity);
            // 
            // split_root
            // 
            this.split_root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split_root.Location = new System.Drawing.Point(0, 25);
            this.split_root.Name = "split_root";
            // 
            // split_root.Panel2
            // 
            this.split_root.Panel2.Controls.Add(this.ent_container);
            this.split_root.Size = new System.Drawing.Size(500, 425);
            this.split_root.SplitterDistance = 162;
            this.split_root.TabIndex = 1;
            // 
            // ent_container
            // 
            this.ent_container.AutoScroll = true;
            this.ent_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ent_container.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ent_container.Location = new System.Drawing.Point(0, 0);
            this.ent_container.Name = "ent_container";
            this.ent_container.Size = new System.Drawing.Size(334, 425);
            this.ent_container.TabIndex = 0;
            this.ent_container.WrapContents = false;
            // 
            // LocalGameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.split_root);
            this.Controls.Add(this.menu);
            this.Name = "LocalGameWindow";
            this.Text = "LocalGameWindow";
            this.Load += new System.EventHandler(this.OnLoad);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.split_root.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split_root)).EndInit();
            this.split_root.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip menu;
        private System.Windows.Forms.ToolStripButton btn_refresh_ent_list;
        private System.Windows.Forms.SplitContainer split_root;
        private System.Windows.Forms.FlowLayoutPanel ent_container;
        private System.Windows.Forms.ToolStripButton btn_create;
    }
}