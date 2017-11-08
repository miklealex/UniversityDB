namespace UI.Forms.Read
{
    partial class Entrant
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
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.lblForGPA = new System.Windows.Forms.Label();
            this.lblForIEE = new System.Windows.Forms.Label();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.lblForIEE);
            this.groupBox10.Location = new System.Drawing.Point(216, 199);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(177, 55);
            this.groupBox10.TabIndex = 5;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "IEE";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.lblForGPA);
            this.groupBox11.Location = new System.Drawing.Point(216, 262);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(177, 55);
            this.groupBox11.TabIndex = 6;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "GPA";
            // 
            // lblForGPA
            // 
            this.lblForGPA.AutoSize = true;
            this.lblForGPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblForGPA.Location = new System.Drawing.Point(52, 23);
            this.lblForGPA.Name = "lblForGPA";
            this.lblForGPA.Size = new System.Drawing.Size(70, 16);
            this.lblForGPA.TabIndex = 8;
            this.lblForGPA.Text = "lblForGPA";
            // 
            // lblForIEE
            // 
            this.lblForIEE.AutoSize = true;
            this.lblForIEE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblForIEE.Location = new System.Drawing.Point(52, 25);
            this.lblForIEE.Name = "lblForIEE";
            this.lblForIEE.Size = new System.Drawing.Size(63, 16);
            this.lblForIEE.TabIndex = 7;
            this.lblForIEE.Text = "lblForIEE";
            // 
            // Entrant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(427, 467);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.groupBox10);
            this.Name = "Entrant";
            this.Controls.SetChildIndex(this.groupBox10, 0);
            this.Controls.SetChildIndex(this.groupBox11, 0);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label lblForIEE;
        private System.Windows.Forms.Label lblForGPA;
    }
}
