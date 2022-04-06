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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            VeriCek();
        }

        void VeriCek()
        {
            SqlConnection baglanti = new SqlConnection(@"Server=DESKTOP-8M7D7GE\SQLEXPRESS; Database=Sirket10 ; User=sa ; Pwd=123");
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "select* from [dbo].[tblDepartman]";
            komut.Connection = baglanti;
            baglanti.Open();

            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                ///[ID];r satiri almak için gerek gerekli .Bütün satirlari dolaşir
                int ID = Convert.ToInt32(dr["ID"]);
                String depAd = dr["DepartmanAd"].ToString();
                lstDep.Items.Add($"{ID}\t\t{depAd}");
            }
            baglanti.Close();
        }
    }
}
