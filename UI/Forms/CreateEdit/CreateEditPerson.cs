using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Database.ClassHierarhy;

namespace UI.Forms.CreateEdit
{
    public partial class CreateEditPerson : UI.Forms.CreateEdit.CreateEditUniversity
    {
        public new Person Value;

        public CreateEditPerson() : base()
        {
            InitializeComponent();
            AddEvents();

            Text = "Create Person";
        }

        public CreateEditPerson(Person person) : base(person)
        {
            InitializeComponent();

            Value = person;
            ShowInfo();

            AddEvents();
            Text = "Edit Person";
            btnOk.Enabled = true;
        }

        private void AddEvents()
        {
            base.ChangeEvents(SomethingChanged, btnOk_Click);

            // Person
            datePickerForBirthday.ValueChanged += SomethingChanged;
            txtForName.TextChanged += SomethingChanged;
            txtForSurname.TextChanged += SomethingChanged;
        }

        protected override void ChangeEvents(EventHandler eventHandlerForValidation, EventHandler eventHandlerForBtnOkClick)
        {
            datePickerForBirthday.ValueChanged -= SomethingChanged;
            txtForName.TextChanged -= SomethingChanged;
            txtForSurname.TextChanged -= SomethingChanged;

            datePickerForBirthday.ValueChanged += eventHandlerForValidation;
            txtForName.TextChanged += eventHandlerForValidation;
            txtForSurname.TextChanged += eventHandlerForValidation;

            btnOk.Click -= btnOk_Click;

            base.ChangeEvents(eventHandlerForValidation, eventHandlerForBtnOkClick);
        }

        private void SomethingChanged(object sender, EventArgs e)
        {
            btnOk.Enabled = this.Verify();
        }

        protected override bool Verify()
        {
            return txtForName.Text.Length > 0 &&
                txtForSurname.Text.Length > 0 &&
                base.Verify();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (Value == null)
            {
                Value = new Person();
            }

            FillObject(Value);

            Close();
        }

        private void ShowInfo()
        {
            txtForName.Text = Value.Name;
            txtForSurname.Text = Value.Surname;
            datePickerForBirthday.Value = Value.Birthday;
            radioForGender_Female.Checked = !(radioForGender_Male.Checked = Value.Gender);
        }

        protected void FillObject(Person person)
        {
            base.FillObject(person);

            person.Name = txtForName.Text;
            person.Surname = txtForSurname.Text;
            person.Birthday = datePickerForBirthday.Value;
            person.Gender = radioForGender_Male.Checked;
        }
    }
}
