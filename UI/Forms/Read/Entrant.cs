using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Database.ClassHierarhy;

namespace UI.Forms.Read
{
    public partial class Entrant : UI.Forms.Read.Human
    {
        private Database.ClassHierarhy.Entrant _entrant;

        public Entrant(Database.ClassHierarhy.Entrant entrant) : base(entrant)
        {
            InitializeComponent();
            _entrant = entrant;
            ShowInfo();
        }

        protected Entrant()
        {
            InitializeComponent();
        }

        private void ShowInfo()
        {
            lblForIEE.Text = _entrant.IEE.ToString();
            lblForGPA.Text = _entrant.GPA.ToString();
        }
    }
}
