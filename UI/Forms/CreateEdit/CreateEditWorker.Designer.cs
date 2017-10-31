namespace UI.Forms.CreateEdit
{
    partial class CreateEditWorker
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtForSalary = new System.Windows.Forms.TextBox();
            this.datePickerForEmploymentDate = new System.Windows.Forms.DateTimePicker();
            this.tabControl.SuspendLayout();
            this.pageForUniversity.SuspendLayout();
            this.pageForWorker.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.pageForWorker);
            this.tabControl.Controls.SetChildIndex(this.pageForWorker, 0);
            this.tabControl.Controls.SetChildIndex(this.pageForUniversity, 0);
            // 
            // pageForWorker
            // 
            this.pageForWorker.Controls.Add(this.datePickerForEmploymentDate);
            this.pageForWorker.Controls.Add(this.txtForSalary);
            this.pageForWorker.Controls.Add(this.label3);
            this.pageForWorker.Controls.Add(this.label1);
            this.pageForWorker.Location = new System.Drawing.Point(4, 22);
            this.pageForWorker.Name = "pageForWorker";
            this.pageForWorker.Size = new System.Drawing.Size(394, 144);
            this.pageForWorker.TabIndex = 2;
            this.pageForWorker.Text = "Worker";
            this.pageForWorker.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(80, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salary:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Employment date:";
            // 
            // txtForSalary
            // 
            this.txtForSalary.Location = new System.Drawing.Point(136, 8);
            this.txtForSalary.Name = "txtForSalary";
            this.txtForSalary.Size = new System.Drawing.Size(197, 20);
            this.txtForSalary.TabIndex = 2;
            // 
            // datePickerForEmploymentDate
            // 
            this.datePickerForEmploymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerForEmploymentDate.Location = new System.Drawing.Point(136, 33);
            this.datePickerForEmploymentDate.Name = "datePickerForEmploymentDate";
            this.datePickerForEmploymentDate.Size = new System.Drawing.Size(197, 20);
            this.datePickerForEmploymentDate.TabIndex = 3;
            this.datePickerForEmploymentDate.Value = new System.DateTime(2010, 9, 1, 0, 0, 0, 0);
            // 
            // CreateEditWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 235);
            this.Name = "CreateEditWorker";
            this.Text = "CreateEditWorker";
            this.tabControl.ResumeLayout(false);
            this.pageForUniversity.ResumeLayout(false);
            this.pageForUniversity.PerformLayout();
            this.pageForWorker.ResumeLayout(false);
            this.pageForWorker.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage pageForWorker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.TextBox txtForSalary;
        protected System.Windows.Forms.DateTimePicker datePickerForEmploymentDate;
    }
}