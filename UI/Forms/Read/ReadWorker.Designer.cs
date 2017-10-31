namespace UI.Forms.Read
{
    partial class ReadWorker
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
            this.pageForWorker = new System.Windows.Forms.TabPage();
            this.lblForEmploymentDate = new System.Windows.Forms.Label();
            this.lblForSalary = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.pageForWorker.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.pageForWorker);
            this.tabControl.Controls.SetChildIndex(this.pageForWorker, 0);
            this.tabControl.Controls.SetChildIndex(this.pageForPerson, 0);
            this.tabControl.Controls.SetChildIndex(this.pageForUniversity, 0);
            // 
            // pageForWorker
            // 
            this.pageForWorker.Controls.Add(this.lblForEmploymentDate);
            this.pageForWorker.Controls.Add(this.lblForSalary);
            this.pageForWorker.Controls.Add(this.label11);
            this.pageForWorker.Controls.Add(this.label10);
            this.pageForWorker.Location = new System.Drawing.Point(4, 22);
            this.pageForWorker.Name = "pageForWorker";
            this.pageForWorker.Size = new System.Drawing.Size(376, 147);
            this.pageForWorker.TabIndex = 2;
            this.pageForWorker.Text = "Worker";
            this.pageForWorker.UseVisualStyleBackColor = true;
            // 
            // lblForEmploymentDate
            // 
            this.lblForEmploymentDate.AutoSize = true;
            this.lblForEmploymentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblForEmploymentDate.Location = new System.Drawing.Point(131, 38);
            this.lblForEmploymentDate.Name = "lblForEmploymentDate";
            this.lblForEmploymentDate.Size = new System.Drawing.Size(146, 16);
            this.lblForEmploymentDate.TabIndex = 3;
            this.lblForEmploymentDate.Text = "lblForEmploymentDate";
            // 
            // lblForSalary
            // 
            this.lblForSalary.AutoSize = true;
            this.lblForSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblForSalary.Location = new System.Drawing.Point(131, 12);
            this.lblForSalary.Name = "lblForSalary";
            this.lblForSalary.Size = new System.Drawing.Size(81, 16);
            this.lblForSalary.TabIndex = 2;
            this.lblForSalary.Text = "lblForSalary";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(3, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "Employment date:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(69, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Salary:";
            // 
            // ReadWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 226);
            this.Name = "ReadWorker";
            this.Text = "Worker";
            this.tabControl.ResumeLayout(false);
            this.pageForWorker.ResumeLayout(false);
            this.pageForWorker.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage pageForWorker;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblForEmploymentDate;
        private System.Windows.Forms.Label lblForSalary;
    }
}