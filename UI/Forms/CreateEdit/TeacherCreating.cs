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
    public partial class TeacherCreating : UI.Forms.CreateEdit.WorkerCreating
    {
        public new Teacher Value;

        public TeacherCreating() : base()
        {
            InitializeComponent();
            AddEvents();

            Text = "Create Teacher";
        }

        public TeacherCreating(Teacher teacher) : base(teacher)
        {
            InitializeComponent();

            Value = teacher;
            ShowInfo();

            AddEvents();
            Text = "Edit Teacher";
            Ok.Enabled = true;
        }

        private void AddEvents()
        {
            base.ChangeEvents(txtForPosition_TextChanged, Ok_Click);

            // Teacher
            txtForPosition.TextChanged += txtForPosition_TextChanged;
        }

        protected override bool Verify()
        {
            return txtForPosition.Text.Length > 0 &&
                base.Verify();
        }

        protected override void ChangeEvents(EventHandler eventHandlerForValidation, EventHandler eventHandlerForBtnOkClick)
        {
            txtForPosition.TextChanged -= txtForPosition_TextChanged;
            txtForPosition.TextChanged += eventHandlerForValidation;

            Ok.Click -= Ok_Click;

            base.ChangeEvents(eventHandlerForValidation, eventHandlerForBtnOkClick);
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            if (Value == null)
            {
                Value = new Teacher();
            }

            FillObject(Value);

            Close();
        }

        private void txtForPosition_TextChanged(object sender, EventArgs e)
        {
            Ok.Enabled = Verify();
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
