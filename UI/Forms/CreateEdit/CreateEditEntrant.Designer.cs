namespace UI.Forms.CreateEdit
{
    partial class CreateEditEntrant
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
            this.txtForGPA = new System.Windows.Forms.TextBox();
            this.txtForIEE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.pageForUniversity.SuspendLayout();
            this.pageForEntrant.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.pageForEntrant);
            this.tabControl.Controls.SetChildIndex(this.pageForEntrant, 0);
            this.tabControl.Controls.SetChildIndex(this.pageForUniversity, 0);
            // 
            // pageForEntrant
            // 
            this.pageForEntrant.Controls.Add(this.txtForGPA);
            this.pageForEntrant.Controls.Add(this.txtForIEE);
            this.pageForEntrant.Controls.Add(this.label1);
            this.pageForEntrant.Controls.Add(this.label3);
            this.pageForEntrant.Location = new System.Drawing.Point(4, 22);
            this.pageForEntrant.Name = "pageForEntrant";
            this.pageForEntrant.Size = new System.Drawing.Size(394, 144);
            this.pageForEntrant.TabIndex = 2;
            this.pageForEntrant.Text = "Entrant";
            this.pageForEntrant.UseVisualStyleBackColor = true;
            // 
            // txtForGPA
            // 
            this.txtForGPA.Location = new System.Drawing.Point(136, 33);
            this.txtForGPA.Name = "txtForGPA";
            this.txtForGPA.Size = new System.Drawing.Size(197, 20);
            this.txtForGPA.TabIndex = 15;
            // 
            // txtForIEE
            // 
            this.txtForIEE.Location = new System.Drawing.Point(136, 8);
            this.txtForIEE.Name = "txtForIEE";
            this.txtForIEE.Size = new System.Drawing.Size(197, 20);
            this.txtForIEE.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(91, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "GPA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(98, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "IEE:";
            // 
            // CreateEditEntrant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 235);
            this.Name = "CreateEditEntrant";
            this.Text = "CreateEditEntrant";
            this.tabControl.ResumeLayout(false);
            this.pageForUniversity.ResumeLayout(false);
            this.pageForUniversity.PerformLayout();
            this.pageForEntrant.ResumeLayout(false);
            this.pageForEntrant.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage pageForEntrant;
        protected System.Windows.Forms.TextBox txtForGPA;
        protected System.Windows.Forms.TextBox txtForIEE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}