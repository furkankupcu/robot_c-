using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje2mfk
{
    class Kumanda
    {
        public const int KomutSayısı = 6;

        IKomutlar[] Komutlars;


        public Kumanda()
        {
            IKomutlar komutYok = new KomutYok();
            Komutlars = new IKomutlar[KomutSayısı];

            for(int i = 0; i < KomutSayısı; i++)
            {
                Komutlars[i] = komutYok;
            }
        }

        public void yürüTusunaBas(int yuva)
        {
            Komutlars[yuva].Yürüt();
        }

        public void çalıştırTusunaBas(int yuva)
        {
            Komutlars[yuva].Yürüt();
        }
        public void durTusunaBas(int yuva)
        {
            Komutlars[yuva].Yürüt();
        }
        public void sağaDönTusunaBas(int yuva)
        {
            Komutlars[yuva].Yürüt();
        }
        public void solaDönTusunaBas(int yuva)
        {
            Komutlars[yuva].Yürüt();
        }
        public void kapatTusunaBas(int yuva)
        {
            Komutlars[yuva].Yürüt();
        }
    }
}
