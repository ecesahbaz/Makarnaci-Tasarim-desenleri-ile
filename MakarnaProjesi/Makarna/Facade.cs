using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Makarna
{
   
   class Malzemeler
    {
        public string salatalik { get; set; }
        public string marul { get; set; }
        public string domates { get; set; }
        public string tavuk { get; set; }
        public string tonbaligi { get; set; }
    }
    class Soslar
    {
        public string sarimsak { get; set; }
        public string kekik { get; set; }
        public string limon { get; set; }
    }
    
    class SalataOlusturucu
    {
        public Malzemeler malzeme { get; set; }
        public Soslar sos { get; set; }
        public SalataOlusturucu (Malzemeler malzeme, Soslar sos)
        {
            this.malzeme = malzeme;
            this.sos = sos;
        }
        
    }
    class Salata
    {
        public Salata(Malzemeler malzeme, Soslar sos)
        {
            Console.WriteLine("malzeme marul = {malzeme.marul}");
            Console.WriteLine("malzeme domates = {malzeme.domates}");
            Console.WriteLine("malzeme salatalık = {malzeme.salatalık}");
            Console.WriteLine("malzeme tavuk = {malzeme.tavuk}");
            Console.WriteLine("malzeme tonbaligi = {malzeme.tonbaligi}");
            Console.WriteLine("sos sarimsak = {sos.sarimsak}");
            Console.WriteLine("sos kekik = {sos.kekik}");
            Console.WriteLine("sos limon = {sos.limon}");



        }
    }
    class FacadeUretici
    {
        Malzemeler malzeme;
        Soslar sos;
        SalataOlusturucu olustur;
        public FacadeUretici()
        {
            malzeme = new Malzemeler() {};
            sos = new Soslar() {};
            olustur = new SalataOlusturucu (malzeme, sos);
                
        }
       
    }
    
   

}
