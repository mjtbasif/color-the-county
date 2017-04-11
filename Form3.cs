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
    public partial class Form3 : Form
    {
       
        public Form3()
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

            pictureBox8.Controls.Add(pictureBox9);
            pictureBox9.Location = new Point(0, 0);
            pictureBox9.BackColor = Color.Transparent;

            pictureBox9.Controls.Add(pictureBox10);
            pictureBox10.Location = new Point(0, 0);
            pictureBox10.BackColor = Color.Transparent;

            pictureBox10.Controls.Add(pictureBox11);
            pictureBox11.Location = new Point(0, 0);
            pictureBox11.BackColor = Color.Transparent;

            pictureBox11.Controls.Add(pictureBox12);
            pictureBox12.Location = new Point(0, 0);
            pictureBox12.BackColor = Color.Transparent;

            pictureBox12.Controls.Add(pictureBox13);
            pictureBox13.Location = new Point(0, 0);
            pictureBox13.BackColor = Color.Transparent;

            pictureBox13.Controls.Add(pictureBox14);
            pictureBox14.Location = new Point(0, 0);
            pictureBox14.BackColor = Color.Transparent;

            pictureBox14.Controls.Add(pictureBox15);
            pictureBox15.Location = new Point(0, 0);
            pictureBox15.BackColor = Color.Transparent;

            pictureBox15.Controls.Add(pictureBox16);
            pictureBox16.Location = new Point(0, 0);
            pictureBox16.BackColor = Color.Transparent;

            pictureBox16.Controls.Add(pictureBox17);
            pictureBox17.Location = new Point(0, 0);
            pictureBox17.BackColor = Color.Transparent;

            getColors();
        }
        void getColors()
        {
            int v = 17;
            int[,] adj = new int[,] {
    {-2,1,-2,3,-2,-2,-2,-2,8,-2,-2,-2,12,13,-2,15,-2},
    {0,-2,2,3,-2,-2,-2,-2,8,-2,-2,-2,-2,-2,-2,-2,-2},
    {-2,1,-2,-2,4,-2,-2,-2,8,-2,-2,-2,-2,-2,-2,-2,-2},
    {0,1,-2,-2,-2,-2,6,7,-2,-2,-2,-2,-2,-2,-2,-2,-2},
    {-2,-2,2,-2,-2,5,-2,-2,8,9,-2,-2,-2,-2,-2,-2,-2},
    {-2,-2,-2,-2,4,-2,-2,-2,-2,9,-2,-2,-2,-2,-2,-2,-2},
    {-2,-2,-2,3,-2,-2,-2,7,-2,-2,-2,-2,-2,-2,-2,-2,-2},
    {-2,-2,-2,3,-2,-2,6,-2,-2,-2,-2,-2,-2,-2,-2,-2,16},
    {0,1,-2,-2,4,-2,-2,-2,-2,9,-2,-2,12,-2,-2,-2,-2},
    {-2,-2,-2,-2,4,5,-2,-2,8,-2,10,11,12,-2,-2,-2,-2},
    {-2,-2,-2,-2,-2,-2,-2,-2,-2,9,-2,11,-2,-2,-2,-2,-2},
    {-2,-2,-2,-2,-2,-2,-2,-2,-2,9,10,-2,12,-2,-2,-2,-2},
    {-2,-2,-2,-2,-2,-2,-2,-2,8,9,-2,11,-2,13,-2,-2,-2},
    {0,-2,-2,-2,-2,-2,-2,-2,-2,-2,-2,-2,12,-2,14,15,-2},
    {-2,-2,-2,-2,-2,-2,-2,-2,-2,-2,-2,-2,-2,13,-2,15,-2},
    {0,-2,-2,-2,-2,-2,-2,-2,-2,-2,-2,-2,-2,13,14,-2,16},
    {-2,-2,-2,-2,-2,-2,-2,7,-2,-2,-2,-2,-2,-2,-2,15,-2}
    };
            int[] colors = new int[] { 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1,-1};
            int[] check = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,0,0,0 };

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
            button2.Text = "  NARAYANGANJ has Color: " + colors[1].ToString() + "\n";
            button3.Text = "  NARSHINGDI has Color: " + colors[2].ToString() + "\n";
            button4.Text = "  MUNSHIGANJ has Color: " + colors[3].ToString() + "\n";
            button5.Text = "  KISHOREGONJ has Color: " + colors[4].ToString() + "\n";
            button6.Text = "  NETROKONA has Color: " + colors[5].ToString() + "\n";
            button7.Text = "  SHARIATPUR has Color: " + colors[6].ToString() + "\n";
            button8.Text = "  MADARIPUR has Color: " + colors[7].ToString() + "\n";
            button9.Text = "  GAZIPUR has Color: " + colors[8].ToString() + "\n";
            button10.Text = "  MYMENSINGH has Color: " + colors[9].ToString() + "\n";
            button11.Text = "  SHERPUR has Color: " + colors[10].ToString() + "\n";
            button12.Text = "  JAMALPUR has Color: " + colors[11].ToString() + "\n";
            button13.Text = "  TANGAIL has Color: " + colors[12].ToString() + "\n";
            button14.Text = "  MANIKGANJ has Color: " + colors[13].ToString() + "\n";
            button15.Text = "  RAJBARI has Color: " + colors[14].ToString() + "\n";
            button16.Text = "  FARIDPUR has Color: " + colors[15].ToString() + "\n";
            button17.Text = "  GOPALGANJ has Color: " + colors[16].ToString() + "\n";

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

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            f10.Show();
            this.Close();
        }
    }
}
