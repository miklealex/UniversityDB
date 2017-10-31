namespace UI.Forms.Read
{
    partial class ReadForeignStudent
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
            this.lblForUniversity = new System.Windows.Forms.Label();
            this.lblForNationality = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.pageForForeignStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.pageForForeignStudent);
            this.tabControl.Controls.SetChildIndex(this.pageForForeignStudent, 0);
            this.tabControl.Controls.SetChildIndex(this.pageForStudent, 0);
            this.tabControl.Controls.SetChildIndex(this.pageForPerson, 0);
            this.tabControl.Controls.SetChildIndex(this.pageForUObject, 0);
            // 
            // pageForForeignStudent
            // 
            this.pageForForeignStudent.Controls.Add(this.lblForUniversity);
            this.pageForForeignStudent.Controls.Add(this.lblForNationality);
            this.pageForForeignStudent.Controls.Add(this.label13);
            this.pageForForeignStudent.Controls.Add(this.label12);
            this.pageForForeignStudent.Location = new System.Drawing.Point(4, 22);
            this.pageForForeignStudent.Name = "pageForForeignStudent";
            this.pageForForeignStudent.Size = new System.Drawing.Size(376, 147);
            this.pageForForeignStudent.TabIndex = 3;
            this.pageForForeignStudent.Text = "Foreign Student";
            this.pageForForeignStudent.UseVisualStyleBackColor = true;
            // 
            // lblForUniversity
            // 
            this.lblForUniversity.AutoSize = true;
            this.lblForUniversity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblForUniversity.Location = new System.Drawing.Point(131, 37);
            this.lblForUniversity.Name = "lblForUniversity";
            this.lblForUniversity.Size = new System.Drawing.Size(101, 16);
            this.lblForUniversity.TabIndex = 3;
            this.lblForUniversity.Text = "lblForUniversity";
            // 
            // lblForNationality
            // 
            this.lblForNationality.AutoSize = true;
            this.lblForNationality.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblForNationality.Location = new System.Drawing.Point(131, 12);
            this.lblForNationality.Name = "lblForNationality";
            this.lblForNationality.Size = new System.Drawing.Size(105, 16);
            this.lblForNationality.TabIndex = 2;
            this.lblForNationality.Text = "lblForNationality";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(43, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 16);
            this.label13.TabIndex = 1;
            this.label13.Text = "University:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(39, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Nationality:";
            // 
            // ReadForeignStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 226);
            this.Name = "ReadForeignStudent";
            this.Text = "Foreign student";
            this.tabControl.ResumeLayout(false);
            this.pageForForeignStudent.ResumeLayout(false);
            this.pageForForeignStudent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.TabPage pageForForeignStudent;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblForUniversity;
        private System.Windows.Forms.Label lblForNationality;
    }
}