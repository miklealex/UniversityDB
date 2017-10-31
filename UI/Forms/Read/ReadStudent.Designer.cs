namespace UI.Forms.Read
{
    partial class ReadStudent
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
            this.lblForEntryDate = new System.Windows.Forms.Label();
            this.lblForCourse = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.pageForStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.pageForStudent);
            this.tabControl.Controls.SetChildIndex(this.pageForStudent, 0);
            this.tabControl.Controls.SetChildIndex(this.pageForPerson, 0);
            this.tabControl.Controls.SetChildIndex(this.pageForUObject, 0);
            // 
            // pageForStudent
            // 
            this.pageForStudent.Controls.Add(this.lblForEntryDate);
            this.pageForStudent.Controls.Add(this.lblForCourse);
            this.pageForStudent.Controls.Add(this.label11);
            this.pageForStudent.Controls.Add(this.label10);
            this.pageForStudent.Location = new System.Drawing.Point(4, 22);
            this.pageForStudent.Name = "pageForStudent";
            this.pageForStudent.Size = new System.Drawing.Size(376, 147);
            this.pageForStudent.TabIndex = 2;
            this.pageForStudent.Text = "Student";
            this.pageForStudent.UseVisualStyleBackColor = true;
            // 
            // lblForEntryDate
            // 
            this.lblForEntryDate.AutoSize = true;
            this.lblForEntryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblForEntryDate.Location = new System.Drawing.Point(131, 37);
            this.lblForEntryDate.Name = "lblForEntryDate";
            this.lblForEntryDate.Size = new System.Drawing.Size(101, 16);
            this.lblForEntryDate.TabIndex = 3;
            this.lblForEntryDate.Text = "lblForEntryDate";
            // 
            // lblForCourse
            // 
            this.lblForCourse.AutoSize = true;
            this.lblForCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblForCourse.Location = new System.Drawing.Point(131, 12);
            this.lblForCourse.Name = "lblForCourse";
            this.lblForCourse.Size = new System.Drawing.Size(85, 16);
            this.lblForCourse.TabIndex = 2;
            this.lblForCourse.Text = "lblForCourse";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(42, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "Entry date:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(59, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Course:";
            // 
            // ReadStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 226);
            this.Name = "ReadStudent";
            this.Text = "Student";
            this.tabControl.ResumeLayout(false);
            this.pageForStudent.ResumeLayout(false);
            this.pageForStudent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.TabPage pageForStudent;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblForEntryDate;
        private System.Windows.Forms.Label lblForCourse;
    }
}