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
    public partial class Form2 : Form
    {
        int[] colors = new int[] { 0, -1, -1, -1, -1, -1, -1 };
        public Form2()
        {
            InitializeComponent();

            pictureBox1.Controls.Add(pictureBox2);
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.BackColor = Color.Transparent;

            pictureBox2.Controls.Add(pictureBox3);
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.BackColor = Color.Transparent;

            pictureBox3.Controls.Add(pictureBox4);
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.BackColor = Color.Transparent;

            getColors();
        }
        void getColors()
        {
            int v = 4;
            int[,] adj = new int[,] { {-2,1,2,3},{0,-2,2,3},{0,1,-2,3},{0,1,2,-2}}; 
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

            button1.Text = "  HABIGANJ has Color: " + colors[0].ToString() + "\n";
            button2.Text = "  MOULAVIBAZAR has Color: " + colors[1].ToString() + "\n";
            button3.Text = "  SUNAMGANJ has Color: " + colors[2].ToString() + "\n";
            button4.Text = "  SYLHET has Color: " + colors[3].ToString() + "\n";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form2 f2 = new Form2();
            //f2.Show();
            //this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Form2 f2 = new Form2();
           // f2.Show();
            //this.Close();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            f12.Show();
            this.Close();
        }
    }
}
