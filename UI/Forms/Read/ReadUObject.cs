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
using Database.Repository;
namespace UI.Forms.Read
{
    public partial class ReadUniversity : Form
    {
        private University University;

        protected UniversityCentre repo;

        public ReadUniversity(University uobj)
        {
            repo = new UniversityCentre();
            InitializeComponent();
            University = uobj;
            ShowInfo();
        }

        protected ReadUniversity()
        {
            InitializeComponent();
        }

        private void ShowInfo()
        {
            lblForTitle.Text = University.Title;
            lblForId.Text = University.Id.ToString();
            lblForCreationTime.Text = University.CreationTime.ToString();
            lblForLastWriteTime.Text = University.LastWriteTime.ToString();

            if (University.ParentId != null)
            {
                University major = repo.GetUniversityById((int)University.ParentId);
                linkLblForMajor.Text = major.Title;
            }
            else
            {
                linkLblForMajor.Visible = false;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLblForMajor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int id = (int)University.ParentId;
            ShowDetails(id);
        }

        protected void ShowDetails(int id)
        {
            string type = repo.GetUniversityById(id).ClassName;

            ReadUniversity detailsWindow = null;
            switch (type)
            {
                case "University":
                    detailsWindow = new ReadUniversity(repo.GetUniversityById(id));
                    break;
                case "Person":
                    detailsWindow = new ReadPerson(repo.GetPersonById(id));
                    break;
                case "Worker":
                    detailsWindow = new ReadWorker(repo.GetWorkerById(id));
                    break;
                case "Teacher":
                    detailsWindow = new ReadTeacher(repo.GetTeacherById(id));
                    break;
                case "Entrant":
                    detailsWindow = new ReadEntrant(repo.GetEntrantById(id));
                    break;
                case "Student":
                    detailsWindow = new ReadStudent(repo.GetStudentById(id));
                    break;
                case "ForeignStudent":
                    detailsWindow = new ReadForeignStudent(repo.GetForeignStudentById(id));
                    break;
                default:
                    throw new ArgumentException();
            }

            detailsWindow.ShowDialog();
        }
    }
}
