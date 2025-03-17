using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4: Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtName.Text))
                return;

            ListViewItem item = new ListViewItem(txtID.Text.Trim());
            if (rdbtnMale.Checked)
                item.ImageIndex = 0;
            else
                item.ImageIndex = 1;

            item.SubItems.Add(txtName.Text.Trim());
            listView1.Items.Add(item);

            txtName.Clear();
            txtID.Clear();
            txtID.Focus();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
                listView1.Items.Remove(listView1.SelectedItems[0]);
        }

        private void btnFillRandom_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                ListViewItem item = new ListViewItem(i.ToString());

                item.ImageIndex = i % 2;
                item.SubItems.Add("Person" + i);

                listView1.Items.Add(item);

            }
        }

        private void rdbtnDetails_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void rdbtnLargeIcons_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void rdbtnSmallIcons_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void rdbtnList_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }

        private void rdbtnTile_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Tile;
        }
    }
}
