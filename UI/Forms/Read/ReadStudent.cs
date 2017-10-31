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

namespace UI.Forms.Read
{
    public partial class ReadStudent : UI.Forms.Read.ReadPerson
    {
        private Student Student;

        public ReadStudent(Student student) : base(student)
        {
            InitializeComponent();
            Student = student;
            ShowInfo();
        }

        protected ReadStudent()
        {
            InitializeComponent();
        }

        private void ShowInfo()
        {
            lblForCourse.Text = Student.Course.ToString();
            lblForEntryDate.Text = Student.EntryDate.ToShortDateString();
        }
    }
}
