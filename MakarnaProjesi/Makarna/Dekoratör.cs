//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Makarna
//{
//   public abstract  class Siparis
//   {
//     public abstract   double fiyat();
//   }

//    class DomatesSoslu:Siparis
//    {
//        public override double fiyat()
//        {
//            return 5;
//        }
//    }
//    class Bolonez:Siparis
//    {
//        public override double fiyat()
//        {
//            return 5;
//        }
//    }
//    class Kıymalı : Siparis
//    {
//        public override double fiyat()
//        {
//            return 5;
//        }
//    }
//    class KremalıTavuklu : Siparis
//    {
//        public override double fiyat()
//        {
//            return 5;
//        }
//    }
//    public abstract class EkstraUrunler : Siparis
//    {
//        protected Siparis örnek; // protected tanımlanan öğe sadece tanımlandığı classta ve o classtan türetilmiş diğer classlarda kullanılabilir
//    }
//    class Kasar : EkstraUrunler
//    {
//        public Kasar(Siparis örnek)
//        {
//            this.örnek = örnek;
//        }
//        public override double fiyat()
//        {
//            return this.örnek.fiyat() + 20;
//        }
//    }
//    class Mısır : EkstraUrunler
//    {
//        public Mısır(Siparis örnek)
//        {
//            this.örnek = örnek;
//        }
//        public override double fiyat()
//        {
//            return this.örnek.fiyat() + 20;
//        }
//    }
//    class KaraBiber : EkstraUrunler
//    {
//        public KaraBiber(Siparis örnek)
//        {
//            this.örnek = örnek;
//        }
//        public override double fiyat()
//        {
//            return this.örnek.fiyat() + 20;
//        }
//    }
//    class Tuz : EkstraUrunler
//    {
//        public Tuz(Siparis örnek)
//        {
//            this.örnek = örnek;
//        }
//        public override double fiyat()
//        {
//            return this.örnek.fiyat() + 20;
//        }
//    }
//}
