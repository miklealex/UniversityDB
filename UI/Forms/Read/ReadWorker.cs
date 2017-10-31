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
    public partial class ReadWorker : UI.Forms.Read.ReadPerson
    {
        private Worker Worker;

        public ReadWorker(Worker worker) : base(worker)
        {
            InitializeComponent();
            Worker = worker;
            ShowInfo();
        }

        protected ReadWorker()
        {
            InitializeComponent();
        }

        private void ShowInfo()
        {
            lblForSalary.Text = Worker.Salary.ToString();
            lblForEmploymentDate.Text = Worker.EmploymentDate.ToShortDateString();
        }
    }
}
