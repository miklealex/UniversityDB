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

        public СhooseEntity(List<string> types)
        {
            InitializeComponent();

            comboBox.Items.AddRange(types.ToArray());

            foreach (string obj in types)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = obj;
                listView1.Items.Add(lvi);
            }
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedType = comboBox.SelectedItem.ToString();
            btnOk.Enabled = true;
        }
    }
}
