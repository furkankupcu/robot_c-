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
    public partial class ÖzellikFormu : Form
    {
        public ÖzellikFormu()
        {
            InitializeComponent();
        }

        private void ÖzellikFormu_Load(object sender, EventArgs e)
        {
            Özellikler özellikler = new Özellikler("Ana Özellikler", "Genel");

            ÖzellikEleman e1 = new ÖzellikEleman("Payload","Yük Taşıma");
            ÖzellikEleman e2 = new ÖzellikEleman("Güç","Batarya");
            ÖzellikEleman e3 = new ÖzellikEleman("Hareket","Hidrolik ve Elektrik");
            ÖzellikEleman e4 = new ÖzellikEleman("Algı","Derin Kamera");
            ÖzellikEleman e5 = new ÖzellikEleman("Eklemler","Hareket Kabiliyeti");

            özellikler.Ekle(e1);
            özellikler.Ekle(e2);
            özellikler.Ekle(e3);
            özellikler.Ekle(e4);
            özellikler.Ekle(e5);

            Gösterici gösterici = new Gösterici(özellikler);


            gösterici.Yaz();

            for (int i=1; i< 6;i++)
            {
                List<IÖzellikler> özelliklers 

                listBox1.Items.AddRange();
            }
       
        }
    }
}
