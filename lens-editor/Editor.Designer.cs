namespace lens_editor
{
    partial class Editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_load_resource = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_load_material = new System.Windows.Forms.ToolStripMenuItem();
            this.shaderToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_game_data = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToLocalGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tab_editor = new System.Windows.Forms.TabControl();
            this.tab_resbuild = new System.Windows.Forms.TabPage();
            this.modelBuilder1 = new lens_editor.ResourceBuilder();
            this.menu_load_level = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.tab_editor.SuspendLayout();
            this.tab_resbuild.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(408, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.menu_load_resource,
            this.toolStripSeparator1,
            this.menu_exit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.materialToolStripMenuItem,
            this.shaderToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // materialToolStripMenuItem
            // 
            this.materialToolStripMenuItem.Name = "materialToolStripMenuItem";
            this.materialToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.materialToolStripMenuItem.Text = "&Material";
            this.materialToolStripMenuItem.Click += new System.EventHandler(this.MenuCreateMaterial);
            // 
            // shaderToolStripMenuItem
            // 
            this.shaderToolStripMenuItem.Name = "shaderToolStripMenuItem";
            this.shaderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.shaderToolStripMenuItem.Text = "&Shader";
            this.shaderToolStripMenuItem.Click += new System.EventHandler(this.MenuCreateShader);
            // 
            // menu_load_resource
            // 
            this.menu_load_resource.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_load_material,
            this.shaderToolStripMenuItem1,
            this.menu_load_level});
            this.menu_load_resource.Name = "menu_load_resource";
            this.menu_load_resource.Size = new System.Drawing.Size(180, 22);
            this.menu_load_resource.Text = "&Open";
            // 
            // menu_load_material
            // 
            this.menu_load_material.Name = "menu_load_material";
            this.menu_load_material.Size = new System.Drawing.Size(180, 22);
            this.menu_load_material.Text = "&Material";
            this.menu_load_material.Click += new System.EventHandler(this.MenuLoadMaterial);
            // 
            // shaderToolStripMenuItem1
            // 
            this.shaderToolStripMenuItem1.Name = "shaderToolStripMenuItem1";
            this.shaderToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.shaderToolStripMenuItem1.Text = "&Shader";
            this.shaderToolStripMenuItem1.Click += new System.EventHandler(this.MenuLoadShader);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // menu_exit
            // 
            this.menu_exit.Name = "menu_exit";
            this.menu_exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menu_exit.Size = new System.Drawing.Size(180, 22);
            this.menu_exit.Text = "E&xit";
            this.menu_exit.Click += new System.EventHandler(this.MenuOnExit);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_game_data});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.optionsToolStripMenuItem.Text = "&Edit";
            // 
            // menu_game_data
            // 
            this.menu_game_data.Name = "menu_game_data";
            this.menu_game_data.Size = new System.Drawing.Size(190, 22);
            this.menu_game_data.Text = "Set &path to game data";
            this.menu_game_data.Click += new System.EventHandler(this.MenuSetGameDataPath);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToLocalGameToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // connectToLocalGameToolStripMenuItem
            // 
            this.connectToLocalGameToolStripMenuItem.Name = "connectToLocalGameToolStripMenuItem";
            this.connectToLocalGameToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.connectToLocalGameToolStripMenuItem.Text = "Connect to local game";
            this.connectToLocalGameToolStripMenuItem.Click += new System.EventHandler(this.OnConnectToLocalGame);
            // 
            // tab_editor
            // 
            this.tab_editor.Controls.Add(this.tab_resbuild);
            this.tab_editor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_editor.Location = new System.Drawing.Point(0, 24);
            this.tab_editor.Name = "tab_editor";
            this.tab_editor.SelectedIndex = 0;
            this.tab_editor.Size = new System.Drawing.Size(408, 413);
            this.tab_editor.TabIndex = 1;
            // 
            // tab_resbuild
            // 
            this.tab_resbuild.Controls.Add(this.modelBuilder1);
            this.tab_resbuild.Location = new System.Drawing.Point(4, 22);
            this.tab_resbuild.Name = "tab_resbuild";
            this.tab_resbuild.Padding = new System.Windows.Forms.Padding(3);
            this.tab_resbuild.Size = new System.Drawing.Size(400, 387);
            this.tab_resbuild.TabIndex = 0;
            this.tab_resbuild.Text = "Resource Builder";
            this.tab_resbuild.UseVisualStyleBackColor = true;
            // 
            // modelBuilder1
            // 
            this.modelBuilder1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modelBuilder1.Location = new System.Drawing.Point(3, 3);
            this.modelBuilder1.Name = "modelBuilder1";
            this.modelBuilder1.Size = new System.Drawing.Size(394, 381);
            this.modelBuilder1.TabIndex = 0;
            // 
            // menu_load_level
            // 
            this.menu_load_level.Name = "menu_load_level";
            this.menu_load_level.Size = new System.Drawing.Size(180, 22);
            this.menu_load_level.Text = "Level";
            this.menu_load_level.Click += new System.EventHandler(this.MenuLoadLevel);
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 437);
            this.Controls.Add(this.tab_editor);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.Name = "Editor";
            this.Text = "LENS Resource Editor";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.tab_editor.ResumeLayout(false);
            this.tab_resbuild.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_exit;
        private System.Windows.Forms.ToolStripMenuItem menu_load_resource;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_game_data;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materialToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menu_load_material;
        private System.Windows.Forms.TabControl tab_editor;
        private System.Windows.Forms.TabPage tab_resbuild;
        private ResourceBuilder modelBuilder1;
        private System.Windows.Forms.ToolStripMenuItem shaderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shaderToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToLocalGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_load_level;
    }
}