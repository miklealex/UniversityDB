namespace UI.Forms.Read
{
    partial class Student
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
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.lblForEntryDate = new System.Windows.Forms.Label();
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.lblForEntryDate);
            this.groupBox10.Location = new System.Drawing.Point(216, 198);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(177, 56);
            this.groupBox10.TabIndex = 5;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Entry date";
            // 
            // lblForEntryDate
            // 
            this.lblForEntryDate.AutoSize = true;
            this.lblForEntryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblForEntryDate.Location = new System.Drawing.Point(45, 26);
            this.lblForEntryDate.Name = "lblForEntryDate";
            this.lblForEntryDate.Size = new System.Drawing.Size(101, 16);
            this.lblForEntryDate.TabIndex = 6;
            this.lblForEntryDate.Text = "lblForEntryDate";
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(427, 467);
            this.Controls.Add(this.groupBox10);
            this.Name = "Student";
            this.Text = "Student";
            this.Controls.SetChildIndex(this.groupBox10, 0);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label lblForEntryDate;
    }
}
