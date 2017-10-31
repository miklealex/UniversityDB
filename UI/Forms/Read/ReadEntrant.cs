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

namespace UI.Forms.Read
{
    public partial class ReadEntrant : UI.Forms.Read.ReadPerson
    {
        private Entrant Entrant;

        public ReadEntrant(Entrant entrant) : base(entrant)
        {
            InitializeComponent();
            Entrant = entrant;
            ShowInfo();
        }

        protected ReadEntrant()
        {
            InitializeComponent();
        }

        private void ShowInfo()
        {
            lblForIEE.Text = Entrant.IEE.ToString();
            lblForGPA.Text = Entrant.GPA.ToString();
        }
    }
}
