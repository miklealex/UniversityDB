namespace UI.Forms.CreateEdit
{
    partial class CreateEditPerson
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
            this.radioForGender_Female = new System.Windows.Forms.RadioButton();
            this.radioForGender_Male = new System.Windows.Forms.RadioButton();
            this.datePickerForBirthday = new System.Windows.Forms.DateTimePicker();
            this.txtForSurname = new System.Windows.Forms.TextBox();
            this.txtForName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.pageForPerson.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.pageForPerson);
            this.tabControl.Size = new System.Drawing.Size(402, 170);
            this.tabControl.Controls.SetChildIndex(this.pageForPerson, 0);
            this.tabControl.Controls.SetChildIndex(this.pageForUniversity, 0);
            // 
            // pageForUniversity
            // 
            this.pageForUniversity.Size = new System.Drawing.Size(394, 144);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(339, 200);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(258, 200);
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click_1);
            // 
            // pageForPerson
            // 
            this.pageForPerson.Controls.Add(this.radioForGender_Female);
            this.pageForPerson.Controls.Add(this.radioForGender_Male);
            this.pageForPerson.Controls.Add(this.datePickerForBirthday);
            this.pageForPerson.Controls.Add(this.txtForSurname);
            this.pageForPerson.Controls.Add(this.txtForName);
            this.pageForPerson.Controls.Add(this.label9);
            this.pageForPerson.Controls.Add(this.label8);
            this.pageForPerson.Controls.Add(this.label6);
            this.pageForPerson.Controls.Add(this.label5);
            this.pageForPerson.Location = new System.Drawing.Point(4, 22);
            this.pageForPerson.Name = "pageForPerson";
            this.pageForPerson.Size = new System.Drawing.Size(394, 144);
            this.pageForPerson.TabIndex = 1;
            this.pageForPerson.Text = "Person";
            this.pageForPerson.UseVisualStyleBackColor = true;
            // 
            // radioForGender_Female
            // 
            this.radioForGender_Female.AutoSize = true;
            this.radioForGender_Female.Location = new System.Drawing.Point(190, 87);
            this.radioForGender_Female.Name = "radioForGender_Female";
            this.radioForGender_Female.Size = new System.Drawing.Size(59, 17);
            this.radioForGender_Female.TabIndex = 15;
            this.radioForGender_Female.Text = "Female";
            this.radioForGender_Female.UseVisualStyleBackColor = true;
            // 
            // radioForGender_Male
            // 
            this.radioForGender_Male.AutoSize = true;
            this.radioForGender_Male.Checked = true;
            this.radioForGender_Male.Location = new System.Drawing.Point(136, 87);
            this.radioForGender_Male.Name = "radioForGender_Male";
            this.radioForGender_Male.Size = new System.Drawing.Size(48, 17);
            this.radioForGender_Male.TabIndex = 14;
            this.radioForGender_Male.TabStop = true;
            this.radioForGender_Male.Text = "Male";
            this.radioForGender_Male.UseVisualStyleBackColor = true;
            // 
            // datePickerForBirthday
            // 
            this.datePickerForBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerForBirthday.Location = new System.Drawing.Point(136, 58);
            this.datePickerForBirthday.Name = "datePickerForBirthday";
            this.datePickerForBirthday.Size = new System.Drawing.Size(197, 20);
            this.datePickerForBirthday.TabIndex = 13;
            this.datePickerForBirthday.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // txtForSurname
            // 
            this.txtForSurname.Location = new System.Drawing.Point(136, 33);
            this.txtForSurname.Name = "txtForSurname";
            this.txtForSurname.Size = new System.Drawing.Size(197, 20);
            this.txtForSurname.TabIndex = 11;
            // 
            // txtForName
            // 
            this.txtForName.Location = new System.Drawing.Point(136, 8);
            this.txtForName.Name = "txtForName";
            this.txtForName.Size = new System.Drawing.Size(197, 20);
            this.txtForName.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(74, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Gender:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(70, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Birthday:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(65, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Surname:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(82, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Name:";
            // 
            // CreateEditPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 235);
            this.Name = "CreateEditPerson";
            this.Text = "CreateEditPerson";
            this.tabControl.ResumeLayout(false);
            this.pageForPerson.ResumeLayout(false);
            this.pageForPerson.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage pageForPerson;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        protected System.Windows.Forms.TextBox txtForName;
        protected System.Windows.Forms.RadioButton radioForGender_Male;
        protected System.Windows.Forms.DateTimePicker datePickerForBirthday;
        protected System.Windows.Forms.TextBox txtForSurname;
        protected System.Windows.Forms.RadioButton radioForGender_Female;
    }
}