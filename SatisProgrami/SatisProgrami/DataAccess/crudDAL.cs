using SatisProgrami.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatisProgrami.DataAccess
{
    class crudDAL
    {

        Satis satis = null;
        crudDAL crud;
        public List<Satis> GetAll()
        {
            List<Satis> lstKurs = new List<Satis>();

            try
            {
                using (SqlCommand cmd = new SqlCommand($"select * from tblSatislar", SqlDAL.Baglanti))
                {
                    SqlDAL.Ac();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            satis = new Satis();
                            satis.id = int.Parse(dr["id"].ToString());
                            satis.satisT = Convert.ToDateTime(dr["satistarih"].ToString());
                            satis.urunid = int.Parse(dr["urunid"].ToString());
                            satis.satisAdet = int.Parse(dr["satisadet"].ToString());
                            lstKurs.Add(satis);
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


        public bool insert(Satis satis)
        {

            string query = "insert into tblSatislar values (@p2,@p3,@p4)";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, SqlDAL.Baglanti))
                {
                    cmd.Parameters.AddWithValue("@p2", (satis.satisT).ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@p3", satis.urunid);
                    cmd.Parameters.AddWithValue("@p4", satis.satisAdet);
                    SqlDAL.Ac();
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (SqlException e)
            {

                System.Windows.Forms.MessageBox.Show(e.Message);
                return false;
            }
            finally
            {
                SqlDAL.Kapat();

            }

        }


    }
}
