using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Database.ClassHierarhy;
using Database.Repository;

namespace UI.Forms.CreateEdit
{
    public partial class Faculty : UI.Forms.CreateEdit.UniversityCreating
    {
        public new Database.ClassHierarhy.Faculty Value;
        private bool isDean = false;
        public UniversityCentre repo { get; set; }

        public Faculty()
        {
            
            InitializeComponent();
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
            return  tBFacultyName != null && tBFacultyName.Text.Length > 0  && isDean && base.Verify();
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
    }
}
