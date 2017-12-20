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
    public partial class Institute : UI.Forms.CreateEdit.UniversityCreating
    {
        public new Database.ClassHierarhy.Institute Value;
        private bool isHead = false;
        public ListView listView1;
        public UniversityCentre repo;
        public Institute(UniversityCentre repos)
        {
            repo = repos;
            InitializeComponent();
            InitializeComponent();
            // Create a new ListView control.
            listView1 = new ListView();
            listView1.Bounds = new Rectangle(new Point(310, 30), new Size(200, 180));

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
            if (repo.GetAllTeachers() != null)
            {
                foreach (Database.DBTeacher obj in repo.GetAllTeachers())
                {
                    Teacher currentTeacher = new Teacher(obj, repo.GetContext());
                    if(Value != null && currentTeacher.InstituteId == Value.Id)
                    listView1.Items.Add(currentTeacher.Id + ' ' + currentTeacher.Name, 0);
                }
                // Create two ImageList objects.
                ImageList imageListSmall = new ImageList();
                ImageList imageListLarge = new ImageList();

                imageListLarge.Images.Add(Bitmap.FromFile(Path.GetFullPath("..\\..\\..\\images\\File.bmp")));
                //Assign the ImageList objects to the ListView.
                listView1.LargeImageList = imageListLarge;

                // Add the ListView to the control collection.
                this.Controls.Add(listView1);
                this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView_SelIndexChanged);
                //this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_MouseDown);
            }
        }

        public Institute(Database.ClassHierarhy.Institute inst, UniversityCentre repos) : base(inst)
        {
            repo = repos;
            listView1 = new ListView();
            listView1.Bounds = new Rectangle(new Point(310, 10), new Size(200, 200));

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
            if (repo.GetAllTeachers() != null)
            {
                foreach (Database.DBTeacher obj in repo.GetAllTeachers())
                {
                    Teacher currentTeacher = new Teacher(obj, repo.GetContext());
                    if (Value != null && currentTeacher.InstituteId == Value.Id)
                        listView1.Items.Add(currentTeacher.Id + ' ' + currentTeacher.Name, 0);
                }
                // Create two ImageList objects.
                ImageList imageListSmall = new ImageList();
                ImageList imageListLarge = new ImageList();

                imageListLarge.Images.Add(Bitmap.FromFile(Path.GetFullPath("..\\..\\..\\images\\File.bmp")));

                //Assign the ImageList objects to the ListView.
                listView1.LargeImageList = imageListLarge;

                // Add the ListView to the control collection.
                this.Controls.Add(listView1);
                this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView_SelIndexChanged);
                //this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_MouseDown);
            }
            InitializeComponent();
            Value = inst;
            ShowInfo();

            AddEvents();
            Text = "Edit Person";
            Ok.Enabled = true;
        }

        private void AddEvents()
        {
            //base.ChangeEvents(SomethingChanged, Ok_Click);

            // Person
            textBox1.TextChanged += textBox1_TextChanged;

        }

        protected void FillObject(Database.ClassHierarhy.Institute inst)
        {
            base.FillObject(inst);

            inst.InstituteName = textBox1.Text;
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

        protected override bool Verify()
        {
            return (textBox1 != null ? textBox1.Text.Length > 0 : true) && isHead && base.Verify() && (listView1 != null ? listView1.Items.Count > 0 : true);
        }

        private void ShowInfo()
        {
            textBox1.Text = Value.InstituteName;
            linkLabel1.Text = repo.GetTeacherById(Value.Head.Id).Name;
            foreach(Database.DBTeacher curTeacher in repo.GetAllTeachers())
            {
                Teacher curT = repo.GetTeacherById(curTeacher.Id);
                if(curT.InstituteId == Value.Id)
                {
                    listView1.Items.Add(curT.Id + " " + curT.Name, 0);
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowHead(Value.Head.Id);
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            if (Value == null)
            {
                Value = new Database.ClassHierarhy.Institute();
            }

            FillObject(Value);
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void listView_SelIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Ok.Enabled = Verify();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Value == null)
            {
                Value = new Database.ClassHierarhy.Institute();
            }
            AddDean dean = new AddDean(repo);
            if (dean.ShowDialog() == DialogResult.OK)
            {
                Value.Head = repo.GetDBTeacherById(dean.DEAN_ID);
                linkLabel1.Text = repo.GetTeacherById(dean.DEAN_ID).Name;
                isHead = true;
                Ok.Enabled = Verify();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddDean diag = new AddDean(repo);
            if(diag.ShowDialog() == DialogResult.OK)
            {
                if (listView1.FindItemWithText(diag.DEAN_ID.ToString() + " " + repo.GetTeacherById(diag.DEAN_ID).Name) == null)
                {
                    listView1.Items.Add(diag.DEAN_ID.ToString() + " " + repo.GetTeacherById(diag.DEAN_ID).Name, 0);
                    Teacher curTeacher = repo.GetTeacherById(diag.DEAN_ID);
                    curTeacher.InstituteId = Value.Id;
                    repo.UpdateTeacher(curTeacher);
                }
                Ok.Enabled = Verify();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RemoveTeacher diag = new RemoveTeacher(listView1);
            if(diag.ShowDialog() == DialogResult.OK)
            {
                int removed = 0;
                foreach(int index in diag.removedIndexes)
                {
                    Teacher remTeacher = repo.GetTeacherById(int.Parse(listView1.Items[index - removed].Text.Split(' ')[0]));
                    remTeacher.InstituteId = -1;
                    remTeacher.Institute = null;
                    repo.UpdateTeacher(remTeacher);
                    listView1.Items.RemoveAt(index - removed);
                    removed++;
                }
                listView1.Update();
                Ok.Enabled = Verify();
            }
        }
    }
}
