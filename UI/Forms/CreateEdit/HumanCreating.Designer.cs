namespace UI.Forms.CreateEdit
{
    partial class HumanCreating
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.datePickerForBirthday = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.NameText = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Surname = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ok
            // 
            this.Ok.Click += new System.EventHandler(this.Ok_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.datePickerForBirthday);
            this.groupBox2.Location = new System.Drawing.Point(12, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 49);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Day of birth";
            // 
            // datePickerForBirthday
            // 
            this.datePickerForBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerForBirthday.Location = new System.Drawing.Point(7, 19);
            this.datePickerForBirthday.Name = "datePickerForBirthday";
            this.datePickerForBirthday.Size = new System.Drawing.Size(174, 20);
            this.datePickerForBirthday.TabIndex = 14;
            this.datePickerForBirthday.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.datePickerForBirthday.ValueChanged += new System.EventHandler(this.datePickerForBirthday_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.NameText);
            this.groupBox3.Location = new System.Drawing.Point(12, 75);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 49);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Name";
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(7, 20);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(174, 20);
            this.NameText.TabIndex = 0;
            this.NameText.TextChanged += new System.EventHandler(this.Name_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Surname);
            this.groupBox4.Location = new System.Drawing.Point(12, 135);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 49);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Surname";
            // 
            // Surname
            // 
            this.Surname.Location = new System.Drawing.Point(7, 20);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(174, 20);
            this.Surname.TabIndex = 0;
            this.Surname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(19, 261);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(49, 17);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Male";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(89, 261);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(60, 17);
            this.checkBox2.TabIndex = 18;
            this.checkBox2.Text = "Female";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // HumanCreating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(318, 299);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "HumanCreating";
            this.Text = "HumanCreating";
            this.Controls.SetChildIndex(this.Cancel, 0);
            this.Controls.SetChildIndex(this.Ok, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.groupBox4, 0);
            this.Controls.SetChildIndex(this.checkBox1, 0);
            this.Controls.SetChildIndex(this.checkBox2, 0);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        protected System.Windows.Forms.DateTimePicker datePickerForBirthday;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}
