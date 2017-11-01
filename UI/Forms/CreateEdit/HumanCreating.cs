using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Database.ClassHierarhy;

namespace UI.Forms.CreateEdit
{
    public partial class HumanCreating : UI.Forms.CreateEdit.UniversityCreating
    {

        public new Person Value;

        public HumanCreating()
        {
            InitializeComponent();
        }

        public HumanCreating(Person person) : base(person)
        {
            InitializeComponent();

            Value = person;
            ShowInfo();

            AddEvents();
            Text = "Edit Person";
            Ok.Enabled = true;
        }

        private void Name_TextChanged(object sender, EventArgs e)
        {
            Ok.Enabled = this.Verify();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Ok.Enabled = this.Verify();
        }

        private void datePickerForBirthday_ValueChanged(object sender, EventArgs e)
        {
            Ok.Enabled = this.Verify();
        }

        private void Ok_Click_1(object sender, EventArgs e)
        {
            if (Value == null)
            {
                Value = new Person();
            }

            FillObject(Value);
            this.DialogResult = DialogResult.OK;
            Close();
        }

        protected override void ChangeEvents(EventHandler eventHandlerForValidation, EventHandler eventHandlerForBtnOkClick)
        {
            datePickerForBirthday.ValueChanged -= datePickerForBirthday_ValueChanged;
            NameText.TextChanged -= Name_TextChanged;
            Surname.TextChanged -= textBox1_TextChanged;

            datePickerForBirthday.ValueChanged += eventHandlerForValidation;
            NameText.TextChanged += eventHandlerForValidation;
            Surname.TextChanged += eventHandlerForValidation;

            Ok.Click -= Ok_Click_1;

            base.ChangeEvents(eventHandlerForValidation, eventHandlerForBtnOkClick);
        }

        private void AddEvents()
        {
            //base.ChangeEvents(SomethingChanged, Ok_Click);

            // Person
            datePickerForBirthday.ValueChanged += datePickerForBirthday_ValueChanged;
            NameText.TextChanged += Name_TextChanged;
            Surname.TextChanged += textBox1_TextChanged;
        }

        protected void FillObject(Person person)
        {
            base.FillObject(person);

            person.Name = NameText.Text;
            person.Surname = Surname.Text;
            person.Birthday = datePickerForBirthday.Value;
            person.Gender = checkBox1.Checked;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked)
            checkBox2.Checked = false;
            Ok.Enabled = this.Verify();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            checkBox1.Checked = false;
            Ok.Enabled = this.Verify();
        }

        protected override bool Verify()
        {
            return NameText.Text.Length > 0 &&
                Surname.Text.Length > 0 &&
                (checkBox1.Checked || checkBox2.Checked) &&
                base.Verify();
        }

        private void ShowInfo()
        {
            NameText.Text = Value.Name;
            Surname.Text = Value.Surname;
            datePickerForBirthday.Value = Value.Birthday;
            checkBox2.Checked = !(checkBox1.Checked = Value.Gender);
        }


    }
}
