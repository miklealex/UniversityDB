using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Forms.CreateEdit
{
    public partial class RemoveTeacher : Form
    {
        public ListView listView1;
        public List<int> removedIndexes = new List<int>();
        public RemoveTeacher(ListView curListView)
        {
            listView1 = new ListView();
            listView1.Bounds = new Rectangle(new Point(10, 10), new Size(200, 200));

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
            ImageList imageListLarge = new ImageList();
            imageListLarge.Images.Add(Bitmap.FromFile("D:\\VSprojects\\UniversityDB\\UniversityDB\\images\\File.bmp"));

            //Assign the ImageList objects to the ListView.
            listView1.LargeImageList = imageListLarge;
            listView1.Scrollable = true;
            foreach (ListViewItem obj in curListView.Items)
            {
                listView1.Items.Add(obj.Text);
            }
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView_SelIndexChanged);
            this.Controls.Add(listView1);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            removedIndexes.Add(listView1.SelectedIndices[0] + removedIndexes.Count);
            listView1.Items.Remove(listView1.SelectedItems[0]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listView_SelIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
