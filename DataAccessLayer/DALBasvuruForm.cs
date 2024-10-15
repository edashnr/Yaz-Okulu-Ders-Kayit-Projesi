using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;


namespace DataAccessLayer
{
   public class DALBasvuruForm
    {
        //Basvuru LİSTELEME
        public static List<EntityBasvuruForm> BasvuruListesi()
        {
            List<EntityBasvuruForm> degerler = new List<EntityBasvuruForm>();
            SqlCommand komut = new SqlCommand("select * from tblbasvuruformu", baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityBasvuruForm ent = new EntityBasvuruForm();
                ent.Basvuruid = Convert.ToInt32(dr["basvuruid"].ToString());
                ent.Dersid = Convert.ToInt32(dr["dersid"].ToString());
                ent.Ogrid = Convert.ToInt32(dr["ogrid"].ToString());
              

                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
    }
}
