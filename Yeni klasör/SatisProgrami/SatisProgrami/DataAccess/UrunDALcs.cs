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
        Satis satis;
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
        public bool StockUpdate(Satis satis)
        {
            bool result = true;
            Urun urun = new Urun();
            try
            {
                string query = " update tblUrunler set stokmiktari=(stokmiktari-@p1) where  id=@p2 and stokmiktari-@p1>0 ";

                using (SqlCommand cmd = new SqlCommand(query, SqlDAL.Baglanti))
                {
                    SqlDAL.Ac();
                    cmd.Parameters.AddWithValue("@p1", satis.satisAdet);
                    cmd.Parameters.AddWithValue("@p2", satis.urunid);
                    result = Convert.ToBoolean(cmd.ExecuteNonQuery());



                }

                if (result)
                {

                }
                return true;
            }
            catch (SqlException e)
            {
                string error = e.Message;
                MessageBox.Show(error);
                return false;
            }
            finally
            {
                SqlDAL.Kapat();
            }
        }
        public int UrunAdetGetir(string kosulCumlesi = "")
        {

            int result = 1;
            string query = $"select stokmiktari from tblUrunler {kosulCumlesi}";
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, SqlDAL.Baglanti))
                {

                    SqlDAL.Ac();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {

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
