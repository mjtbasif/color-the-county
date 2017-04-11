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
    public partial class Form4 : Form
    {
        public Form4()
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

            pictureBox4.Controls.Add(pictureBox5);
            pictureBox5.Location = new Point(0, 0);
            pictureBox5.BackColor = Color.Transparent;

            pictureBox5.Controls.Add(pictureBox6);
            pictureBox6.Location = new Point(0, 0);
            pictureBox6.BackColor = Color.Transparent;

            getColors();
        }
        void getColors()
        {
            int v = 5;
            int[,] adj = new int[,] {
    {-2,1,-2,3,4},
    {0,-2,2,-2,-2},
    {-2,1,-2,3,-2},
    {0,-2,2,-2,4},
    {0,-2,-2,3,-2},
};
            int[] colors = new int[] { 0, -1, -1, -1, -1};
            int[] check = new int[] {0,0,0,0,0};

            for (int i = 1; i < v; i++)
            {
                for (int x = 0; x < v; x++)
                {
                    int p = adj[i, x];
                    if (p > -2)
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
                    if (p > -2)
                        if (colors[p] != -1)
                        {
                            check[colors[p]] = 0;
                        }
                }
            }

            button1.Text = "  BARISAL has Color: " + colors[0].ToString() + "\n";
            button2.Text = "  JHALOKATHI has Color: " + colors[1].ToString() + "\n";
            button3.Text = "  BARGUNA has Color: " + colors[2].ToString() + "\n";
            button4.Text = "  PATUAKHALI has Color: " + colors[3].ToString() + "\n";
            button5.Text = "  BHOLA has Color: " + colors[4].ToString() + "\n";

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form13 f13 = new Form13();
            f13.Show();
            this.Close();
        }
    }
}
