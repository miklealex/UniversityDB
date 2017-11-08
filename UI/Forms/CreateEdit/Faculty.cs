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
    public partial class Faculty : UI.Forms.CreateEdit.UniversityCreating
    {
         public new Database.ClassHierarhy.Faculty Value;

        public Faculty()
        {
            InitializeComponent();
        }

        public Faculty(Database.ClassHierarhy.Faculty person) : base(person)
        {
            InitializeComponent();

            Value = person;
            ShowInfo();

            AddEvents();
            Text = "Edit Person";
            Ok.Enabled = true;
        }

        protected override void ChangeEvents(EventHandler eventHandlerForValidation, EventHandler eventHandlerForBtnOkClick)
        {
            tBFacultyName.TextChanged += eventHandlerForValidation;

            Ok.Click -= Ok_Click;

            base.ChangeEvents(eventHandlerForValidation, eventHandlerForBtnOkClick);
        }

        private void AddEvents()
        {
            //base.ChangeEvents(SomethingChanged, Ok_Click);

            // Person
            tBFacultyName.TextChanged += tBFacultyName_TextChanged;

        }

        protected void FillObject(Database.ClassHierarhy.Faculty fac)
        {
            base.FillObject(fac);

            fac.FacultyName = tBFacultyName.Text;
        }

        protected override bool Verify()
        {
            return  tBFacultyName != null && tBFacultyName.Text.Length > 0 && base.Verify();
        }

        private void ShowInfo()
        {
            tBFacultyName.Text = Value.FacultyName;
        }

        private void tBFacultyName_TextChanged(object sender, EventArgs e)
        {
            Ok.Enabled = Verify();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            if (Value == null)
            {
                Value = new Database.ClassHierarhy.Faculty();
            }

            FillObject(Value);
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
