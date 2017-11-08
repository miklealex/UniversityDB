using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database.Repository;

namespace UI.Forms.Read
{
    public partial class University : Form
    {
        private Database.ClassHierarhy.University _University;

        protected UniversityCentre repo;

        public University(Database.ClassHierarhy.University uobj)
        {
            repo = new UniversityCentre();
            InitializeComponent();
            _University = uobj;
            ShowInfo();
        }

        protected University()
        {
            InitializeComponent();
        }

        private void ShowInfo()
        {
            lblForTitle.Text = _University.Title;
            lblForId.Text = _University.Id.ToString();
            lblForCreationTime.Text = _University.CreationTime.ToString();
            lblForLastWriteTime.Text = _University.LastWriteTime.ToString();

            if (_University.ParentId != null)
            {
                Database.ClassHierarhy.University major = repo.GetUniversityById((int)_University.ParentId);
                linkLblForMajor.Text = major.Title;
            }
            else
            {
                linkLblForMajor.Visible = false;
            }
        }

        protected void ShowDetails(int id)
        {
            string type = repo.GetUniversityById(id).ClassName;

            University detailsWindow = null;
            switch (type)
            {
                case "University":
                    detailsWindow = new University(repo.GetUniversityById(id));
                    break;
                case "Person":
                    detailsWindow = new University(repo.GetPersonById(id));
                    break;
                case "Worker":
                    detailsWindow = new University(repo.GetWorkerById(id));
                    break;
                case "Teacher":
                    detailsWindow = new University(repo.GetTeacherById(id));
                    break;
                case "Entrant":
                    detailsWindow = new University(repo.GetEntrantById(id));
                    break;
                case "Student":
                    detailsWindow = new University(repo.GetStudentById(id));
                    break;
                case "ForeignStudent":
                    detailsWindow = new University(repo.GetForeignStudentById(id));
                    break;
                default:
                    throw new ArgumentException();
            }

            detailsWindow.ShowDialog();
        }

        private void linkLblForMajor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int id = (int)_University.ParentId;
            ShowDetails(id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
