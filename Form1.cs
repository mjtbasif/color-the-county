using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalCTC
{
    public partial class Form1 : Form
    {
        int[] colors = new int[] { 0, -1, -1, -1, -1, -1, -1 };
        public Form1()
        {
            InitializeComponent();
            //CTG Transparent Over Dhaka
            pictureBox1.Controls.Add(pictureBox2);
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.BackColor = Color.Transparent;

            //Rajshahi Transparent Over CTG
            pictureBox2.Controls.Add(pictureBox3);
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.BackColor = Color.Transparent;

            //Sylhet Transparent Over Rajshahi
            pictureBox3.Controls.Add(pictureBox4);
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.BackColor = Color.Transparent;

            //Khulna Transparent Over Sylhet
            pictureBox4.Controls.Add(pictureBox5);
            pictureBox5.Location = new Point(0, 0);
            pictureBox5.BackColor = Color.Transparent;

            //Rangpur Transparent Over Khulna
            pictureBox5.Controls.Add(pictureBox6);
            pictureBox6.Location = new Point(0, 0);
            pictureBox6.BackColor = Color.Transparent;

            //Barishal Transparent Over Rangpur
            pictureBox6.Controls.Add(pictureBox7);
            pictureBox7.Location = new Point(0, 0);
            pictureBox7.BackColor = Color.Transparent;

            getColors();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        void getColors()
        {
            int v = 7;
            int[,] adj = new int[,] { { -2, 1, 2, 3, 4, 5, 6 }, { 0, -2, -2, 3, -2, -2, 6 }, { 0, -2, -2, -2, 4, 5, -2 }, { 0, 1, -2, -2, -2, -2, -2 }, { 0, -2, 2, -2, -2, -2, 6 }, { 0, -2, 2, -2, -2, -2, -2 }, { 0, 1, -2, -3, 4, -2, -2 } };
            int[] colors = new int[] { 0, -1, -1, -1, -1, -1, -1 };
            int[] check = new int[] { 0, 0, 0, 0, 0, 0, 0 };

            for (int i = 1; i < v; i++)
            {
                for (int x = 0; x < v; x++)
                {
                    int p = adj[i, x];
                    if (p >= 0)
                        if (colors[p] != -1)
                        {
                            check[colors[p]] = 1;
                        }
                }

                int k;
                for (k = 0; k < v; k++)
                {
                    if (check[k] == 0)
                    {
                        break;
                    }
                }
                colors[i] = k;

                for (int x = 0; x < v; x++)
                {
                    int p = adj[i, x];
                    if (p >= 0)
                        if (colors[p] != -1)
                        {
                            check[colors[p]] = 0;
                        }
                }
            }

            button1.Text = "  DHAKA has Color: " + colors[0].ToString() + "\n";
            button2.Text = "  SYLHET has Color: " + colors[1].ToString() + "\n";
            button3.Text = "  RAJSHAHI has Color: " + colors[2].ToString() + "\n";
            button4.Text = "  RANGPUR has Color: " + colors[3].ToString() + "\n";
            button5.Text = "  CHITTAGONG has Color: " + colors[4].ToString() + "\n";
            button6.Text = "  KHULNA has Color: " + colors[5].ToString() + "\n";
            button7.Text = "  BARISHAL has Color: " + colors[6].ToString() + "\n";
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form2 f2 = new Form2();
            //f2.Show();
            //this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            //this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Greetings!\nThis application was developed for the course project of \nCSE205: Discrete Mathematics.\nThanks to our course instructor Tanni Mitra for assigning us to this project.\n\nDeveloped by,\nMd. Mujtaba Asif\nRizvi Rahman Omee\nShah Mohammad Nuruddin\n","About Us",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bangladeshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
        }

        private void dhakaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            f10.Show();
        }

        private void chittagongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();
            f11.Show();
        }

        private void sylhetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            f12.Show();
        }

        private void barishalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form13 f13 = new Form13();
            f13.Show();
        }

        private void rangpurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form14 f14 = new Form14();
            f14.Show();
        }

        private void rajshahiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form15 f15 = new Form15();
            f15.Show();
        }

        private void khulnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form16 f16 = new Form16();
            f16.Show();
        }

        private void dhakaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void chittagongToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
        }

        private void sylhetToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void rangpurToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void barisalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void rajshahiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
        }

        private void khulnaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
        }

        private void bangladeshToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
        }
    }
}
