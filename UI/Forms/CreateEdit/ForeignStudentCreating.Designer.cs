namespace UI.Forms.CreateEdit
{
    partial class ForeignStudentCreating
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
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtForNationality = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtForUniversity = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownForCourse)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ok
            // 
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtForNationality);
            this.groupBox7.Location = new System.Drawing.Point(337, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(186, 49);
            this.groupBox7.TabIndex = 22;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Nationality";
            // 
            // txtForNationality
            // 
            this.txtForNationality.Location = new System.Drawing.Point(6, 20);
            this.txtForNationality.Name = "txtForNationality";
            this.txtForNationality.Size = new System.Drawing.Size(163, 20);
            this.txtForNationality.TabIndex = 23;
            this.txtForNationality.TextChanged += new System.EventHandler(this.txtForNationality_TextChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtForUniversity);
            this.groupBox8.Location = new System.Drawing.Point(337, 72);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(186, 49);
            this.groupBox8.TabIndex = 23;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Changed University";
            // 
            // txtForUniversity
            // 
            this.txtForUniversity.Location = new System.Drawing.Point(6, 19);
            this.txtForUniversity.Name = "txtForUniversity";
            this.txtForUniversity.Size = new System.Drawing.Size(163, 20);
            this.txtForUniversity.TabIndex = 24;
            this.txtForUniversity.TextChanged += new System.EventHandler(this.txtForUniversity_TextChanged);
            // 
            // ForeignStudentCreating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(560, 449);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Name = "ForeignStudentCreating";
            this.Text = "Create Foreign Student";
            this.Controls.SetChildIndex(this.Cancel, 0);
            this.Controls.SetChildIndex(this.Ok, 0);
            this.Controls.SetChildIndex(this.groupBox7, 0);
            this.Controls.SetChildIndex(this.groupBox8, 0);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownForCourse)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox7;
        protected System.Windows.Forms.TextBox txtForNationality;
        private System.Windows.Forms.GroupBox groupBox8;
        protected System.Windows.Forms.TextBox txtForUniversity;
    }
}
