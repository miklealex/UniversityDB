namespace UI.Forms.CreateEdit
{
    partial class TeacherCreating
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
            this.txtForPosition = new System.Windows.Forms.TextBox();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ok
            // 
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtForPosition);
            this.groupBox7.Location = new System.Drawing.Point(329, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(200, 48);
            this.groupBox7.TabIndex = 21;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Position";
            // 
            // txtForPosition
            // 
            this.txtForPosition.Location = new System.Drawing.Point(6, 19);
            this.txtForPosition.Name = "txtForPosition";
            this.txtForPosition.Size = new System.Drawing.Size(176, 20);
            this.txtForPosition.TabIndex = 22;
            this.txtForPosition.TextChanged += new System.EventHandler(this.txtForPosition_TextChanged);
            // 
            // TeacherCreating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(566, 447);
            this.Controls.Add(this.groupBox7);
            this.Name = "TeacherCreating";
            this.Text = "Create Teacher";
            this.Controls.SetChildIndex(this.Cancel, 0);
            this.Controls.SetChildIndex(this.Ok, 0);
            this.Controls.SetChildIndex(this.groupBox7, 0);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtForPosition;
    }
}
