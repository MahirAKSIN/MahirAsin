using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form03_TemelKontroller
{
    public partial class Form5 : Form
    {
        int sayac ;
        Random rnd = new Random();
        int rSayi = 0;
        public Form5()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            rSayi = rnd.Next(1, 100);
            lbl_sayi.Text = rSayi.ToString();
        }
        int s1 = 0;
        private void lbl_sayi_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {

                select(rdb_cift, rdb_tek);
                sayac =rSayi+sayac;
                
                label1.Text = sayac.ToString();
            }
            else
                timer1.Start();

        }
        
      
        
        void select(RadioButton rdb1, RadioButton rdb2)
        {
            if (rdb1.Checked == true)
            {
                timer1.Stop();

                if (rSayi % 2 == 0)
                {
                    MessageBox.Show("Kazandiniz...");
                  
                }
                else
                    MessageBox.Show("Kaybetiniz...");
            }
            else if (rdb2.Checked == true)
            {

                timer1.Stop();

                if (rSayi % 2 == 1)
                {
                    MessageBox.Show("Kazandiniz...");
                   
                }
                else
                    MessageBox.Show("Kaybetiniz...");

            }


        }


        private void Form5_Load(object sender, EventArgs e)
        {
            rdb_cift.Enabled = true;
        }
    }
}
