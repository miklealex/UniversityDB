namespace UI.Forms.Read
{
    partial class University
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblForTitle = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblForId = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.linkLblForMajor = new System.Windows.Forms.LinkLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblForCreationTime = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblForLastWriteTime = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblForTitle);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 56);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Title";
            // 
            // lblForTitle
            // 
            this.lblForTitle.AutoSize = true;
            this.lblForTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblForTitle.Location = new System.Drawing.Point(49, 26);
            this.lblForTitle.Name = "lblForTitle";
            this.lblForTitle.Size = new System.Drawing.Size(68, 16);
            this.lblForTitle.TabIndex = 10;
            this.lblForTitle.Text = "lblForTitle";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblForId);
            this.groupBox2.Location = new System.Drawing.Point(12, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 56);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ID";
            // 
            // lblForId
            // 
            this.lblForId.AutoSize = true;
            this.lblForId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblForId.Location = new System.Drawing.Point(49, 25);
            this.lblForId.Name = "lblForId";
            this.lblForId.Size = new System.Drawing.Size(53, 16);
            this.lblForId.TabIndex = 11;
            this.lblForId.Text = "lblForId";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.linkLblForMajor);
            this.groupBox3.Location = new System.Drawing.Point(12, 136);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(178, 56);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Parent";
            // 
            // linkLblForMajor
            // 
            this.linkLblForMajor.AutoSize = true;
            this.linkLblForMajor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLblForMajor.Location = new System.Drawing.Point(28, 26);
            this.linkLblForMajor.Name = "linkLblForMajor";
            this.linkLblForMajor.Size = new System.Drawing.Size(100, 16);
            this.linkLblForMajor.TabIndex = 14;
            this.linkLblForMajor.TabStop = true;
            this.linkLblForMajor.Text = "linkLblForMajor";
            this.linkLblForMajor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblForMajor_LinkClicked_1);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblForCreationTime);
            this.groupBox4.Location = new System.Drawing.Point(12, 198);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(178, 56);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "creation time";
            // 
            // lblForCreationTime
            // 
            this.lblForCreationTime.AutoSize = true;
            this.lblForCreationTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblForCreationTime.Location = new System.Drawing.Point(16, 26);
            this.lblForCreationTime.Name = "lblForCreationTime";
            this.lblForCreationTime.Size = new System.Drawing.Size(123, 16);
            this.lblForCreationTime.TabIndex = 12;
            this.lblForCreationTime.Text = "lblForCreationTime";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblForLastWriteTime);
            this.groupBox5.Location = new System.Drawing.Point(12, 260);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(178, 57);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "last modified";
            // 
            // lblForLastWriteTime
            // 
            this.lblForLastWriteTime.AutoSize = true;
            this.lblForLastWriteTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblForLastWriteTime.Location = new System.Drawing.Point(16, 25);
            this.lblForLastWriteTime.Name = "lblForLastWriteTime";
            this.lblForLastWriteTime.Size = new System.Drawing.Size(129, 16);
            this.lblForLastWriteTime.TabIndex = 13;
            this.lblForLastWriteTime.Text = "lblForLastWriteTime";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(216, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // University
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 336);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Name = "University";
            this.Text = "University ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblForTitle;
        private System.Windows.Forms.Label lblForId;
        private System.Windows.Forms.LinkLabel linkLblForMajor;
        private System.Windows.Forms.Label lblForLastWriteTime;
        private System.Windows.Forms.Label lblForCreationTime;
        private System.Windows.Forms.Button button1;
    }
}