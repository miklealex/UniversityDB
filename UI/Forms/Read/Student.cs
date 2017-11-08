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
    public partial class Student : UI.Forms.Read.Human
    {
        private Database.ClassHierarhy.Student _student;

        public Student(Database.ClassHierarhy.Student student) : base(student)
        {
            InitializeComponent();
           _student = student;
            ShowInfo();
        }

        protected Student()
        {
            InitializeComponent();
        }

        private void ShowInfo()
        {
            //lblForCourse.Text = _student.Course.ToString();
            lblForEntryDate.Text = _student.EntryDate.ToShortDateString();
        }
    }
}
