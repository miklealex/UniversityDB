namespace UI.Forms.Read
{
    partial class Teacher
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
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.lblForPosition = new System.Windows.Forms.Label();
            this.groupBox12.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.lblForPosition);
            this.groupBox12.Location = new System.Drawing.Point(216, 324);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(177, 50);
            this.groupBox12.TabIndex = 7;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Position";
            // 
            // lblForPosition
            // 
            this.lblForPosition.AutoSize = true;
            this.lblForPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblForPosition.Location = new System.Drawing.Point(42, 16);
            this.lblForPosition.Name = "lblForPosition";
            this.lblForPosition.Size = new System.Drawing.Size(90, 16);
            this.lblForPosition.TabIndex = 8;
            this.lblForPosition.Text = "lblForPosition";
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(427, 467);
            this.Controls.Add(this.groupBox12);
            this.Name = "Teacher";
            this.Text = "Teacher";
            this.Controls.SetChildIndex(this.groupBox12, 0);
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Label lblForPosition;
    }
}
