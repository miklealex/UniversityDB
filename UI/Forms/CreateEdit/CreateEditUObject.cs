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
    public partial class CreateEditUniversity : Form
    {
        public University Value;

        public CreateEditUniversity()
        {
            InitializeComponent();
            AddEvents();

            Text = "Create University";
        }

        public CreateEditUniversity(University uobj)
        {
            InitializeComponent();

            Value = uobj;
            ShowInfo();

            AddEvents();
            Text = "Edit University";
            btnOk.Enabled = true;
        }

        private void AddEvents()
        {
            // University
            txtForTitle.TextChanged += SomethingChanged;

            // btnOk
            btnOk.Click += btnOk_Click;
        }

        protected virtual void ChangeEvents(EventHandler eventHandlerForValidation, EventHandler eventHandlerForBtnOkClick)
        {
            txtForTitle.TextChanged -= SomethingChanged;
            txtForTitle.TextChanged += eventHandlerForValidation;

            btnOk.Click -= btnOk_Click;
            btnOk.Click += eventHandlerForBtnOkClick;
        }

        private void SomethingChanged(object sender, EventArgs e)
        {
            btnOk.Enabled = this.Verify();
        }

        protected virtual bool Verify()
        {
            return txtForTitle.Text.Length > 0;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (Value == null)
            {
                Value = new University();
            }

            FillObject(Value);

            Close();
        }

        private void ShowInfo()
        {
            txtForTitle.Text = Value.Title;
        }

        protected void FillObject(University uObj)
        {
            uObj.Title = txtForTitle.Text;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
