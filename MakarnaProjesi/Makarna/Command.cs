using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makarna
{
    #region KomutDeseni
    public interface ICommand
    {
        void execute();
    }
    public  class Gorevler //receiver:asıl işlemin yapıldığı sınıf
    {
        public Gorevler()
        {
        }
        public string KasarEkle()
        {
           return "kaşar eklendi";
        }
        public string TuzEkle()
        {
            return "tuz eklendi";
        }
        public string KaraBiberEkle()
        {
            return "karabiber eklendi";
        }
        public string MısırEkle()
        {
            return "mısır  eklendi";
        }
       
    }
    //kasarekle sınıf
    public class KasarEkleCommand : ICommand
    {
        Gorevler gorevler;
        public KasarEkleCommand(Gorevler gorevler)
        {
            this.gorevler = gorevler;
        }
        public void execute()
        {
            gorevler.KasarEkle();
        }
    }
   
    //tuzekle
    public class TuzEkleCommand : ICommand
    {
        Gorevler gorevler;
        public TuzEkleCommand(Gorevler gorevler)
        {
            this.gorevler = gorevler;
        }
        public void execute()
        {
            gorevler.TuzEkle();
        }
    }
    //karabiber
    public class KaraBiberEkleCommand : ICommand
    {
        Gorevler gorevler;
        public KaraBiberEkleCommand(Gorevler gorevler)
        {
            this.gorevler = gorevler;
        }
        public void execute()
        {
            gorevler.KaraBiberEkle();
        }
    }
    //mısır
    public class MısırEkleCommand : ICommand
    {
        Gorevler gorevler;
        public MısırEkleCommand(Gorevler gorevler)
        {
            this.gorevler = gorevler;
        }
        public void execute()
        {
            gorevler.MısırEkle();
        }
    }
    //ınvoker sınıfı: komut sınıflarını çağırır
    public class SimpleRemoteControl
    {
        ICommand slot;

        public SimpleRemoteControl() { }

        public void setCommand(ICommand command)
        {
            slot = command;
        }

        public void buttonWasPressed()
        {
            slot.execute();
        }
    }
    #endregion
}
