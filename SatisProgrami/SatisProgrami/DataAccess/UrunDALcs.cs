using SatisProgrami.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatisProgrami.DataAccess
{
    class UrunDALcs
    {
        Urun urun;
        public List<Urun> GetAll()
        {
            List<Urun> lstKurs = new List<Urun>();

            try
            {
                using (SqlCommand cmd = new SqlCommand($"select * from tblUrunler", SqlDAL.Baglanti))
                {
                    SqlDAL.Ac();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            urun = new Urun();
                            urun.id = int.Parse(dr["id"].ToString());
                            urun.urunad = dr["urunad"].ToString();
                            urun.urunstok = int.Parse(dr["stokmiktari"].ToString());
                            lstKurs.Add(urun);
                        }
                    }
                }
                return lstKurs;
            }
            catch (SqlException e)
            {
                string error = e.Message;
                MessageBox.Show(error);
                return null;
                // throw;
            }
            finally
            {
                SqlDAL.Kapat();
            }
        }

        public int UrunAdetGetir(int id)
        {

            int result = 1;
            string query = $"select stokmiktari from tblUrunler where id={id}";
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, SqlDAL.Baglanti))
                {

                    SqlDAL.Ac();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            urun = new Urun();
                            urun.id = int.Parse(dr["id"].ToString());
                            urun.urunad = dr["urunad"].ToString();
                            urun.urunstok = int.Parse(dr["stokmiktari"].ToString());
                            SqlDAL.Ac();
                            result = int.Parse(cmd.ExecuteReader().ToString());
                        }
                    }
                }
                if (result == 1)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch (SqlException e)
            {
                string error = e.Message;
                MessageBox.Show(error);
                return 0;
            }
            finally
            {
                SqlDAL.Kapat();
            }

        }

    }
}
