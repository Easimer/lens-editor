namespace lens_editor
{
    partial class ResourceFilter
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
            this.btn_music = new System.Windows.Forms.RadioButton();
            this.btn_snd = new System.Windows.Forms.RadioButton();
            this.field_filter = new System.Windows.Forms.TextBox();
            this.btn_misc = new System.Windows.Forms.RadioButton();
            this.btn_models = new System.Windows.Forms.RadioButton();
            this.btn_shaders = new System.Windows.Forms.RadioButton();
            this.btn_shader_programs = new System.Windows.Forms.RadioButton();
            this.btn_textures = new System.Windows.Forms.RadioButton();
            this.btn_materials = new System.Windows.Forms.RadioButton();
            this.btn_all = new System.Windows.Forms.RadioButton();
            this.group.SuspendLayout();
            this.SuspendLayout();
            // 
            // group
            // 
            this.group.Controls.Add(this.btn_music);
            this.group.Controls.Add(this.btn_snd);
            this.group.Controls.Add(this.field_filter);
            this.group.Controls.Add(this.btn_misc);
            this.group.Controls.Add(this.btn_models);
            this.group.Controls.Add(this.btn_shaders);
            this.group.Controls.Add(this.btn_shader_programs);
            this.group.Controls.Add(this.btn_textures);
            this.group.Controls.Add(this.btn_materials);
            this.group.Controls.Add(this.btn_all);
            this.group.Dock = System.Windows.Forms.DockStyle.Fill;
            this.group.Location = new System.Drawing.Point(0, 0);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(332, 140);
            this.group.TabIndex = 0;
            this.group.TabStop = false;
            this.group.Text = "Filter";
            // 
            // btn_music
            // 
            this.btn_music.AutoSize = true;
            this.btn_music.Location = new System.Drawing.Point(127, 89);
            this.btn_music.Name = "btn_music";
            this.btn_music.Size = new System.Drawing.Size(53, 17);
            this.btn_music.TabIndex = 9;
            this.btn_music.TabStop = true;
            this.btn_music.Tag = "Music";
            this.btn_music.Text = "Music";
            this.btn_music.UseVisualStyleBackColor = true;
            this.btn_music.Click += new System.EventHandler(this.OnFilterSelect);
            // 
            // btn_snd
            // 
            this.btn_snd.AutoSize = true;
            this.btn_snd.Location = new System.Drawing.Point(127, 65);
            this.btn_snd.Name = "btn_snd";
            this.btn_snd.Size = new System.Drawing.Size(56, 17);
            this.btn_snd.TabIndex = 8;
            this.btn_snd.TabStop = true;
            this.btn_snd.Tag = "Sounds";
            this.btn_snd.Text = "Sound";
            this.btn_snd.UseVisualStyleBackColor = true;
            this.btn_snd.Click += new System.EventHandler(this.OnFilterSelect);
            // 
            // field_filter
            // 
            this.field_filter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.field_filter.Location = new System.Drawing.Point(127, 110);
            this.field_filter.Name = "field_filter";
            this.field_filter.Size = new System.Drawing.Size(199, 20);
            this.field_filter.TabIndex = 7;
            this.field_filter.Click += new System.EventHandler(this.OnFilterClick);
            this.field_filter.TextChanged += new System.EventHandler(this.OnFilterChanged);
            // 
            // btn_misc
            // 
            this.btn_misc.AutoSize = true;
            this.btn_misc.Location = new System.Drawing.Point(127, 42);
            this.btn_misc.Name = "btn_misc";
            this.btn_misc.Size = new System.Drawing.Size(47, 17);
            this.btn_misc.TabIndex = 6;
            this.btn_misc.TabStop = true;
            this.btn_misc.Tag = "Misc";
            this.btn_misc.Text = "Misc";
            this.btn_misc.UseVisualStyleBackColor = true;
            this.btn_misc.Click += new System.EventHandler(this.OnFilterSelect);
            // 
            // btn_models
            // 
            this.btn_models.AutoSize = true;
            this.btn_models.Location = new System.Drawing.Point(127, 19);
            this.btn_models.Name = "btn_models";
            this.btn_models.Size = new System.Drawing.Size(59, 17);
            this.btn_models.TabIndex = 5;
            this.btn_models.TabStop = true;
            this.btn_models.Tag = "Models";
            this.btn_models.Text = "Models";
            this.btn_models.UseVisualStyleBackColor = true;
            this.btn_models.Click += new System.EventHandler(this.OnFilterSelect);
            // 
            // btn_shaders
            // 
            this.btn_shaders.AutoSize = true;
            this.btn_shaders.Location = new System.Drawing.Point(6, 113);
            this.btn_shaders.Name = "btn_shaders";
            this.btn_shaders.Size = new System.Drawing.Size(64, 17);
            this.btn_shaders.TabIndex = 4;
            this.btn_shaders.TabStop = true;
            this.btn_shaders.Tag = "Shaders";
            this.btn_shaders.Text = "Shaders";
            this.btn_shaders.UseVisualStyleBackColor = true;
            this.btn_shaders.Click += new System.EventHandler(this.OnFilterSelect);
            // 
            // btn_shader_programs
            // 
            this.btn_shader_programs.AutoSize = true;
            this.btn_shader_programs.Location = new System.Drawing.Point(6, 89);
            this.btn_shader_programs.Name = "btn_shader_programs";
            this.btn_shader_programs.Size = new System.Drawing.Size(105, 17);
            this.btn_shader_programs.TabIndex = 3;
            this.btn_shader_programs.TabStop = true;
            this.btn_shader_programs.Tag = "ShaderPrograms";
            this.btn_shader_programs.Text = "Shader programs";
            this.btn_shader_programs.UseVisualStyleBackColor = true;
            this.btn_shader_programs.Click += new System.EventHandler(this.OnFilterSelect);
            // 
            // btn_textures
            // 
            this.btn_textures.AutoSize = true;
            this.btn_textures.Location = new System.Drawing.Point(6, 65);
            this.btn_textures.Name = "btn_textures";
            this.btn_textures.Size = new System.Drawing.Size(66, 17);
            this.btn_textures.TabIndex = 2;
            this.btn_textures.TabStop = true;
            this.btn_textures.Tag = "Textures";
            this.btn_textures.Text = "Textures";
            this.btn_textures.UseVisualStyleBackColor = true;
            this.btn_textures.Click += new System.EventHandler(this.OnFilterSelect);
            // 
            // btn_materials
            // 
            this.btn_materials.AutoSize = true;
            this.btn_materials.Location = new System.Drawing.Point(6, 42);
            this.btn_materials.Name = "btn_materials";
            this.btn_materials.Size = new System.Drawing.Size(67, 17);
            this.btn_materials.TabIndex = 1;
            this.btn_materials.TabStop = true;
            this.btn_materials.Tag = "Materials";
            this.btn_materials.Text = "Materials";
            this.btn_materials.UseVisualStyleBackColor = true;
            this.btn_materials.Click += new System.EventHandler(this.OnFilterSelect);
            // 
            // btn_all
            // 
            this.btn_all.AutoSize = true;
            this.btn_all.Checked = true;
            this.btn_all.Location = new System.Drawing.Point(6, 19);
            this.btn_all.Name = "btn_all";
            this.btn_all.Size = new System.Drawing.Size(36, 17);
            this.btn_all.TabIndex = 0;
            this.btn_all.TabStop = true;
            this.btn_all.Tag = "All";
            this.btn_all.Text = "All";
            this.btn_all.UseVisualStyleBackColor = true;
            this.btn_all.Click += new System.EventHandler(this.OnFilterSelect);
            // 
            // ResourceFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.group);
            this.MinimumSize = new System.Drawing.Size(200, 140);
            this.Name = "ResourceFilter";
            this.Size = new System.Drawing.Size(332, 140);
            this.group.ResumeLayout(false);
            this.group.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group;
        private System.Windows.Forms.RadioButton btn_materials;
        private System.Windows.Forms.RadioButton btn_all;
        private System.Windows.Forms.RadioButton btn_textures;
        private System.Windows.Forms.RadioButton btn_shader_programs;
        private System.Windows.Forms.RadioButton btn_shaders;
        private System.Windows.Forms.RadioButton btn_models;
        private System.Windows.Forms.RadioButton btn_misc;
        private System.Windows.Forms.TextBox field_filter;
        private System.Windows.Forms.RadioButton btn_music;
        private System.Windows.Forms.RadioButton btn_snd;
    }
}
