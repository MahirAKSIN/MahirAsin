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
    public partial class Form4 : Form
    {
        int sure = 100;

        public Form4()
        {
            InitializeComponent();
        }

        private void tmr1_Tick(object sender, EventArgs e)
        {
            label1.Left = label1.Left + 10;

           // label1.Location.Equals(label1.Location.X + 50) ;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            tmr1.Enabled = true;
            tmr1.Start();
            lbl_sure.Text = sure.ToString();
            timer2.Enabled = true;
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            sure -= 1;
            lbl_sure.Text = sure.ToString();
            if (sure==0) {
                sure = 100;
                timer2.Stop();
                btn_basla.Visible = true;

            }
        }

        private void btn_basla_Click(object sender, EventArgs e)
        {
            timer2.Start();
            btn_basla.Visible = false;
            label1.Left = 0;
        }
    }
}
