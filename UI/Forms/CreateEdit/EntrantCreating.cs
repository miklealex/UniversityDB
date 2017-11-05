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
    public partial class EntrantCreating : UI.Forms.CreateEdit.HumanCreating
    {
        public new Entrant Value;

        public EntrantCreating() : base()
        {
            InitializeComponent();
            AddEvents();

            Text = "Create Entrant";
        }

        public EntrantCreating(Entrant entrant) : base(entrant)
        {
            InitializeComponent();

            Value = entrant;
            ShowInfo();

            AddEvents();
            Text = "Edit Entrant";
            Ok.Enabled = true;
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            if (Value == null)
            {
                Value = new Entrant();
            }

            FillObject(Value);

            Close();
        }

        private void AddEvents()
        {
            base.ChangeEvents(txtForIEE_TextChanged, Ok_Click);
            base.ChangeEvents(txtForGPA_TextChanged, Ok_Click);

            // Entrant
            txtForIEE.TextChanged += txtForIEE_TextChanged;
            txtForGPA.TextChanged += txtForGPA_TextChanged;
        }

        protected override void ChangeEvents(EventHandler eventHandlerForValidation, EventHandler eventHandlerForBtnOkClick)
        {
            txtForIEE.TextChanged -= txtForIEE_TextChanged;
            txtForGPA.TextChanged -= txtForGPA_TextChanged;

            txtForIEE.TextChanged += eventHandlerForValidation;
            txtForGPA.TextChanged += eventHandlerForValidation;

            Ok.Click -= Ok_Click;

            base.ChangeEvents(eventHandlerForValidation, eventHandlerForBtnOkClick);
        }

        private void txtForIEE_TextChanged(object sender, EventArgs e)
        {
            Ok.Enabled = Verify();
        }

        private void txtForGPA_TextChanged(object sender, EventArgs e)
        {
            Ok.Enabled = Verify();
        }

        private void ShowInfo()
        {
            txtForGPA.Text = Value.GPA.ToString();
            txtForIEE.Text = Value.IEE.ToString();
        }

        protected override bool Verify()
        {
            if (base.Verify())
            {
                try
                {
                    int IEE = Convert.ToInt32(txtForIEE.Text);
                    double GPA = Convert.ToDouble(txtForGPA.Text);

                    if (IEE < 0 || IEE > 1000 ||
                        GPA < 0.00 || GPA > 12.00)
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

        protected void FillObject(Entrant entrant)
        {
            base.FillObject(entrant);

            entrant.IEE = Convert.ToInt32(txtForIEE.Text);
            entrant.GPA = Convert.ToDouble(txtForGPA.Text);
        }
    }
}
