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
    public partial class CreateEditEntrant : UI.Forms.CreateEdit.CreateEditPerson
    {
        public new Entrant Value;

        public CreateEditEntrant() : base()
        {
            InitializeComponent();
            AddEvents();

            Text = "Create Entrant";
        }

        public CreateEditEntrant(Entrant entrant) : base(entrant)
        {
            InitializeComponent();

            Value = entrant;
            ShowInfo();

            AddEvents();
            Text = "Edit Entrant";
            btnOk.Enabled = true;
        }

        private void AddEvents()
        {
            base.ChangeEvents(SomethingChanged, btnOk_Click);

            // Entrant
            txtForIEE.TextChanged += SomethingChanged;
            txtForGPA.TextChanged += SomethingChanged;
        }

        protected override void ChangeEvents(EventHandler eventHandlerForValidation, EventHandler eventHandlerForBtnOkClick)
        {
            txtForIEE.TextChanged -= SomethingChanged;
            txtForGPA.TextChanged -= SomethingChanged;

            txtForIEE.TextChanged += eventHandlerForValidation;
            txtForGPA.TextChanged += eventHandlerForValidation;

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

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (Value == null)
            {
                Value = new Entrant();
            }

            FillObject(Value);

            Close();
        }

        private void ShowInfo()
        {
            txtForGPA.Text = Value.GPA.ToString();
            txtForIEE.Text = Value.IEE.ToString();
        }

        protected void FillObject(Entrant entrant)
        {
            base.FillObject(entrant);

            entrant.IEE = Convert.ToInt32(txtForIEE.Text);
            entrant.GPA = Convert.ToDouble(txtForGPA.Text);
        }
    }
}
