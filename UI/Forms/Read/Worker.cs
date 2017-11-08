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
    public partial class Worker : UI.Forms.Read.Human
    {
        private Database.ClassHierarhy.Worker _worker;

        public Worker(Database.ClassHierarhy.Worker worker) : base(worker)
        {
            InitializeComponent();
            _worker = worker;
            ShowInfo();
        }

        protected Worker()
        {
            InitializeComponent();
        }

        private void ShowInfo()
        {
            lblForSalary.Text = _worker.Salary.ToString();
            lblForEmploymentDate.Text = _worker.EmploymentDate.ToShortDateString();
        }
    }
}
