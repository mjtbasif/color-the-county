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
    public partial class Form5 : Form
    {
        public Form5()
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

            pictureBox6.Controls.Add(pictureBox7);
            pictureBox7.Location = new Point(0, 0);
            pictureBox7.BackColor = Color.Transparent;

            pictureBox7.Controls.Add(pictureBox8);
            pictureBox8.Location = new Point(0, 0);
            pictureBox8.BackColor = Color.Transparent;

            getColors();
        }
        void getColors()
        {
            int v = 8;
            int[,] adj = new int[,] {
    {-2,1,2,3,-2,-2,-2,-2},
    {0,-2,-2,3,-2,-2,-2,-2},
    {0,-2,-2,3,4,5,-2,-2},
    {0,1,2,-2,-2,5,6,-2},
    {-2,-2,2,-2,-2,5,-2,7},
    {-2,-2,2,3,4,-2,6,7},
    {-2,-2,-2,3,-2,5,-2,7},
    {-2,-2,-2,-2,4,5,6,-2}
};
            int[] colors = new int[] { 0, -1, -1, -1, -1, -1, -1, -1};
            int[] check = new int[] { 0, 0, 0, 0, 0, 0, 0, 0 };

            for (int i = 1; i < v; i++)
            {
                for (int x = 0; x < v; x++)
                {
                    int p = adj[i, x];
                    if (p !=-2)
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
                    if (p != -2)
                        if (colors[p] != -1)
                        {
                            check[colors[p]] = 0;
                        }
                }
            }

            button1.Text = "  PANCHAGARH has Color: " + colors[0].ToString() + "\n";
            button2.Text = "  THAKURGAO has Color: " + colors[1].ToString() + "\n";
            button3.Text = "  NILPHAMARI has Color: " + colors[2].ToString() + "\n";
            button4.Text = "  DINAJPUR has Color: " + colors[3].ToString() + "\n";
            button5.Text = "  LALMONIRHAT has Color: " + colors[4].ToString() + "\n";
            button6.Text = "  RANGPUR has Color: " + colors[5].ToString() + "\n";
            button7.Text = "  GAIBANDHA has Color: " + colors[6].ToString() + "\n";
            button8.Text = "  KURIGRAM has Color: " + colors[7].ToString() + "\n";

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form14 f14 = new Form14();
            f14.Show();
            this.Close();
        }
    }
}
