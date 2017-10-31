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
    public partial class ReadForeignStudent : UI.Forms.Read.ReadStudent
    {
        private ForeignStudent ForeignStudent;

        public ReadForeignStudent(ForeignStudent foreignStudent) : base(foreignStudent)
        {
            InitializeComponent();
            ForeignStudent = foreignStudent;
            ShowInfo();
        }

        protected ReadForeignStudent()
        {
            InitializeComponent();
        }

        private void ShowInfo()
        {
            lblForNationality.Text = ForeignStudent.Nationality;
            lblForUniversity.Text = ForeignStudent.University;
        }
    }
}
