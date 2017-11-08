namespace UI.Forms.Read
{
    partial class FacultyRead
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
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.FacNamelb = new System.Windows.Forms.Label();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.FacNamelb);
            this.groupBox6.Location = new System.Drawing.Point(13, 324);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(177, 62);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Faculty name";
            // 
            // FacNamelb
            // 
            this.FacNamelb.AutoSize = true;
            this.FacNamelb.Location = new System.Drawing.Point(66, 27);
            this.FacNamelb.Name = "FacNamelb";
            this.FacNamelb.Size = new System.Drawing.Size(35, 13);
            this.FacNamelb.TabIndex = 0;
            this.FacNamelb.Text = "label1";
            // 
            // FacultyRead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(303, 413);
            this.Controls.Add(this.groupBox6);
            this.Name = "FacultyRead";
            this.Controls.SetChildIndex(this.groupBox6, 0);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label FacNamelb;
    }
}
