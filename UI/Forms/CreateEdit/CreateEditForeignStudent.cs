using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Database.Entities;

namespace UI.Forms.CreateEdit
{
    public partial class CreateEditForeignStudent : UI.Forms.CreateEdit.CreateEditStudent
    {
        public new ForeignStudent Value;

        public CreateEditForeignStudent() : base()
        {
            InitializeComponent();
            AddEvents();

            Text = "Create Foreign Student";
        }

        public CreateEditForeignStudent(ForeignStudent foreignStudent) : base(foreignStudent)
        {
            InitializeComponent();

            Value = foreignStudent;
            ShowInfo();

            AddEvents();
            Text = "Edit Foreign Student";
            btnOk.Enabled = true;
        }

        private void AddEvents()
        {
            base.ChangeEvents(SomethingChanged, btnOk_Click);

            // ForeignStudent
            txtForNationality.TextChanged += SomethingChanged;
            txtForUniversity.TextChanged += SomethingChanged;
        }

        protected override void ChangeEvents(EventHandler eventHandlerForValidation, EventHandler eventHandlerForBtnOkClick)
        {
            txtForNationality.TextChanged -= SomethingChanged;
            txtForUniversity.TextChanged -= SomethingChanged;

            txtForNationality.TextChanged += eventHandlerForValidation;
            txtForUniversity.TextChanged += eventHandlerForValidation;

            btnOk.Click -= btnOk_Click;

            base.ChangeEvents(eventHandlerForValidation, eventHandlerForBtnOkClick);
        }
        private void SomethingChanged(object sender, EventArgs e)
        {
            btnOk.Enabled = Verify();
        }

        protected override bool Verify()
        {
            return txtForNationality.Text.Length > 0 &&
                txtForUniversity.Text.Length > 0 &&
                 base.Verify();
        }

        private void btnOk_Click(object sender, EventArgs e)
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
    }
}
