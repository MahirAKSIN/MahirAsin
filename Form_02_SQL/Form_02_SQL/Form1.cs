using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_02_SQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                SqlConnection baglanti = new SqlConnection();
                baglanti.ConnectionString = @"Server=DESKTOP-8M7D7GE\SQLEXPRESS; Database=Sirket10; User=sa; Pwd=123";
                //usteki satir sql server authentication metodu ile baglanti saglar.
                //baglanti.ConnectionString = @"Server=DESKTOP-8M7D7GE\SQLEXPRESS; Database=Sirket10; Trusted_Connection=true";
                ////usteki satir sql server authentication metodu ile baglanti saglar.
                baglanti.Open();

                //islemeler
                //islemeler
                //islemeler
                //islemeler
                baglanti.Close();
                MessageBox.Show("Baglanti basarili");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                
            }





        }


    }
}
