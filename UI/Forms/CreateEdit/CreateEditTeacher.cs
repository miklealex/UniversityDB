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
    public partial class CreateEditTeacher : UI.Forms.CreateEdit.CreateEditWorker
    {
        public new Teacher Value;

        public CreateEditTeacher() : base()
        {
            InitializeComponent();
            AddEvents();

            Text = "Create Teacher";
        }

        public CreateEditTeacher(Teacher teacher) : base(teacher)
        {
            InitializeComponent();

            Value = teacher;
            ShowInfo();

            AddEvents();
            Text = "Edit Teacher";
            btnOk.Enabled = true;
        }

        private void AddEvents()
        {
            base.ChangeEvents(SomethingChanged, btnOk_Click);

            // Teacher
            txtForPosition.TextChanged += SomethingChanged;
        }


        protected override void ChangeEvents(EventHandler eventHandlerForValidation, EventHandler eventHandlerForBtnOkClick)
        {
            txtForPosition.TextChanged -= SomethingChanged;
            txtForPosition.TextChanged += eventHandlerForValidation;

            btnOk.Click -= btnOk_Click;

            base.ChangeEvents(eventHandlerForValidation, eventHandlerForBtnOkClick);
        }

        private void SomethingChanged(object sender, EventArgs e)
        {
            btnOk.Enabled = Verify();
        }

        protected override bool Verify()
        {
            return txtForPosition.Text.Length > 0 &&
                base.Verify();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (Value == null)
            {
                Value = new Teacher();
            }

            FillObject(Value);

            Close();
        }

        private void ShowInfo()
        {
            txtForPosition.Text = Value.Position;
        }

        protected void FillObject(Teacher teacher)
        {
            base.FillObject(teacher);

            teacher.Position = txtForPosition.Text;
        }
    }
}
