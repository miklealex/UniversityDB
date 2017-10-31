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
    public partial class CreateEditWorker : UI.Forms.CreateEdit.CreateEditPerson
    {
        public new Worker Value;

        public CreateEditWorker() : base()
        {
            InitializeComponent();
            AddEvents();

            Text = "Create Worker";
        }

        public CreateEditWorker(Worker worker) : base(worker)
        {
            InitializeComponent();

            Value = worker;
            ShowInfo();

            AddEvents();
            Text = "Edit Worker";
            btnOk.Enabled = true;
        }

        private void AddEvents()
        {
            base.ChangeEvents(SomethingChanged, btnOk_Click);

            // Worker
            txtForSalary.TextChanged += SomethingChanged;
        }

        protected override void ChangeEvents(EventHandler eventHandlerForValidation, EventHandler eventHandlerForBtnOkClick)
        {
            txtForSalary.TextChanged -= SomethingChanged;
            txtForSalary.TextChanged += eventHandlerForValidation;

            btnOk.Click -= btnOk_Click;
            
            base.ChangeEvents(eventHandlerForValidation, eventHandlerForBtnOkClick);
        }

        private void SomethingChanged(object sender, EventArgs e)
        {
            btnOk.Enabled = Verify();
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

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (Value == null)
            {
                Value = new Worker();
            }

            FillObject(Value);

            Close();
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
    }
}
