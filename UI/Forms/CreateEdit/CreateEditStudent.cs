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
    public partial class CreateEditStudent : UI.Forms.CreateEdit.CreateEditPerson
    {
        public new Student Value;

        public CreateEditStudent() : base()
        {
            InitializeComponent();
            AddEvents();

            Text = "Create Student";
        }

        public CreateEditStudent(Student student) : base(student)
        {
            InitializeComponent();

            Value = student;
            ShowInfo();

            AddEvents();
            Text = "Edit Student";
            btnOk.Enabled = true;
        }

        private void AddEvents()
        {
            base.ChangeEvents(SomethingChanged, btnOk_Click);
        }

        protected override void ChangeEvents(EventHandler eventHandlerForValidation, EventHandler eventHandlerForBtnOkClick)
        {
            btnOk.Click -= btnOk_Click;

            base.ChangeEvents(eventHandlerForValidation, eventHandlerForBtnOkClick);
        }

        private void SomethingChanged(object sender, EventArgs e)
        {
            btnOk.Enabled = Verify();
        }

        protected override bool Verify()
        {
            return base.Verify();
        }

        private void btnOk_Click(object sender, EventArgs e)
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

        protected void FillObject(Student student)
        {
            base.FillObject(student);

            student.EntryDate = datePickerForEntryDate.Value;
            student.Course = Convert.ToInt32(numericUpDownForCourse.Value);
        }
    }
}
