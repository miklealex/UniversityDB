using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Database.ClassHierarhy;
using System.IO;
using Database.Repository;

namespace UI.Forms.Read
{
    public partial class FacultyRead : UI.Forms.Read.University
    {
        private Database.ClassHierarhy.Faculty _facult;
        public ListView listView1;
        public FacultyRead(Database.ClassHierarhy.Faculty facult) : base(facult)
        {
            InitializeComponent();
            _facult = facult;
            listView1 = new ListView();
            listView1.Bounds = new Rectangle(new Point(220, 120), new Size(150, 250));

            // Set the view to show details.
            listView1.View = View.LargeIcon;
            // Allow the user to edit item text.
            listView1.LabelEdit = true;
            // Allow the user to rearrange columns.
            listView1.AllowColumnReorder = true;
            // Select the item and subitems when selection is made.
            listView1.FullRowSelect = true;
            // Display grid lines.
            listView1.GridLines = true;

            listView1.Scrollable = true;

            foreach(Database.DBInstitute obj in repo.GetAllInstitutes())
            {
                Database.ClassHierarhy.Institute curInst = repo.GetInstituteById(obj.Id);
                if(curInst.facultyId == facult.Id)
                {
                    listView1.Items.Add(obj.Id + " " + obj.InstituteName);
                }
            }
            // Create two ImageList objects.
            ImageList imageListSmall = new ImageList();
            ImageList imageListLarge = new ImageList();

            imageListLarge.Images.Add(Bitmap.FromFile(Path.GetFullPath("..\\..\\..\\images\\File.bmp")));

            //Assign the ImageList objects to the ListView.
            listView1.LargeImageList = imageListLarge;
            this.Controls.Add(listView1);
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
