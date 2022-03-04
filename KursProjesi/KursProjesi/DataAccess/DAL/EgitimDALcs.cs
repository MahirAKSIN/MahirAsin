using KursProjesi.DataAccess.BaglantiDAL;
using KursProjesi.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursProjesi.DataAccess.DAL
{
    class EgitimDALcs
    {
        Kurs kurs = null;
        //temel CRUD islemleri yapilacak
        public List<Kurs> GetAll()
        {
            List<Kurs> lstKurs = new List<Kurs>();
            try
            {
                using (SqlCommand cmd = new SqlCommand($"select * from tblEgitimler", Baglanti.BaglantiNesnesi))
                {
                    Baglanti.Ac();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            kurs = new Kurs();
                            kurs.id = int.Parse(dr["id"].ToString());
                            kurs.Ad = dr["ad"].ToString();
                            kurs.Sorumlu = dr["sorumlu"].ToString();
                            kurs.BaslangicT = Convert.ToDateTime(dr["baslangicT"].ToString());
                            kurs.Sure = int.Parse(dr["sure"].ToString());
                            lstKurs.Add(kurs);
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
                Baglanti.Kapa();
            }
        }
    }
}
