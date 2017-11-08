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
    public partial class Human : UI.Forms.Read.University
    {
        private Person Person;

        public Human(Person person) : base(person)
        {
            InitializeComponent();
            Person = person;
            ShowInfo();
        }

        protected Human()
        {
            InitializeComponent();
        }

        private void ShowInfo()
        {
            lblForName.Text = Person.Name;
            lblForSurname.Text = Person.Surname;
            lblForBirthday.Text = Person.Birthday.ToShortDateString();
            lblForGender.Text = Person.Gender ? "Male" : "Female";
        }
    }
}
