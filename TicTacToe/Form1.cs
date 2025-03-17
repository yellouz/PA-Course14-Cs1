using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.Properties;

namespace TicTacToe
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color Black = Color.White;

            Pen pen = new Pen(Black);
            pen.Width = 10;

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(pen, 500, 90, 500, 300);
            e.Graphics.DrawLine(pen, 650, 90, 650, 300);
            
            e.Graphics.DrawLine(pen, 400, 150, 750, 150);
            e.Graphics.DrawLine(pen, 400, 225, 750, 225);
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.question_mark_96;
            pictureBox1.Tag = "question_mark";
            pictureBox2.Image = Resources.question_mark_96;
            pictureBox2.Tag = "question_mark";
            pictureBox4.Image = Resources.question_mark_96;
            pictureBox4.Tag = "question_mark";
            pictureBox5.Image = Resources.question_mark_96;
            pictureBox5.Tag = "question_mark";
            pictureBox3.Image = Resources.question_mark_96;
            pictureBox3.Tag = "question_mark";
            pictureBox6.Image = Resources.question_mark_96;
            pictureBox6.Tag = "question_mark";
            pictureBox7.Image = Resources.question_mark_96;
            pictureBox7.Tag = "question_mark";
            pictureBox8.Image = Resources.question_mark_96;
            pictureBox8.Tag = "question_mark";
            pictureBox9.Image = Resources.question_mark_96;
            pictureBox9.Tag = "question_mark";

            lblPlayerTurn.Text = "Player1";
            lblWineer.Text = "In Progress";
        }

        void TestForWinner()
        {
            if (pictureBox1.Tag == pictureBox2.Tag && pictureBox2.Tag == pictureBox3.Tag)
            {
                if (pictureBox1.Tag == "X")
                {
                    lblWineer.Text = "Player1 Wins";
                    lblPlayerTurn.Text = "Game Over";
                }
                else if (pictureBox1.Tag == "O")
                {
                    lblWineer.Text = "Player2 Wins";
                    lblPlayerTurn.Text = "Game Over";
                }
            }
            else if (pictureBox4.Tag == pictureBox5.Tag && pictureBox5.Tag == pictureBox6.Tag)
            {
                if (pictureBox4.Tag == "X")
                {
                    lblWineer.Text = "Player1 Wins";
                    lblPlayerTurn.Text = "Game Over";

                }
                else if (pictureBox4.Tag == "O")
                {
                    lblWineer.Text = "Player2 Wins";
                    lblPlayerTurn.Text = "Game Over";
                }

            }
            else if (pictureBox7.Tag == pictureBox8.Tag && pictureBox8.Tag == pictureBox9.Tag)
            {
                if (pictureBox7.Tag == "X")
                {
                    lblWineer.Text = "Player1 Wins";
                    lblPlayerTurn.Text = "Game Over";

                }
                else if (pictureBox7.Tag == "O")
                {
                    lblWineer.Text = "Player2 Wins";
                    lblPlayerTurn.Text = "Game Over";

                }

            }
            else if (pictureBox1.Tag == pictureBox4.Tag && pictureBox4.Tag == pictureBox7.Tag)
            {
                if (pictureBox1.Tag == "X")
                {
                    lblWineer.Text = "Player1 Wins";
                    lblPlayerTurn.Text = "Game Over";
                }
                else if (pictureBox1.Tag == "O")
                {
                    lblWineer.Text = "Player2 Wins";
                    lblPlayerTurn.Text = "Game Over";

                }

            }
            else if (pictureBox2.Tag == pictureBox5.Tag && pictureBox5.Tag == pictureBox8.Tag)
            {
                if (pictureBox2.Tag == "X")
                {
                    lblWineer.Text = "Player1 Wins";
                    lblPlayerTurn.Text = "Game Over";

                }
                else if (pictureBox2.Tag == "O")
                {
                    lblWineer.Text = "Player2 Wins";
                    lblPlayerTurn.Text = "Game Over";
                }
                

            }
            else if (pictureBox3.Tag == pictureBox6.Tag && pictureBox6.Tag == pictureBox9.Tag)
            {
                if (pictureBox3.Tag == "X")
                {
                    lblWineer.Text = "Player1 Wins";
                    lblPlayerTurn.Text = "Game Over";

                }
                else if (pictureBox3.Tag == "O")
                {
                    lblWineer.Text = "Player2 Wins";
                    lblPlayerTurn.Text = "Game Over";
                }

            }
            else if (pictureBox1.Tag == pictureBox5.Tag && pictureBox5.Tag == pictureBox9.Tag)
            {
                if (pictureBox1.Tag == "X")
                {
                    lblWineer.Text = "Player1 Wins";
                    lblPlayerTurn.Text = "Game Over";

                }
                else if(pictureBox1.Tag == "O")
                {
                    lblWineer.Text = "Player2 Wins";
                    lblPlayerTurn.Text = "Game Over";

                }

            }
            else if (pictureBox3.Tag == pictureBox5.Tag && pictureBox5.Tag == pictureBox7.Tag)
            {
                if (pictureBox3.Tag == "X")
                {
                    lblWineer.Text = "Player1 Wins";
                    lblPlayerTurn.Text = "Game Over";

                }
                else if (pictureBox3.Tag == "O")
                {
                    lblWineer.Text = "Player2 Wins";
                    lblPlayerTurn.Text = "Game Over";
                    

                }

            }
            else if (pictureBox1.Tag != "question_mark" && pictureBox2.Tag != "question_mark" && pictureBox3.Tag != "question_mark" && pictureBox4.Tag != "question_mark" && pictureBox5.Tag != "question_mark" && pictureBox6.Tag != "question_mark" && pictureBox7.Tag != "question_mark" && pictureBox8.Tag != "question_mark" && pictureBox9.Tag != "question_mark")
            {
                lblWineer.Text = "Draw";
                lblPlayerTurn.Text = "Game Over";
              
            }

            Endgame();
        }

        void Endgame()
        {
            if (lblWineer.Text == "Player1 Wins")
            {
                MessageBox.Show("Player1 Wins");
            }
            else if (lblWineer.Text == "Player2 Wins")
            {
                MessageBox.Show("Player2 Wins");
            }
            else if (lblWineer.Text == "Draw")
            {
                MessageBox.Show("Draw");
            }
        }
        void UpdatePictureBox(PictureBox PB)
        {
            if (PB.Tag.ToString() == "question_mark")
            {
                if (lblPlayerTurn.Text == "Player1")
                {
                    PB.Image = Resources.X;
                    PB.Tag = "X";
                    lblPlayerTurn.Text = "Player2";
                }
                else
                {
                    PB.Image = Resources.O;
                    PB.Tag = "O";
                    lblPlayerTurn.Text = "Player1";
                }
            }
            else
            {
                MessageBox.Show("Invalid Move");
            }

            TestForWinner();
        }

        /*
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Tag.ToString() == "question_mark")
            {
                if (lblPlayerTurn.Text == "Player1")
                {
                    pictureBox1.Image = Resources.X;
                    pictureBox1.Tag = "X";
                    lblPlayerTurn.Text = "Player2";
                }
                else
                {
                    pictureBox1.Image = Resources.O;
                    pictureBox1.Tag = "O";
                    lblPlayerTurn.Text = "Player1";
                }
            }
            else
            {
                MessageBox.Show("Invalid Move");
            }

            TestForWinner();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Tag.ToString() == "question_mark")
            {
                if (lblPlayerTurn.Text == "Player1")
                {
                    pictureBox2.Image = Resources.X;
                    pictureBox2.Tag = "X";
                    lblPlayerTurn.Text = "Player2";
                }
                else
                {
                    pictureBox2.Image = Resources.O;
                    pictureBox2.Tag = "O";
                    lblPlayerTurn.Text = "Player1";
                }
            }
            else
            {
                MessageBox.Show("Invalid Move");
            }

            TestForWinner();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (pictureBox3.Tag.ToString() == "question_mark")
            {
                if (lblPlayerTurn.Text == "Player1")
                {
                    pictureBox3.Image = Resources.X;
                    pictureBox3.Tag = "X";
                    lblPlayerTurn.Text = "Player2";
                }
                else
                {
                    pictureBox3.Image = Resources.O;
                    pictureBox3.Tag = "O";
                    lblPlayerTurn.Text = "Player1";
                }
            }
            else
            {
                MessageBox.Show("Invalid Move");
            }

            TestForWinner();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (pictureBox4.Tag.ToString() == "question_mark")
            {
                if (lblPlayerTurn.Text == "Player1")
                {
                    pictureBox4.Image = Resources.X;
                    pictureBox4.Tag = "X";
                    lblPlayerTurn.Text = "Player2";
                }
                else
                {
                    pictureBox4.Image = Resources.O;
                    pictureBox4.Tag = "O";
                    lblPlayerTurn.Text = "Player1";
                }
            }
            else
            {
                MessageBox.Show("Invalid Move");
            }

            TestForWinner();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (pictureBox5.Tag.ToString() == "question_mark")
            {
                if (lblPlayerTurn.Text == "Player1")
                {
                    pictureBox5.Image = Resources.X;
                    pictureBox5.Tag = "X";
                    lblPlayerTurn.Text = "Player2";
                }
                else
                {
                    pictureBox5.Image = Resources.O;
                    pictureBox5.Tag = "O";
                    lblPlayerTurn.Text = "Player1";
                }
            }
            else
            {
                MessageBox.Show("Invalid Move");
            }

            TestForWinner();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (pictureBox6.Tag == "question_mark")
            {
                if (lblPlayerTurn.Text == "Player1")
                {
                    pictureBox6.Image = Resources.X;
                    pictureBox6.Tag = "X";
                    lblPlayerTurn.Text = "Player2";
                }
                else
                {
                    pictureBox6.Image = Resources.O;
                    pictureBox6.Tag = "O";
                    lblPlayerTurn.Text = "Player1";
                }
            }
            else
            {
                MessageBox.Show("Invalid Move");
            }

            TestForWinner();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (pictureBox7.Tag.ToString() == "question_mark")
            {
                if (lblPlayerTurn.Text == "Player1")
                {
                    pictureBox7.Image = Resources.X;
                    pictureBox7.Tag = "X";
                    lblPlayerTurn.Text = "Player2";
                }
                else
                {
                    pictureBox7.Image = Resources.O;
                    pictureBox7.Tag = "O";
                    lblPlayerTurn.Text = "Player1";
                }
            }
            else
            {
                MessageBox.Show("Invalid Move");
            }

            TestForWinner();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (pictureBox8.Tag.ToString() == "question_mark")
            {
                if (lblPlayerTurn.Text == "Player1")
                {
                    pictureBox8.Image = Resources.X;
                    pictureBox8.Tag = "X";
                    lblPlayerTurn.Text = "Player2";
                }
                else
                {
                    pictureBox8.Image = Resources.O;
                    pictureBox8.Tag = "O";
                    lblPlayerTurn.Text = "Player1";
                }
            }
            else
            {
                MessageBox.Show("Invalid Move");
            }

            TestForWinner();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            
            if (pictureBox9.Tag.ToString() == "question_mark")
            {
                if (lblPlayerTurn.Text == "Player1")
                {
                    pictureBox9.Image = Resources.X;
                    pictureBox9.Tag = "X";
                    lblPlayerTurn.Text = "Player2";
                }
                else
                {
                    pictureBox9.Image = Resources.O;
                    pictureBox9.Tag = "O";
                    lblPlayerTurn.Text = "Player1";
                }
            }
            else
            {
                MessageBox.Show("Invalid Move");
            }

            TestForWinner();

        }

        */

        private void pictureBox_Click(object sender, EventArgs e)
        {
            UpdatePictureBox((PictureBox)sender);
        }
    }
}
