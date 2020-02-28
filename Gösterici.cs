using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje2mfk
{
    class Gösterici
    {
        Özellikler özellikler;

        public Gösterici(Özellikler özellikler)
        {
            this.özellikler = özellikler;
        }

        public void Yaz()
        {
            özellikler.Yaz();
        }
    }
}
