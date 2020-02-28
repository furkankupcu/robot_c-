using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje2mfk.Composite
{
    public interface IMakineler
    {
        string Ad { get; set; }
        string Tür { get; set; }
        void DetayGöster();

    }
}
    /// <summary>
   
   
  //  public class Makine : IMakineler
   // {

  //      public string Ad { get; set; }
  //      public string Tür { get; set; }

   //     public List<IMakineler> makinelers;

  //      public Makine(string ad,string tür)
   //     {
   //         this.Ad = ad;
    //        this.Tür = tür;
   //         makinelers = new List<IMakineler>();

    //    }

    //   public void Ekle(IMakineler makineler)
   //     {
   //         makinelers.Add(makineler);

   //     }

      //  public void Sil(IMakineler makineler)
   //     {

    //        makinelers.Add(makineler);
    //    }

    //    public void DetayGöster()
    //    {
    //        foreach (var makineler in makinelers)
    //        {
                //
     //       }
     //   }

     //   public class LeafMakine : IMakineler
     //   {
     //       public string Ad { get; set; }
     //       public string Tür { get; set; }

     //       public LeafMakine(string ad, string tür)
      //      {
      //          this.Ad = ad;
      //          this.Tür = tür;
      //      }

      //      public void DetayGöster()
      //      { 
                //
      //      }

      //  }
        /// </summary>
   // }
//}























