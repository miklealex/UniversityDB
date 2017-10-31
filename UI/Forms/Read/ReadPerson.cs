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

namespace UI.Forms.Read
{
    public partial class ReadPerson : UI.Forms.Read.ReadUniversity
    {
        private Person Person;

        public ReadPerson(Person person) : base(person)
        {
            InitializeComponent();
            Person = person;
            ShowInfo();
        }

        protected ReadPerson()
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
