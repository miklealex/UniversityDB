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
    public partial class UniversityCreating : Form
    {
        public University Value;

        public UniversityCreating()
        {
            InitializeComponent();
        }
        public UniversityCreating(University uobj)
        {
            InitializeComponent();

            Value = uobj;
            ShowInfo();

            AddEvents();
            Text = "Edit University";
            Ok.Enabled = true;
        }

        private void AddEvents()
        {
            // University
            univerTitle.TextChanged += univerTitle_TextChanged;

            // btnOk
            Ok.Click += Ok_Click;
        }

        protected virtual bool Verify()
        {
            return univerTitle.Text.Length > 0;
        }

        protected virtual void ChangeEvents(EventHandler eventHandlerForValidation, EventHandler eventHandlerForBtnOkClick)
        {
            univerTitle.TextChanged -= univerTitle_TextChanged;
            univerTitle.TextChanged += eventHandlerForValidation;

            Ok.Click += eventHandlerForBtnOkClick;
        }

        private void ShowInfo()
        {
            univerTitle.Text = Value.Title;
        }

        protected void FillObject(University uObj)
        {
            uObj.Title = univerTitle.Text;
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            if (Value == null)
            {
                Value = new University();
            }

            FillObject(Value);
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void SomethingChanged(object sender, EventArgs e)
        {
            Ok.Enabled = this.Verify();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void univerTitle_TextChanged(object sender, EventArgs e)
        {
            Ok.Enabled = this.Verify();
        }

        private void Ok_Click_1(object sender, EventArgs e)
        {

        }
    }
}
