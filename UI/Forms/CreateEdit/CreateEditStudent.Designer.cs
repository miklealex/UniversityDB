namespace UI.Forms.CreateEdit
{
    partial class CreateEditStudent
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
            this.pageForStudent = new System.Windows.Forms.TabPage();
            this.numericUpDownForCourse = new System.Windows.Forms.NumericUpDown();
            this.datePickerForEntryDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.pageForUObject.SuspendLayout();
            this.pageForStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownForCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.pageForStudent);
            this.tabControl.Controls.SetChildIndex(this.pageForStudent, 0);
            this.tabControl.Controls.SetChildIndex(this.pageForUObject, 0);
            // 
            // pageForStudent
            // 
            this.pageForStudent.Controls.Add(this.numericUpDownForCourse);
            this.pageForStudent.Controls.Add(this.datePickerForEntryDate);
            this.pageForStudent.Controls.Add(this.label3);
            this.pageForStudent.Controls.Add(this.label1);
            this.pageForStudent.Location = new System.Drawing.Point(4, 22);
            this.pageForStudent.Name = "pageForStudent";
            this.pageForStudent.Size = new System.Drawing.Size(394, 144);
            this.pageForStudent.TabIndex = 2;
            this.pageForStudent.Text = "Student";
            this.pageForStudent.UseVisualStyleBackColor = true;
            // 
            // numericUpDownForCourse
            // 
            this.numericUpDownForCourse.Location = new System.Drawing.Point(136, 8);
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
            this.numericUpDownForCourse.Size = new System.Drawing.Size(197, 20);
            this.numericUpDownForCourse.TabIndex = 4;
            this.numericUpDownForCourse.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // datePickerForEntryDate
            // 
            this.datePickerForEntryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerForEntryDate.Location = new System.Drawing.Point(136, 33);
            this.datePickerForEntryDate.Name = "datePickerForEntryDate";
            this.datePickerForEntryDate.Size = new System.Drawing.Size(197, 20);
            this.datePickerForEntryDate.TabIndex = 3;
            this.datePickerForEntryDate.Value = new System.DateTime(2017, 9, 1, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(59, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Entry date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(76, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course:";
            // 
            // CreateEditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 235);
            this.Name = "CreateEditStudent";
            this.Text = "CreateEditStudent";
            this.tabControl.ResumeLayout(false);
            this.pageForUObject.ResumeLayout(false);
            this.pageForUObject.PerformLayout();
            this.pageForStudent.ResumeLayout(false);
            this.pageForStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownForCourse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage pageForStudent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.DateTimePicker datePickerForEntryDate;
        protected System.Windows.Forms.NumericUpDown numericUpDownForCourse;
    }
}