namespace UI.Forms.CreateEdit
{
    partial class CreateEditTeacher
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtForPosition = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.pageForUniversity.SuspendLayout();
            this.pageForTeacher.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.pageForTeacher);
            this.tabControl.Controls.SetChildIndex(this.pageForTeacher, 0);
            this.tabControl.Controls.SetChildIndex(this.pageForUniversity, 0);
            // 
            // pageForTeacher
            // 
            this.pageForTeacher.Controls.Add(this.txtForPosition);
            this.pageForTeacher.Controls.Add(this.label4);
            this.pageForTeacher.Location = new System.Drawing.Point(4, 22);
            this.pageForTeacher.Name = "pageForTeacher";
            this.pageForTeacher.Size = new System.Drawing.Size(394, 144);
            this.pageForTeacher.TabIndex = 3;
            this.pageForTeacher.Text = "Teacher";
            this.pageForTeacher.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(71, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Position:";
            // 
            // txtForPosition
            // 
            this.txtForPosition.Location = new System.Drawing.Point(136, 8);
            this.txtForPosition.Name = "txtForPosition";
            this.txtForPosition.Size = new System.Drawing.Size(197, 20);
            this.txtForPosition.TabIndex = 1;
            // 
            // CreateEditTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 235);
            this.Name = "CreateEditTeacher";
            this.Text = "CreateEditTeacher";
            this.tabControl.ResumeLayout(false);
            this.pageForUniversity.ResumeLayout(false);
            this.pageForUniversity.PerformLayout();
            this.pageForTeacher.ResumeLayout(false);
            this.pageForTeacher.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage pageForTeacher;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtForPosition;
    }
}