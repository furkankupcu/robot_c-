using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje2mfk
{
    class Özellikler : IÖzellikler
    {
        private string ad;

        public string Ad
        {
            get { return ad; }
            set { ad = value; }

        }

        private string tanım;

        public string Tanım
        {
            get { return tanım; }
            set { tanım = value; }
        }

        public Özellikler(string ad,string tanım)
        {
            this.Ad = ad ;
            this.Tanım= tanım;

        }
        
        List<IÖzellikler> nodlar = new List<IÖzellikler>();

        public void Ekle(IÖzellikler nod)
        {
            nodlar.Add(nod);

        }
        public void Yaz()
        {
            ////


            foreach(IÖzellikler nod in nodlar)
            {
                nod.Yaz();
            }
            
        }
  
    }
}
