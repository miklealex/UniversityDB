namespace UI.Forms.CreateEdit
{
    partial class StudentCreating
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
            this.numericUpDownForCourse = new System.Windows.Forms.NumericUpDown();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.datePickerForEntryDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownForCourse)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ok
            // 
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // numericUpDownForCourse
            // 
            this.numericUpDownForCourse.Location = new System.Drawing.Point(6, 16);
            this.numericUpDownForCourse.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownForCourse.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownForCourse.Name = "numericUpDownForCourse";
            this.numericUpDownForCourse.Size = new System.Drawing.Size(174, 20);
            this.numericUpDownForCourse.TabIndex = 19;
            this.numericUpDownForCourse.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownForCourse.ValueChanged += new System.EventHandler(this.numericUpDownForCourse_ValueChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.numericUpDownForCourse);
            this.groupBox5.Location = new System.Drawing.Point(12, 284);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 52);
            this.groupBox5.TabIndex = 20;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Course";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.datePickerForEntryDate);
            this.groupBox6.Location = new System.Drawing.Point(12, 342);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 54);
            this.groupBox6.TabIndex = 21;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Entry date";
            // 
            // datePickerForEntryDate
            // 
            this.datePickerForEntryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerForEntryDate.Location = new System.Drawing.Point(7, 19);
            this.datePickerForEntryDate.Name = "datePickerForEntryDate";
            this.datePickerForEntryDate.Size = new System.Drawing.Size(173, 20);
            this.datePickerForEntryDate.TabIndex = 22;
            this.datePickerForEntryDate.Value = new System.DateTime(2017, 9, 1, 0, 0, 0, 0);
            this.datePickerForEntryDate.ValueChanged += new System.EventHandler(this.datePickerForEntryDate_ValueChanged);
            // 
            // StudentCreating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(318, 449);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Name = "StudentCreating";
            this.Controls.SetChildIndex(this.Cancel, 0);
            this.Controls.SetChildIndex(this.Ok, 0);
            this.Controls.SetChildIndex(this.groupBox5, 0);
            this.Controls.SetChildIndex(this.groupBox6, 0);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownForCourse)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.NumericUpDown numericUpDownForCourse;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        protected System.Windows.Forms.DateTimePicker datePickerForEntryDate;
    }
}
