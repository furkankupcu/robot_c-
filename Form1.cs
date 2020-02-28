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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for(int i=0;i<=100;i++)
                {
                progressBar1.Value = i;
                if (progressBar1.Value == 100)
                {
                    timer1.Stop();
                    
                    MessageBox.Show("Üretim Yapılmıştır");
                   
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FacadeÜretici uretici = new FacadeÜretici();
            uretici.RobotUret();

            timer1.Start();
        }

        private void çeşitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kumandaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Close();
            KumandaForm f2 = new KumandaForm();
            f2.Show();
        }

        private void özelliklerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Close();
            ÖzellikFormu f2 = new ÖzellikFormu();
            f2.Show();
        }

        private void çeşitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Close();
            ÇeşitForm f2 = new ÇeşitForm();
            f2.Show();
        }
    }
}
