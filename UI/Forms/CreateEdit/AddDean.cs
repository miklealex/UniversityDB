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
using Database;

namespace UI.Forms.CreateEdit
{
    public partial class AddDean : Form
    {
        private ListView listView1;
        private UniversityCentre repo;
        public int  DEAN_ID {get; set;}
        public AddDean(UniversityCentre repos)
        {
            repo = repos;
            InitializeComponent();
            // Create a new ListView control.
            listView1 = new ListView();
            listView1.Bounds = new Rectangle(new Point(10, 10), new Size(300, 200));

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
            foreach(DBTeacher obj in repo.GetAllTeachers())
            {
                listView1.Items.Add(obj.Id + " " + repo.GetTeacherById(obj.Id).Name);
            }

            // Create two ImageList objects.
            ImageList imageListSmall = new ImageList();
            ImageList imageListLarge = new ImageList();

            imageListLarge.Images.Add(Bitmap.FromFile("D:\\VSprojects\\UniversityDB\\UniversityDB\\images\\File.bmp"));

            //Assign the ImageList objects to the ListView.
            listView1.LargeImageList = imageListLarge;
            listView1.ItemSelectionChanged += label1_Click;

            // Add the ListView to the control collection.
            this.Controls.Add(listView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DEAN_ID = int.Parse(listView1.SelectedItems[0].Text.Split(' ')[0]);
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count == 1)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }
    }
}
