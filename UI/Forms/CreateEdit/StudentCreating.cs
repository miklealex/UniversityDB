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
    public partial class StudentCreating : UI.Forms.CreateEdit.HumanCreating
    {

        public new Student Value;

        public StudentCreating() : base()
        {
            InitializeComponent();
            AddEvents();

            Text = "Create Student";
        }

        private void AddEvents()
        {
            base.ChangeEvents(numericUpDownForCourse_ValueChanged, Ok_Click);
            base.ChangeEvents(datePickerForEntryDate_ValueChanged, Ok_Click);
        }

        protected override void ChangeEvents(EventHandler eventHandlerForValidation, EventHandler eventHandlerForBtnOkClick)
        {
            Ok.Click -= Ok_Click;

            base.ChangeEvents(eventHandlerForValidation, eventHandlerForBtnOkClick);
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            if (Value == null)
            {
                Value = new Student();
            }

            FillObject(Value);

            Close();
        }

        private void ShowInfo()
        {
            numericUpDownForCourse.Value = Value.Course;
            datePickerForEntryDate.Value = Value.EntryDate;
        }

        protected override bool Verify()
        {
            return  base.Verify();
        }

        public StudentCreating(Student student) : base(student)
        {
            InitializeComponent();

            Value = student;
            ShowInfo();

            AddEvents();
            Text = "Edit Student";
            Ok.Enabled = true;
        }

        protected void FillObject(Student student)
        {
            base.FillObject(student);

            student.EntryDate = datePickerForEntryDate.Value;
            student.Course = Convert.ToInt32(numericUpDownForCourse.Value);
        }

        private void numericUpDownForCourse_ValueChanged(object sender, EventArgs e)
        {
            Ok.Enabled = Verify();
        }

        private void datePickerForEntryDate_ValueChanged(object sender, EventArgs e)
        {
            Ok.Enabled = Verify();
        }
    }
}
