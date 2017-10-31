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
using Database.Repository;
namespace UI.Forms.Read
{
    public partial class ReadUObject : Form
    {
        private UObject UObject;

        protected URepository repo;

        public ReadUObject(UObject uobj)
        {
            repo = new URepository();
            InitializeComponent();
            UObject = uobj;
            ShowInfo();
        }

        protected ReadUObject()
        {
            InitializeComponent();
        }

        private void ShowInfo()
        {
            lblForTitle.Text = UObject.Title;
            lblForId.Text = UObject.Id.ToString();
            lblForCreationTime.Text = UObject.CreationTime.ToString();
            lblForLastWriteTime.Text = UObject.LastWriteTime.ToString();

            if (UObject.MajorId != null)
            {
                UObject major = repo.GetUObjectById((int)UObject.MajorId);
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
            int id = (int)UObject.MajorId;
            ShowDetails(id);
        }

        protected void ShowDetails(int id)
        {
            string type = repo.GetUObjectById(id).ClassName;

            ReadUObject detailsWindow = null;
            switch (type)
            {
                case "UObject":
                    detailsWindow = new ReadUObject(repo.GetUObjectById(id));
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
