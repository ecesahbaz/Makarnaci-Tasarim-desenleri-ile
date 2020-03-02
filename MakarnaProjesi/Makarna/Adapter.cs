using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makarna
{
    //#region AdapterDeseni1
    //public interface IAdres
    //{
    //    string SehirAl();
    //    string SemtAl();
    //    string AcıkAdresAl();
    //}
    //public class İsAdresi : IAdres
    //{
    //    public string SehirAl()
    //    {
    //        return "İstanbul";
    //    }
    //    public string SemtAl()
    //    {
    //        return "Bahçelievler";
    //    }
    //    public string AcıkAdresAl()
    //    {
    //        return "x.mahalle y.cadde no:z";
    //    }
    //}
    //public class Musterı
    //{
    //    private string cepno;
    //    private string acıkadres;
    //    private string sehir;
    //    private string semt;
    //    private string isim;
    //    public Musterı(string cepno, string acıkadres, string sehir, string semt,string isim)
    //    {
    //        this.cepno = cepno;
    //        this.acıkadres = acıkadres;
    //        this.sehir = sehir;
    //        this.semt = semt;
    //        this.isim = isim;
    //    }
    //    public string alcepno()
    //    {
    //        return cepno;
    //    }
    //    public string alisim()
    //    {
    //        return isim;
    //    }

    //    public string AcıkAdresAl()
    //    {
    //        return acıkadres;
    //    }
    //    public string SehirAl()
    //    {
    //        return sehir;
    //    }
    //    public string SemtAl()
    //    {
    //        return semt;
    //    }
    //}
    //public class MusterıFaturaAdaptörü : IAdres
    //{
    //    private Musterı musteri;
    //    public MusterıFaturaAdaptörü(Musterı musteri)
    //    {
    //        this.musteri = musteri;
    //    }
    //    public string AcıkAdresAl()
    //    {
    //        return musteri.AcıkAdresAl();
    //    }
    //    public string SemtAl()
    //    {
    //        return musteri.SemtAl();
    //    }
    //    public string SehirAl()
    //    {
    //        return musteri.SemtAl();
    //    }
    //}
    //#endregion
    #region Adapter2
    //public class XBankPosReader
    //{
    //     public string ReadFromCard()
    //     {
    //         return "Ödendi";
    //     }
    //}
    // public interface ICardReaderAdapter
    // {
    //     string ReadCardData();
    // }
    // public class XBankCardReaderAdapter:ICardReaderAdapter
    // {
    //    public string ReadCardData()
    //     {
    //         XBankPosReader posReader = new XBankPosReader();
    //         return posReader.ReadFromCard();
    //     }
    // }
    #endregion
    public class Adapter: ITarget //nakit ile ödeme
    {
        public string Odeme()
        {
            return "Nakit Ödeme İle Siparişiniz Alınmıştır";
        }
    }
    public interface ITarget
    {
        string Odeme ();
    }
    public class Adaptee
    {
        public string Odeme()
        {
            Adapter adapter = new Adapter();
            return adapter.Odeme();
        }
    }
}
