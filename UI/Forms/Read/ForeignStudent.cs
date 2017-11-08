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
    public partial class ForeignStudent : UI.Forms.Read.Student
    {
        private Database.ClassHierarhy.ForeignStudent _foreignStudent;

        public ForeignStudent(Database.ClassHierarhy.ForeignStudent foreignStudent) : base(foreignStudent)
        {
            InitializeComponent();
            _foreignStudent = foreignStudent;
            ShowInfo();
        }

        protected ForeignStudent()
        {
            InitializeComponent();
        }

        private void ShowInfo()
        {
            lblForNationality.Text = _foreignStudent.Nationality;
            lblForUniversity.Text = _foreignStudent.University;
        }
    }
}
