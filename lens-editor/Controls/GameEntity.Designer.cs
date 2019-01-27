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
            this.label_classname = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.label_rev = new System.Windows.Forms.Label();
            this.field_id = new System.Windows.Forms.TextBox();
            this.field_rev = new System.Windows.Forms.TextBox();
            this.label_position = new System.Windows.Forms.Label();
            this.label_rotation = new System.Windows.Forms.Label();
            this.field_status = new System.Windows.Forms.TextBox();
            this.label_status = new System.Windows.Forms.Label();
            this.vec_rotation = new lens_editor.VectorControl();
            this.vec_position = new lens_editor.VectorControl();
            this.SuspendLayout();
            // 
            // label_classname
            // 
            this.label_classname.AutoSize = true;
            this.label_classname.Location = new System.Drawing.Point(4, 4);
            this.label_classname.Name = "label_classname";
            this.label_classname.Size = new System.Drawing.Size(63, 13);
            this.label_classname.TabIndex = 0;
            this.label_classname.Text = "[classname]";
            // 
            // label_id
            // 
            this.label_id.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(3, 24);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(21, 13);
            this.label_id.TabIndex = 1;
            this.label_id.Text = "ID:";
            // 
            // label_rev
            // 
            this.label_rev.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_rev.AutoSize = true;
            this.label_rev.Location = new System.Drawing.Point(91, 24);
            this.label_rev.Name = "label_rev";
            this.label_rev.Size = new System.Drawing.Size(30, 13);
            this.label_rev.TabIndex = 2;
            this.label_rev.Text = "Rev:";
            // 
            // field_id
            // 
            this.field_id.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.field_id.Location = new System.Drawing.Point(30, 21);
            this.field_id.Name = "field_id";
            this.field_id.Size = new System.Drawing.Size(55, 20);
            this.field_id.TabIndex = 3;
            this.field_id.Text = "0";
            // 
            // field_rev
            // 
            this.field_rev.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.field_rev.Location = new System.Drawing.Point(127, 21);
            this.field_rev.Name = "field_rev";
            this.field_rev.Size = new System.Drawing.Size(55, 20);
            this.field_rev.TabIndex = 4;
            this.field_rev.Text = "0";
            // 
            // label_position
            // 
            this.label_position.AutoSize = true;
            this.label_position.Location = new System.Drawing.Point(4, 58);
            this.label_position.Name = "label_position";
            this.label_position.Size = new System.Drawing.Size(47, 13);
            this.label_position.TabIndex = 6;
            this.label_position.Text = "Position:";
            // 
            // label_rotation
            // 
            this.label_rotation.AutoSize = true;
            this.label_rotation.Location = new System.Drawing.Point(4, 88);
            this.label_rotation.Name = "label_rotation";
            this.label_rotation.Size = new System.Drawing.Size(50, 13);
            this.label_rotation.TabIndex = 7;
            this.label_rotation.Text = "Rotation:";
            // 
            // field_status
            // 
            this.field_status.Location = new System.Drawing.Point(57, 107);
            this.field_status.Name = "field_status";
            this.field_status.Size = new System.Drawing.Size(52, 20);
            this.field_status.TabIndex = 9;
            this.field_status.Text = "0";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(3, 114);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(40, 13);
            this.label_status.TabIndex = 10;
            this.label_status.Text = "Status:";
            // 
            // vec_rotation
            // 
            this.vec_rotation.Location = new System.Drawing.Point(57, 77);
            this.vec_rotation.MaximumSize = new System.Drawing.Size(210, 24);
            this.vec_rotation.MinimumSize = new System.Drawing.Size(210, 24);
            this.vec_rotation.N = 4;
            this.vec_rotation.Name = "vec_rotation";
            this.vec_rotation.Size = new System.Drawing.Size(210, 24);
            this.vec_rotation.TabIndex = 8;
            this.vec_rotation.Values = new float[] {
        0F,
        0F,
        0F,
        0F};
            // 
            // vec_position
            // 
            this.vec_position.Location = new System.Drawing.Point(57, 47);
            this.vec_position.MaximumSize = new System.Drawing.Size(210, 24);
            this.vec_position.MinimumSize = new System.Drawing.Size(210, 24);
            this.vec_position.N = 3;
            this.vec_position.Name = "vec_position";
            this.vec_position.Size = new System.Drawing.Size(210, 24);
            this.vec_position.TabIndex = 5;
            this.vec_position.Values = new float[] {
        0F,
        0F,
        0F};
            // 
            // GameEntity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.field_status);
            this.Controls.Add(this.vec_rotation);
            this.Controls.Add(this.label_rotation);
            this.Controls.Add(this.label_position);
            this.Controls.Add(this.vec_position);
            this.Controls.Add(this.field_rev);
            this.Controls.Add(this.field_id);
            this.Controls.Add(this.label_rev);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.label_classname);
            this.Name = "GameEntity";
            this.Size = new System.Drawing.Size(388, 134);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_classname;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_rev;
        private System.Windows.Forms.TextBox field_id;
        private System.Windows.Forms.TextBox field_rev;
        private VectorControl vec_position;
        private System.Windows.Forms.Label label_position;
        private System.Windows.Forms.Label label_rotation;
        private VectorControl vec_rotation;
        private System.Windows.Forms.TextBox field_status;
        private System.Windows.Forms.Label label_status;
    }
}
