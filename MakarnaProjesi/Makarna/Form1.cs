using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Makarna
{
    public partial class Form1 : Form
    {
        SimpleRemoteControl remote = new SimpleRemoteControl();
        Gorevler gorevler = new Gorevler();
        IMakarnalar _makarna;
        

        //Siparis fiyat;
        //Siparis sonfiyat;
        public Form1()
        {
            InitializeComponent();
            //Console.WriteLine("**KIYMALI MAKARNA**");
            //_makarna = new Kıymalı();
            //_makarna.PrepareRecipe();
            //this.fiyat = fiyat;
            //label2.Text = fiyat.fiyat().ToString() + "TL";
        }

        public void Hazırla(string detay)
        {
            Hazırlanma_Asaması sayfa = new Hazırlanma_Asaması(detay);
            sayfa.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SimpleRemoteControl remote = new SimpleRemoteControl();
            //Gorevler gorevler= new Gorevler();
            //KasarEkleCommand kasarekle = new KasarEkleCommand(gorevler);
            //remote.setCommand(kasarekle);
            //MessageBox.Show(gorevler.KasarEkle());
            //sonfiyat = new Kasar(fiyat);
            //label2.Text = (sonfiyat.fiyat() + 2).ToString() + " TL";
            //label2.Show();
            //remote.buttonWasPressed();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //MısırEkleCommand mısırekle = new MısırEkleCommand(gorevler);
            //remote.setCommand(mısırekle);
            //MessageBox.Show(gorevler.MısırEkle());
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //TuzEkleCommand tuzekle = new TuzEkleCommand(gorevler);
            //remote.setCommand(tuzekle);
            //MessageBox.Show(gorevler.TuzEkle());
        }
        private void button4_Click(object sender, EventArgs e)
        {
            //KaraBiberEkleCommand karabiberekle = new KaraBiberEkleCommand(gorevler);
            //remote.setCommand(karabiberekle);
            //MessageBox.Show(gorevler.KaraBiberEkle());          
        }
        private void label5_Click(object sender, EventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }
        private void kasarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KasarEkleCommand kasarekle = new KasarEkleCommand(gorevler);
            remote.setCommand(kasarekle);
            MessageBox.Show(gorevler.KasarEkle());
        }

        private void mısırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MısırEkleCommand mısırekle = new MısırEkleCommand(gorevler);
            remote.setCommand(mısırekle);
            MessageBox.Show(gorevler.MısırEkle());
        }

        private void tuzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TuzEkleCommand tuzekle = new TuzEkleCommand(gorevler);
            remote.setCommand(tuzekle);
            MessageBox.Show(gorevler.TuzEkle());
        }

        private void karaBiberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KaraBiberEkleCommand karabiberekle = new KaraBiberEkleCommand(gorevler);
            remote.setCommand(karabiberekle);
            MessageBox.Show(gorevler.KaraBiberEkle());
        }

        private void siparişVerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SiparisForm sayfa = new SiparisForm();
            sayfa.Show();
            this.Hide();
        }

        private void siparişVerToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void ekstraÜrünlerimizToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }




        private void Form1_Load(object sender, EventArgs e) //main gibi
        {
        }

        private void domatesSosluToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _makarna = new DomatesSoslu();
            Hazırla(_makarna.PrepareRecipe());
        }

        private void makarnaÇeşitlerimizToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bolonezToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _makarna = new Bolonez();
            Hazırla(_makarna.PrepareRecipe());
        }

        private void kıymalıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _makarna = new Kıymalı();
            Hazırla(_makarna.PrepareRecipe());
        }

        private void kremalıTavukluToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _makarna = new KremalıTavuklu();
            Hazırla(_makarna.PrepareRecipe());
        }

        private void salatalarımızToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void akdenizSalataToolStripMenuItem_Click(object sender, EventArgs e)
        {
           


        }

        //private void button1_Click_1(object sender, EventArgs e)
        //{
        //    progressBar1.Minimum = 0;
        //    progressBar1.Maximum = 10000000;          
        //    for ( int i =0; i<= 10000000; i++)
        //    {
        //        progressBar1.Value = i;
        //    }
        //    if(progressBar1.Maximum==10000000)
        //    {
        //        label1.Text = "Makarnanız Hazır";
        //    }

        //}

        //private void progressBar1_Click(object sender, EventArgs e)
        //{

        //}

    }
}
