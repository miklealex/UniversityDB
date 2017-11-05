namespace UI.Forms.CreateEdit
{
    partial class EntrantCreating
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtForIEE = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtForGPA = new System.Windows.Forms.TextBox();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ok
            // 
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtForIEE);
            this.groupBox5.Location = new System.Drawing.Point(19, 295);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(193, 52);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "IEE";
            // 
            // txtForIEE
            // 
            this.txtForIEE.Location = new System.Drawing.Point(6, 19);
            this.txtForIEE.Name = "txtForIEE";
            this.txtForIEE.Size = new System.Drawing.Size(168, 20);
            this.txtForIEE.TabIndex = 20;
            this.txtForIEE.TextChanged += new System.EventHandler(this.txtForIEE_TextChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtForGPA);
            this.groupBox6.Location = new System.Drawing.Point(25, 367);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(187, 56);
            this.groupBox6.TabIndex = 20;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "GPA";
            // 
            // txtForGPA
            // 
            this.txtForGPA.Location = new System.Drawing.Point(6, 19);
            this.txtForGPA.Name = "txtForGPA";
            this.txtForGPA.Size = new System.Drawing.Size(162, 20);
            this.txtForGPA.TabIndex = 21;
            this.txtForGPA.TextChanged += new System.EventHandler(this.txtForGPA_TextChanged);
            // 
            // EntrantCreating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(318, 435);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Name = "EntrantCreating";
            this.Text = "Entrant Creating";
            this.Controls.SetChildIndex(this.Cancel, 0);
            this.Controls.SetChildIndex(this.Ok, 0);
            this.Controls.SetChildIndex(this.groupBox5, 0);
            this.Controls.SetChildIndex(this.groupBox6, 0);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        protected System.Windows.Forms.TextBox txtForIEE;
        private System.Windows.Forms.GroupBox groupBox6;
        protected System.Windows.Forms.TextBox txtForGPA;
    }
}
