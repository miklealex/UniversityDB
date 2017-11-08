namespace UI.Forms.Read
{
    partial class Worker
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
            this.lblForSalary = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.lblForEmploymentDate = new System.Windows.Forms.Label();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.lblForSalary);
            this.groupBox10.Location = new System.Drawing.Point(216, 199);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(177, 55);
            this.groupBox10.TabIndex = 5;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Salary";
            // 
            // lblForSalary
            // 
            this.lblForSalary.AutoSize = true;
            this.lblForSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblForSalary.Location = new System.Drawing.Point(45, 25);
            this.lblForSalary.Name = "lblForSalary";
            this.lblForSalary.Size = new System.Drawing.Size(81, 16);
            this.lblForSalary.TabIndex = 7;
            this.lblForSalary.Text = "lblForSalary";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.lblForEmploymentDate);
            this.groupBox11.Location = new System.Drawing.Point(216, 260);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(177, 55);
            this.groupBox11.TabIndex = 6;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Employment date";
            // 
            // lblForEmploymentDate
            // 
            this.lblForEmploymentDate.AutoSize = true;
            this.lblForEmploymentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblForEmploymentDate.Location = new System.Drawing.Point(15, 25);
            this.lblForEmploymentDate.Name = "lblForEmploymentDate";
            this.lblForEmploymentDate.Size = new System.Drawing.Size(146, 16);
            this.lblForEmploymentDate.TabIndex = 8;
            this.lblForEmploymentDate.Text = "lblForEmploymentDate";
            // 
            // Worker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(427, 467);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.groupBox10);
            this.Name = "Worker";
            this.Text = "Worker";
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
        private System.Windows.Forms.Label lblForSalary;
        private System.Windows.Forms.Label lblForEmploymentDate;
    }
}
