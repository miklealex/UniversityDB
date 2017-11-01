using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class СhooseEntity : Form
    {
        public string SelectedType;
        private ListView listView1;
        public СhooseEntity(List<string> types)
        {
            CreateMyListView(types);
            InitializeComponent();
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listView_SelIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                SelectedType = listView1.SelectedItems[0].Text;
                btnOk.Enabled = true;
            }
            else
            {
                btnOk.Enabled = false;
            }
        }

        private void listView_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left && Control.ModifierKeys != Keys.Shift)
            {
                
            }

        }

        private void CreateMyListView(List<string> types)
        {
            // Create a new ListView control.
            listView1 = new ListView();
            listView1.Bounds = new Rectangle(new Point(10, 10), new Size(300, 400));

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

            foreach (string obj in types)
            {
                listView1.Items.Add(obj,0);
            }
            // Create two ImageList objects.
            ImageList imageListSmall = new ImageList();
            ImageList imageListLarge = new ImageList();

            imageListLarge.Images.Add(Bitmap.FromFile("D:\\VSprojects\\UniversityDB\\UniversityDB\\images\\File.bmp"));

            //Assign the ImageList objects to the ListView.
            listView1.LargeImageList = imageListLarge;

            // Add the ListView to the control collection.
            this.Controls.Add(listView1);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView_SelIndexChanged);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_MouseDown);
        }
    }
}
