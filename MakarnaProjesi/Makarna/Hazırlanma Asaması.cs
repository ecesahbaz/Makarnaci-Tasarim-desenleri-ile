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
    public partial class Hazırlanma_Asaması : Form
    {
        string MakarnaD;
        public Hazırlanma_Asaması(string MakarnaD)
        {
            InitializeComponent();
            this.MakarnaD = MakarnaD;
            
        }
       
        

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = MakarnaD;
            progressBar1.Minimum = 0;
             progressBar1.Maximum = 10000000;          
              for ( int i =0; i<= 10000000; i++)
              {
                    progressBar1.Value = i;
              }
              if(progressBar1.Maximum==10000000)
              {
                    label1.Text = "Makarnanız Hazır";
              }
            
        }
       private void label1_Click(object sender, EventArgs e)
       {

       }
        private void Hazırlanma_Asaması_Load(object sender, EventArgs e)
        {
          
        }
    }
}
