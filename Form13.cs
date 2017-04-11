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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Greetings!\nThis application was developed for the course project of \nCSE205: Discrete Mathematics.\nThanks to our course instructor Tanni Mitra for assigning us to this project.\n\nDeveloped by,\nMd. Mujtaba Asif\nRizvi Rahman Omee\nShah Mohammad Nuruddin\n", "About Us", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
