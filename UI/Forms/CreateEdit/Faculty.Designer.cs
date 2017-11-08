namespace UI.Forms.CreateEdit
{
    partial class Faculty
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tBFacultyName = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ok
            // 
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tBFacultyName);
            this.groupBox2.Location = new System.Drawing.Point(13, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 56);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Faculty name";
            // 
            // tBFacultyName
            // 
            this.tBFacultyName.Location = new System.Drawing.Point(7, 20);
            this.tBFacultyName.Name = "tBFacultyName";
            this.tBFacultyName.Size = new System.Drawing.Size(173, 20);
            this.tBFacultyName.TabIndex = 0;
            this.tBFacultyName.TextChanged += new System.EventHandler(this.tBFacultyName_TextChanged);
            // 
            // Faculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(318, 135);
            this.Controls.Add(this.groupBox2);
            this.Name = "Faculty";
            this.Text = "FacultyCreating";
            this.Controls.SetChildIndex(this.Cancel, 0);
            this.Controls.SetChildIndex(this.Ok, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tBFacultyName;
    }
}
