namespace UI.Forms.CreateEdit
{
    partial class CreateEditForeignStudent
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
            this.pageForForeignStudent = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtForNationality = new System.Windows.Forms.TextBox();
            this.txtForUniversity = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownForCourse)).BeginInit();
            this.tabControl.SuspendLayout();
            this.pageForUObject.SuspendLayout();
            this.pageForForeignStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.pageForForeignStudent);
            this.tabControl.Controls.SetChildIndex(this.pageForForeignStudent, 0);
            this.tabControl.Controls.SetChildIndex(this.pageForUObject, 0);
            // 
            // pageForForeignStudent
            // 
            this.pageForForeignStudent.Controls.Add(this.txtForUniversity);
            this.pageForForeignStudent.Controls.Add(this.txtForNationality);
            this.pageForForeignStudent.Controls.Add(this.label10);
            this.pageForForeignStudent.Controls.Add(this.label4);
            this.pageForForeignStudent.Location = new System.Drawing.Point(4, 22);
            this.pageForForeignStudent.Name = "pageForForeignStudent";
            this.pageForForeignStudent.Size = new System.Drawing.Size(394, 144);
            this.pageForForeignStudent.TabIndex = 3;
            this.pageForForeignStudent.Text = "Foreign Student";
            this.pageForForeignStudent.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(56, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nationality:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(60, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "University:";
            // 
            // txtForNationality
            // 
            this.txtForNationality.Location = new System.Drawing.Point(136, 8);
            this.txtForNationality.Name = "txtForNationality";
            this.txtForNationality.Size = new System.Drawing.Size(197, 20);
            this.txtForNationality.TabIndex = 2;
            // 
            // txtForUniversity
            // 
            this.txtForUniversity.Location = new System.Drawing.Point(136, 33);
            this.txtForUniversity.Name = "txtForUniversity";
            this.txtForUniversity.Size = new System.Drawing.Size(197, 20);
            this.txtForUniversity.TabIndex = 3;
            // 
            // CreateEditForeignStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 235);
            this.Name = "CreateEditForeignStudent";
            this.Text = "CreateEditForeignStudent";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownForCourse)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.pageForUObject.ResumeLayout(false);
            this.pageForUObject.PerformLayout();
            this.pageForForeignStudent.ResumeLayout(false);
            this.pageForForeignStudent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage pageForForeignStudent;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        protected System.Windows.Forms.TextBox txtForUniversity;
        protected System.Windows.Forms.TextBox txtForNationality;
    }
}