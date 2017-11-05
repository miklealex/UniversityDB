namespace UI.Forms.CreateEdit
{
    partial class WorkerCreating
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtForSalary = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.datePickerForEmploymentDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ok
            // 
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtForSalary);
            this.groupBox5.Location = new System.Drawing.Point(19, 308);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(193, 53);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Salary";
            // 
            // txtForSalary
            // 
            this.txtForSalary.Location = new System.Drawing.Point(6, 22);
            this.txtForSalary.Name = "txtForSalary";
            this.txtForSalary.Size = new System.Drawing.Size(168, 20);
            this.txtForSalary.TabIndex = 3;
            this.txtForSalary.TextChanged += new System.EventHandler(this.txtForSalary_TextChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.datePickerForEmploymentDate);
            this.groupBox6.Location = new System.Drawing.Point(19, 376);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(193, 48);
            this.groupBox6.TabIndex = 20;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Employment date";
            // 
            // datePickerForEmploymentDate
            // 
            this.datePickerForEmploymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerForEmploymentDate.Location = new System.Drawing.Point(6, 19);
            this.datePickerForEmploymentDate.Name = "datePickerForEmploymentDate";
            this.datePickerForEmploymentDate.Size = new System.Drawing.Size(168, 20);
            this.datePickerForEmploymentDate.TabIndex = 21;
            this.datePickerForEmploymentDate.Value = new System.DateTime(2010, 9, 1, 0, 0, 0, 0);
            this.datePickerForEmploymentDate.ValueChanged += new System.EventHandler(this.datePickerForEmploymentDate_ValueChanged);
            // 
            // WorkerCreating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(318, 447);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Name = "WorkerCreating";
            this.Text = "Worker Creating";
            this.Controls.SetChildIndex(this.Cancel, 0);
            this.Controls.SetChildIndex(this.Ok, 0);
            this.Controls.SetChildIndex(this.groupBox5, 0);
            this.Controls.SetChildIndex(this.groupBox6, 0);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        protected System.Windows.Forms.TextBox txtForSalary;
        protected System.Windows.Forms.DateTimePicker datePickerForEmploymentDate;
    }
}
