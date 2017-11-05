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
    public partial class WorkerCreating : UI.Forms.CreateEdit.HumanCreating
    {
        public new Worker Value;

        public WorkerCreating() : base()
        {
            InitializeComponent();
            AddEvents();

            Text = "Create Worker";
        }

        public WorkerCreating(Worker worker) : base(worker)
        {
            InitializeComponent();

            Value = worker;
            ShowInfo();

            AddEvents();
            Text = "Edit Worker";
            Ok.Enabled = true;
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            if (Value == null)
            {
                Value = new Worker();
            }

            FillObject(Value);

            Close();
        }

        private void AddEvents()
        {
            base.ChangeEvents(txtForSalary_TextChanged, Ok_Click);
            base.ChangeEvents(datePickerForEmploymentDate_ValueChanged, Ok_Click);
            // Worker
            txtForSalary.TextChanged += txtForSalary_TextChanged;
        }

        protected override void ChangeEvents(EventHandler eventHandlerForValidation, EventHandler eventHandlerForBtnOkClick)
        {
            txtForSalary.TextChanged -= txtForSalary_TextChanged;
            txtForSalary.TextChanged += eventHandlerForValidation;

            Ok.Click -= Ok_Click;

            base.ChangeEvents(eventHandlerForValidation, eventHandlerForBtnOkClick);
        }

        protected override bool Verify()
        {
            if (base.Verify())
            {
                try
                {
                    double salary = Convert.ToDouble(txtForSalary.Text);
                    if (salary < 0)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void ShowInfo()
        {
            txtForSalary.Text = Value.Salary.ToString();
            datePickerForEmploymentDate.Value = Value.EmploymentDate;
        }

        protected void FillObject(Worker worker)
        {
            base.FillObject(worker);

            worker.Salary = Convert.ToDouble(txtForSalary.Text);
            worker.EmploymentDate = datePickerForEmploymentDate.Value;
        }

        private void txtForSalary_TextChanged(object sender, EventArgs e)
        {
            Ok.Enabled = Verify();
        }

        private void datePickerForEmploymentDate_ValueChanged(object sender, EventArgs e)
        {
            Ok.Enabled = Verify();
        }
    }
}
