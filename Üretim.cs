using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje2mfk
{
   public class Üretim
   {

        class Kolüret
        {
            public int kol { get; set; }
        }

        class AyakÜret
        {
            public int ayak { get; set; }
        }

        class BedenÜret
        {
            public int beden { get; set; }
        }
        
       class KafaÜret
        {
            public int kafa { get; set; }
        }

        class RobotOluştur
        {
            public Kolüret kol { get; set; }
            public AyakÜret ayak { get; set; }
            public BedenÜret beden { get; set; }
            public KafaÜret kafa { get; set; }
            public RobotOluştur(Kolüret kol,AyakÜret ayak,BedenÜret beden,KafaÜret kafa)
            {
                this.kol = kol;
                this.ayak = ayak;
                this.beden = beden;
                this.kafa = kafa;

            }

            public Rbt Oluştur(Çeşit çeşit)
            {
                return new Rbt(kol, ayak, beden, kafa);
            }
        }
        class Rbt
        {
            public Rbt(Kolüret kol, AyakÜret ayak, BedenÜret beden, KafaÜret kafa)
            {
                ///
            }
        }

        enum Çeşit
        {
            Atlas,
            SpotMini,
            Spot,
            Handle,
        }
       class FacadeÜretici
        {
            public Kolüret kol;
            public AyakÜret ayak;
            public BedenÜret beden;
            public KafaÜret kafa;
            RobotOluştur olustur;

          public FacadeÜretici()
            {
                kol = new Kolüret() { kol=1 };
                ayak = new AyakÜret() { ayak = 1 };
                beden = new BedenÜret() { beden = 1 };
                kafa = new KafaÜret() { kafa = 1 };
                olustur = new RobotOluştur(kol, ayak, beden, kafa);

            }

            public void RobotÜret()
            {
                Rbt üretilenRbt = olustur.Oluştur(Çeşit.Atlas);
            }
        }
   }
}
