namespace UI.Forms.Read
{
    partial class ReadPerson
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
            this.pageForPerson = new System.Windows.Forms.TabPage();
            this.lblForGender = new System.Windows.Forms.Label();
            this.lblForBirthday = new System.Windows.Forms.Label();
            this.lblForSurname = new System.Windows.Forms.Label();
            this.lblForName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.pageForPerson.SuspendLayout();
            this.SuspendLayout();
            // 
            // pageForUniversity
            // 
            this.pageForUniversity.Size = new System.Drawing.Size(376, 147);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.pageForPerson);
            this.tabControl.Size = new System.Drawing.Size(384, 173);
            this.tabControl.Controls.SetChildIndex(this.pageForPerson, 0);
            this.tabControl.Controls.SetChildIndex(this.pageForUniversity, 0);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(321, 191);
            // 
            // pageForPerson
            // 
            this.pageForPerson.Controls.Add(this.label7);
            this.pageForPerson.Controls.Add(this.lblForGender);
            this.pageForPerson.Controls.Add(this.lblForBirthday);
            this.pageForPerson.Controls.Add(this.lblForSurname);
            this.pageForPerson.Controls.Add(this.lblForName);
            this.pageForPerson.Controls.Add(this.label9);
            this.pageForPerson.Controls.Add(this.label8);
            this.pageForPerson.Controls.Add(this.label6);
            this.pageForPerson.Location = new System.Drawing.Point(4, 22);
            this.pageForPerson.Name = "pageForPerson";
            this.pageForPerson.Size = new System.Drawing.Size(376, 147);
            this.pageForPerson.TabIndex = 1;
            this.pageForPerson.Text = "Person";
            this.pageForPerson.UseVisualStyleBackColor = true;
            // 
            // lblForGender
            // 
            this.lblForGender.AutoSize = true;
            this.lblForGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblForGender.Location = new System.Drawing.Point(131, 87);
            this.lblForGender.Name = "lblForGender";
            this.lblForGender.Size = new System.Drawing.Size(87, 16);
            this.lblForGender.TabIndex = 9;
            this.lblForGender.Text = "lblForGender";
            // 
            // lblForBirthday
            // 
            this.lblForBirthday.AutoSize = true;
            this.lblForBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblForBirthday.Location = new System.Drawing.Point(131, 62);
            this.lblForBirthday.Name = "lblForBirthday";
            this.lblForBirthday.Size = new System.Drawing.Size(91, 16);
            this.lblForBirthday.TabIndex = 8;
            this.lblForBirthday.Text = "lblForBirthday";
            // 
            // lblForSurname
            // 
            this.lblForSurname.AutoSize = true;
            this.lblForSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblForSurname.Location = new System.Drawing.Point(131, 37);
            this.lblForSurname.Name = "lblForSurname";
            this.lblForSurname.Size = new System.Drawing.Size(96, 16);
            this.lblForSurname.TabIndex = 6;
            this.lblForSurname.Text = "lblForSurname";
            // 
            // lblForName
            // 
            this.lblForName.AutoSize = true;
            this.lblForName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblForName.Location = new System.Drawing.Point(131, 12);
            this.lblForName.Name = "lblForName";
            this.lblForName.Size = new System.Drawing.Size(79, 16);
            this.lblForName.TabIndex = 5;
            this.lblForName.Text = "lblForName";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(57, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Gender:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(53, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Birthday:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(48, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Surname:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(65, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(65, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Name:";
            // 
            // ReadPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 226);
            this.Name = "ReadPerson";
            this.Text = "Person";
            this.tabControl.ResumeLayout(false);
            this.pageForPerson.ResumeLayout(false);
            this.pageForPerson.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.TabPage pageForPerson;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblForName;
        private System.Windows.Forms.Label lblForGender;
        private System.Windows.Forms.Label lblForBirthday;
        private System.Windows.Forms.Label lblForSurname;
        private System.Windows.Forms.Label label7;
    }
}