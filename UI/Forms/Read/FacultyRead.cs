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
    public partial class FacultyRead : UI.Forms.Read.University
    {
        private Database.ClassHierarhy.Faculty _facult;

        public FacultyRead(Database.ClassHierarhy.Faculty facult) : base(facult)
        {
            InitializeComponent();
            _facult = facult;
            ShowInfo();
        }

        protected FacultyRead()
        {
            InitializeComponent();
        }

        private void ShowInfo()
        {
            FacNamelb.Text = _facult.FacultyName;
        }
    }
}
