namespace UI.Forms.Read
{
    partial class ReadTeacher
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
            this.pageForTeacher = new System.Windows.Forms.TabPage();
            this.lblForPosition = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.pageForTeacher.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.pageForTeacher);
            this.tabControl.Controls.SetChildIndex(this.pageForTeacher, 0);
            this.tabControl.Controls.SetChildIndex(this.pageForPerson, 0);
            this.tabControl.Controls.SetChildIndex(this.pageForUniversity, 0);
            // 
            // pageForTeacher
            // 
            this.pageForTeacher.Controls.Add(this.lblForPosition);
            this.pageForTeacher.Controls.Add(this.label12);
            this.pageForTeacher.Location = new System.Drawing.Point(4, 22);
            this.pageForTeacher.Name = "pageForTeacher";
            this.pageForTeacher.Size = new System.Drawing.Size(376, 147);
            this.pageForTeacher.TabIndex = 3;
            this.pageForTeacher.Text = "Teacher";
            this.pageForTeacher.UseVisualStyleBackColor = true;
            // 
            // lblForPosition
            // 
            this.lblForPosition.AutoSize = true;
            this.lblForPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblForPosition.Location = new System.Drawing.Point(131, 12);
            this.lblForPosition.Name = "lblForPosition";
            this.lblForPosition.Size = new System.Drawing.Size(90, 16);
            this.lblForPosition.TabIndex = 1;
            this.lblForPosition.Text = "lblForPosition";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(54, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Position:";
            // 
            // ReadTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 226);
            this.Name = "ReadTeacher";
            this.Text = "Teacher";
            this.tabControl.ResumeLayout(false);
            this.pageForTeacher.ResumeLayout(false);
            this.pageForTeacher.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.TabPage pageForTeacher;
        private System.Windows.Forms.Label lblForPosition;
        private System.Windows.Forms.Label label12;
    }
}