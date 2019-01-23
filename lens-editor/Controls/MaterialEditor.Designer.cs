namespace lens_editor
{
    partial class MaterialEditor
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_save = new System.Windows.Forms.ToolStripButton();
            this.btn_close = new System.Windows.Forms.ToolStripButton();
            this.btn_set_shader = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new lens_editor.DataGridViewPathCellColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_save,
            this.btn_close,
            this.btn_set_shader});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(339, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_save
            // 
            this.btn_save.Image = global::lens_editor.Properties.Resources.save;
            this.btn_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(51, 22);
            this.btn_save.Text = "Save";
            this.btn_save.Click += new System.EventHandler(this.SaveMaterial);
            // 
            // btn_close
            // 
            this.btn_close.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_close.Image = global::lens_editor.Properties.Resources.discard;
            this.btn_close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(66, 22);
            this.btn_close.Text = "Discard";
            this.btn_close.Click += new System.EventHandler(this.DiscardMaterial);
            // 
            // btn_set_shader
            // 
            this.btn_set_shader.Image = global::lens_editor.Properties.Resources.shader;
            this.btn_set_shader.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_set_shader.Name = "btn_set_shader";
            this.btn_set_shader.Size = new System.Drawing.Size(96, 22);
            this.btn_set_shader.Text = "Select shader";
            this.btn_set_shader.Click += new System.EventHandler(this.SetShader);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.key,
            this.value});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(339, 213);
            this.dataGridView1.TabIndex = 1;
            // 
            // key
            // 
            this.key.HeaderText = "Property";
            this.key.Name = "key";
            // 
            // value
            // 
            this.value.HeaderText = "Value";
            this.value.Name = "value";
            this.value.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.value.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // MaterialEditor
            // 
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MaterialEditor";
            this.Size = new System.Drawing.Size(339, 238);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_save;
        private System.Windows.Forms.ToolStripButton btn_close;
        private System.Windows.Forms.ToolStripButton btn_set_shader;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn key;
        private DataGridViewPathCellColumn value;
    }
}
