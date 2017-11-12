using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Database.ClassHierarhy;
using Database;

namespace UI.Forms.Read
{
    public partial class InstituteRead : UI.Forms.Read.FacultyRead
    {
        private Database.ClassHierarhy.Institute institute;
        public ListView listView1;
        public InstituteRead()
        {
            InitializeComponent();
        }

        public InstituteRead(Database.ClassHierarhy.Institute inst) : base(inst)
        {
            InitializeComponent();
            listView1 = new ListView();
            listView1.Bounds = new Rectangle(new Point(200, 200), new Size(300, 200));

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
            foreach (DBTeacher obj in repo.GetAllTeachers())
            {
                Database.ClassHierarhy.Teacher currentTeacher = repo.GetTeacherById(obj.Id);
                if(currentTeacher.InstituteId == inst.Id)
                listView1.Items.Add(obj.Id + " " + repo.GetTeacherById(obj.Id).Name);
            }

            // Create two ImageList objects.
            ImageList imageListSmall = new ImageList();
            ImageList imageListLarge = new ImageList();

            imageListLarge.Images.Add(Bitmap.FromFile("D:\\VSprojects\\UniversityDB\\UniversityDB\\images\\File.bmp"));

            //Assign the ImageList objects to the ListView.
            listView1.LargeImageList = imageListLarge;

            // Add the ListView to the control collection.
            this.Controls.Add(listView1);
            institute = inst;
            ShowInfo();
        }

        private void ShowInfo()
        {
            label1.Text = institute.InstituteName;
            linkLabel2.Text = repo.GetTeacherById(institute.Head.Id).Name;
        }

        public void ShowHead(int id)
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

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowHead(institute.Head.Id);
        }
    }
}
