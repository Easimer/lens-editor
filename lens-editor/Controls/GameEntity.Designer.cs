namespace lens_editor
{
    partial class GameEntity
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
            this.list_keyvalue = new System.Windows.Forms.ListView();
            this.col_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // list_keyvalue
            // 
            this.list_keyvalue.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_name,
            this.col_type,
            this.col_value});
            this.list_keyvalue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_keyvalue.GridLines = true;
            this.list_keyvalue.Location = new System.Drawing.Point(0, 0);
            this.list_keyvalue.Name = "list_keyvalue";
            this.list_keyvalue.Size = new System.Drawing.Size(388, 134);
            this.list_keyvalue.TabIndex = 0;
            this.list_keyvalue.UseCompatibleStateImageBehavior = false;
            this.list_keyvalue.View = System.Windows.Forms.View.Details;
            // 
            // col_name
            // 
            this.col_name.Text = "Name";
            this.col_name.Width = 80;
            // 
            // col_type
            // 
            this.col_type.Text = "Type";
            // 
            // col_value
            // 
            this.col_value.Text = "Value";
            this.col_value.Width = 180;
            // 
            // GameEntity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.list_keyvalue);
            this.Name = "GameEntity";
            this.Size = new System.Drawing.Size(388, 134);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView list_keyvalue;
        private System.Windows.Forms.ColumnHeader col_name;
        private System.Windows.Forms.ColumnHeader col_type;
        private System.Windows.Forms.ColumnHeader col_value;
    }
}
