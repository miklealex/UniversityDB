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
    public partial class Teacher : UI.Forms.Read.Worker
    {
        private Database.ClassHierarhy.Teacher _teacher;

        public Teacher(Database.ClassHierarhy.Teacher teacher): base(teacher)
        {
            InitializeComponent();
            _teacher = teacher;
            ShowInfo();
        }

        protected Teacher()
        {
            InitializeComponent();
        }

        private void ShowInfo()
        {
            lblForPosition.Text = _teacher.Position;
        }
    }
}
