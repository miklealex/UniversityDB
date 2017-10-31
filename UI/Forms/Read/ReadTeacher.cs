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
    public partial class ReadTeacher : UI.Forms.Read.ReadWorker
    {
        private Teacher Teacher;

        public ReadTeacher(Teacher teacher) : base(teacher)
        {
            InitializeComponent();
            Teacher = teacher;
            ShowInfo();
        }

        protected ReadTeacher()
        {
            InitializeComponent();
        }

        private void ShowInfo()
        {
            lblForPosition.Text = Teacher.Position;
        }
    }
}
