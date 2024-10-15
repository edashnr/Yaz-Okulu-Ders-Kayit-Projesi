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
     public class DALDers
    {
        //DERS LİSTELEME
        public static List<EntityDersler> DersListesi()
        {
            List<EntityDersler> degerler = new List<EntityDersler>();
            SqlCommand komut = new SqlCommand("select * from tbldersler", baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityDersler ent = new EntityDersler();
               ent.Dersid = Convert.ToInt32(dr["dersid"].ToString());
                ent.Dersad = dr["dersad"].ToString();
                ent.Min = Convert.ToInt32(dr["dersminkont"].ToString());
                ent.Max = Convert.ToInt32(dr["dersmaxkont"].ToString());
               
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static int TalepEkle(EntityBasvuruForm parametre)
        {
            SqlCommand komut2 = new SqlCommand("insert into tblbasvuruformu (ogrid,dersid) values (@p1,@p2)", baglanti.bgl);
            komut2.Parameters.AddWithValue("@p1", parametre.Ogrid);
            komut2.Parameters.AddWithValue("@p2", parametre.Dersid);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            return komut2.ExecuteNonQuery();
        }
    }
}
