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
    public partial class ForeignStudentCreating : UI.Forms.CreateEdit.StudentCreating
    {
        public new ForeignStudent Value;

        public ForeignStudentCreating() : base()
        {
            InitializeComponent();
            AddEvents();

            Text = "Create Foreign Student";
        }

        public ForeignStudentCreating(ForeignStudent foreignStudent) : base(foreignStudent)
        {
            InitializeComponent();

            Value = foreignStudent;
            ShowInfo();

            AddEvents();
            Text = "Edit Foreign Student";
            Ok.Enabled = true;
        }

        private void AddEvents()
        {
            base.ChangeEvents(txtForNationality_TextChanged, Ok_Click);
            base.ChangeEvents(txtForUniversity_TextChanged, Ok_Click);
            // ForeignStudent
            txtForNationality.TextChanged += txtForNationality_TextChanged;
            txtForUniversity.TextChanged += txtForUniversity_TextChanged;
        }

        protected override bool Verify()
        {
            return txtForNationality.Text.Length > 0 &&
                txtForUniversity.Text.Length > 0 &&
                 base.Verify();
        }

        protected override void ChangeEvents(EventHandler eventHandlerForValidation, EventHandler eventHandlerForBtnOkClick)
        {
            txtForNationality.TextChanged -= txtForNationality_TextChanged;
            txtForUniversity.TextChanged -= txtForUniversity_TextChanged;

            txtForNationality.TextChanged += eventHandlerForValidation;
            txtForUniversity.TextChanged += eventHandlerForValidation;

            Ok.Click -= Ok_Click;

            base.ChangeEvents(eventHandlerForValidation, eventHandlerForBtnOkClick);
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            if (Value == null)
            {
                Value = new ForeignStudent();
            }

            FillObject(Value);

            Close();
        }

        private void ShowInfo()
        {
            txtForNationality.Text = Value.Nationality;
            txtForUniversity.Text = Value.University;
        }

        protected void FillObject(ForeignStudent foreignStudent)
        {
            base.FillObject(foreignStudent);

            foreignStudent.Nationality = txtForNationality.Text;
            foreignStudent.University = txtForUniversity.Text;
        }

        private void txtForNationality_TextChanged(object sender, EventArgs e)
        {
            Ok.Enabled = Verify();
        }

        private void txtForUniversity_TextChanged(object sender, EventArgs e)
        {
            Ok.Enabled = Verify();
        }
    }
}
