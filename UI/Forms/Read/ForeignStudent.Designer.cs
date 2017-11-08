namespace UI.Forms.Read
{
    partial class ForeignStudent
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
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.lblForUniversity = new System.Windows.Forms.Label();
            this.lblForNationality = new System.Windows.Forms.Label();
            this.groupBox11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.lblForNationality);
            this.groupBox11.Location = new System.Drawing.Point(216, 260);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(177, 57);
            this.groupBox11.TabIndex = 6;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Nationality";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.lblForUniversity);
            this.groupBox12.Location = new System.Drawing.Point(216, 324);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(177, 57);
            this.groupBox12.TabIndex = 7;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Base university";
            // 
            // lblForUniversity
            // 
            this.lblForUniversity.AutoSize = true;
            this.lblForUniversity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblForUniversity.Location = new System.Drawing.Point(31, 25);
            this.lblForUniversity.Name = "lblForUniversity";
            this.lblForUniversity.Size = new System.Drawing.Size(101, 16);
            this.lblForUniversity.TabIndex = 9;
            this.lblForUniversity.Text = "lblForUniversity";
            // 
            // lblForNationality
            // 
            this.lblForNationality.AutoSize = true;
            this.lblForNationality.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblForNationality.Location = new System.Drawing.Point(31, 25);
            this.lblForNationality.Name = "lblForNationality";
            this.lblForNationality.Size = new System.Drawing.Size(105, 16);
            this.lblForNationality.TabIndex = 8;
            this.lblForNationality.Text = "lblForNationality";
            // 
            // ForeignStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(427, 467);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.groupBox11);
            this.Name = "ForeignStudent";
            this.Controls.SetChildIndex(this.groupBox11, 0);
            this.Controls.SetChildIndex(this.groupBox12, 0);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Label lblForNationality;
        private System.Windows.Forms.Label lblForUniversity;
    }
}
