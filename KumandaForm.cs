using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje2mfk
{
    public partial class KumandaForm : Form
    {
        public KumandaForm()
        {
            InitializeComponent();
            label3.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
            label3.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            label3.Show();
            label1.Hide();
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (BackColor == Color.Green)
            {
                pictureBox1.Hide();
                pictureBox2.Hide();
                pictureBox3.Show();
                pictureBox4.Hide();

                label1.Text = ("SAĞA GİDİYOR");
                label1.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (BackColor == Color.Green)
            {
                pictureBox1.Hide();
                pictureBox2.Hide();
                pictureBox3.Hide();
                pictureBox4.Show();
                label1.Text = ("DURDU");
                label1.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (BackColor == Color.Green)
            {
                pictureBox3.Hide();
                pictureBox2.Hide();
                pictureBox1.Show();
                pictureBox4.Hide();
                label1.Text = ("İLERİ GİDİYOR");
                label1.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (BackColor == Color.Green)
            {
                pictureBox1.Hide();
                pictureBox2.Show();
                pictureBox3.Hide();
                pictureBox4.Hide();

                label1.Text = ("SOLA GİDİYOR");
                label1.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void KumandaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
