using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatisProgrami.DataAccess
{
    public static  class SqlDAL
    {

        private static  SqlConnection baglanti;

        public static  SqlConnection Baglanti
        {
            get
            {

                if (baglanti==null)
                {
                    baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["CsSatis"].ConnectionString);
                }
                return baglanti;
            }
            set
            {
                baglanti = value;
            }
        }

        public static void Ac()
        {
            if (baglanti.State==ConnectionState.Closed)
            {
                baglanti.Open();
            }
        }
        public static void Kapat()
        {
            if (baglanti.State == ConnectionState.Open)
            {
                baglanti.Close();
            }
        }
    }
}
