using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje2mfk
{ 
    class ÖzellikEleman : IÖzellikler
    {
        string ad;
        string tanım;

        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }

        public string Tanım
        {
            get { return tanım; }
            set { tanım = value; }
        }

        public ÖzellikEleman(string ad,string tanım)
        {
            this.Ad = ad;
            this.Tanım = tanım;

        }
        public void Yaz()
        {
            //

        }
    }
}
