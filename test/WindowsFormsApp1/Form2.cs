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
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnShowForm1_Click(object sender, EventArgs e)
        {
            Form form = new Form1();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new Form1();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form msgboxform = new Form3();
            msgboxform.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form ListView = new Form4();
            ListView.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form ErrorProvider = new Form5();
            ErrorProvider.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form TrackBar = new Form6();
            TrackBar.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form NumericUpDown = new Form7();
            NumericUpDown.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form TabGroup = new Form8();
            TabGroup.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form ColorDialog = new Form9();
            ColorDialog.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form MDI = new Form10();
            MDI.ShowDialog();
        }
    }
}
