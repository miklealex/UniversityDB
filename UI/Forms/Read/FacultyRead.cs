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
            linkLabel1.Text = repo.GetTeacherById(_facult.DeanId).Name;
        }

        public void ShowDean(int id)
        {
            string type = repo.GetUniversityById(id).ClassName;

            UI.Forms.Read.University detailsWindow = null;
            switch (type)
            {

                case "Teacher":
                    detailsWindow = new UI.Forms.Read.Teacher(repo.GetTeacherById(id));
                    break;
                default:
                    throw new ArgumentException();
            }

            detailsWindow.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowDean(_facult.DeanId);
        }
    }
}
