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
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
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
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.linkLabel1);
            this.groupBox7.Location = new System.Drawing.Point(13, 404);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(177, 58);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Dean";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(48, 26);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 13);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FacultyRead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(432, 474);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Name = "FacultyRead";
            this.Controls.SetChildIndex(this.groupBox6, 0);
            this.Controls.SetChildIndex(this.groupBox7, 0);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label FacNamelb;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
