using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Database.ClassHierarhy;
using Database.Repository;
using System.IO;

namespace UI.Forms.CreateEdit
{
    public partial class Faculty : UI.Forms.CreateEdit.UniversityCreating
    {
        public new Database.ClassHierarhy.Faculty Value;
        private bool isDean = false;
        public UniversityCentre repo { get; set; }
        public ListView listView1;

        public Faculty(UniversityCentre _repo)
        {
            repo = _repo;
            InitializeComponent();
            listView1 = new ListView();
            listView1.Bounds = new Rectangle(new Point(320, 20), new Size(150, 150));

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
       

            // Create two ImageList objects.
            ImageList imageListSmall = new ImageList();
            ImageList imageListLarge = new ImageList();

            imageListLarge.Images.Add(Bitmap.FromFile(Path.GetFullPath("..\\..\\..\\images\\File.bmp")));

            //Assign the ImageList objects to the ListView.
            listView1.LargeImageList = imageListLarge;
            this.Controls.Add(listView1);
        }

        public Faculty(Database.ClassHierarhy.Faculty person, UniversityCentre repos) : base(person)
        {
            repo = repos;
            InitializeComponent();

            Value = person;
            ShowInfo();

            AddEvents();
            Text = "Edit Person";
            Ok.Enabled = true;
        }

        protected override void ChangeEvents(EventHandler eventHandlerForValidation, EventHandler eventHandlerForBtnOkClick)
        {
            tBFacultyName.TextChanged += eventHandlerForValidation;

            Ok.Click -= Ok_Click;

            base.ChangeEvents(eventHandlerForValidation, eventHandlerForBtnOkClick);
        }

        private void AddEvents()
        {
            //base.ChangeEvents(SomethingChanged, Ok_Click);

            // Person
            tBFacultyName.TextChanged += tBFacultyName_TextChanged;

        }

        protected void FillObject(Database.ClassHierarhy.Faculty fac)
        {
            base.FillObject(fac);

            fac.FacultyName = tBFacultyName.Text;
            fac.Den = repo.GetDBTeacherById(Value.DeanId);
        }

        protected override bool Verify()
        {
            return  tBFacultyName != null && tBFacultyName.Text.Length > 0  && isDean && listView1.Items.Count > 0 && base.Verify();
        }

        private void ShowInfo()
        {
            tBFacultyName.Text = Value.FacultyName;
            label1.Text = repo.GetTeacherById(Value.DeanId).Name;
        }

        private void tBFacultyName_TextChanged(object sender, EventArgs e)
        {
            Ok.Enabled = Verify();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            if (Value == null)
            {
                Value = new Database.ClassHierarhy.Faculty();
            }

            FillObject(Value);
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Value == null)
            {
                Value = new Database.ClassHierarhy.Faculty();
            }
            AddDean dean = new AddDean(repo);
            if(dean.ShowDialog() == DialogResult.OK)
            {
                Value.DeanId = dean.DEAN_ID;
                
                label1.Text = repo.GetTeacherById(dean.DEAN_ID).Name;
                isDean = true;
                Ok.Enabled = Verify();
            }
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

        private void label1_Click(object sender, EventArgs e)
        {
            ShowDean(Value.DeanId);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddInstitute diag = new AddInstitute(repo);
            if(diag.ShowDialog() == DialogResult.OK)
            {
                Database.ClassHierarhy.Institute inst = repo.GetInstituteById(diag.Inst_ID);
                if (listView1.FindItemWithText(inst.Id + " " + inst.InstituteName) == null)
                {
                    listView1.Items.Add(inst.Id + " " + inst.InstituteName);
                    inst.facultyId = Value.Id;
                    repo.UpdateInstitute(inst);
                }
            }
            Ok.Enabled = Verify();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RemoveTeacher diag = new RemoveTeacher(listView1);
            if(diag.ShowDialog() == DialogResult.OK)
            {
                int removed = 0;
                foreach (int index in diag.removedIndexes)
                {
                    Database.ClassHierarhy.Institute remInst = repo.GetInstituteById(int.Parse(listView1.Items[index - removed].Text.Split(' ')[0]));
                    remInst.facultyId = -1;
                    repo.UpdateInstitute(remInst);
                    listView1.Items.RemoveAt(index - removed);
                    removed++;
                }
                listView1.Update();
                Ok.Enabled = Verify();
            }
        }
    }
}
