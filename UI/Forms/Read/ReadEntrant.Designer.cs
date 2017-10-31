namespace UI.Forms.Read
{
    partial class ReadEntrant
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
            this.pageForEntrant = new System.Windows.Forms.TabPage();
            this.lblForGPA = new System.Windows.Forms.Label();
            this.lblForIEE = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.pageForEntrant.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.pageForEntrant);
            this.tabControl.Controls.SetChildIndex(this.pageForEntrant, 0);
            this.tabControl.Controls.SetChildIndex(this.pageForPerson, 0);
            this.tabControl.Controls.SetChildIndex(this.pageForUniversity, 0);
            // 
            // pageForEntrant
            // 
            this.pageForEntrant.Controls.Add(this.lblForGPA);
            this.pageForEntrant.Controls.Add(this.lblForIEE);
            this.pageForEntrant.Controls.Add(this.label11);
            this.pageForEntrant.Controls.Add(this.label18);
            this.pageForEntrant.Location = new System.Drawing.Point(4, 22);
            this.pageForEntrant.Name = "pageForEntrant";
            this.pageForEntrant.Size = new System.Drawing.Size(376, 147);
            this.pageForEntrant.TabIndex = 2;
            this.pageForEntrant.Text = "Entrant";
            this.pageForEntrant.UseVisualStyleBackColor = true;
            // 
            // lblForGPA
            // 
            this.lblForGPA.AutoSize = true;
            this.lblForGPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblForGPA.Location = new System.Drawing.Point(131, 37);
            this.lblForGPA.Name = "lblForGPA";
            this.lblForGPA.Size = new System.Drawing.Size(70, 16);
            this.lblForGPA.TabIndex = 3;
            this.lblForGPA.Text = "lblForGPA";
            // 
            // lblForIEE
            // 
            this.lblForIEE.AutoSize = true;
            this.lblForIEE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblForIEE.Location = new System.Drawing.Point(131, 12);
            this.lblForIEE.Name = "lblForIEE";
            this.lblForIEE.Size = new System.Drawing.Size(63, 16);
            this.lblForIEE.TabIndex = 2;
            this.lblForIEE.Text = "lblForIEE";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(74, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "GPA:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(81, 12);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(32, 16);
            this.label18.TabIndex = 0;
            this.label18.Text = "IEE:";
            // 
            // ReadEntrant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 226);
            this.Name = "ReadEntrant";
            this.Text = "Entrant";
            this.tabControl.ResumeLayout(false);
            this.pageForEntrant.ResumeLayout(false);
            this.pageForEntrant.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.TabPage pageForEntrant;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblForGPA;
        private System.Windows.Forms.Label lblForIEE;
    }
}