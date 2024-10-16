﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;

namespace DataAccessLayer
{
    public class DALogrenci
    {

        //ÖĞRENCİ EKLEME
        public static int OgrenciEkle(EntityOgrenci parametre)
        {
            SqlCommand komut1 = new SqlCommand("insert into tblogrenci (ograd,ogrsoyad,ogrnumara,ogrfoto,ogrsifre) " +
                "values (@p1,@p2,@p3,@p4,@p5)", baglanti.bgl);
            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            komut1.Parameters.AddWithValue("@p1", parametre.Ad);
            komut1.Parameters.AddWithValue("@p2", parametre.Soyad);
            komut1.Parameters.AddWithValue("@p3", parametre.Numara);
            komut1.Parameters.AddWithValue("@p4", parametre.Fotograf);
            komut1.Parameters.AddWithValue("@p5", parametre.Sifre);
            return komut1.ExecuteNonQuery();
        }

        //LİSTELEME
        public static List<EntityOgrenci> OgrenciListesi()
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand komut2 = new SqlCommand("select * from tblogrenci", baglanti.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            SqlDataReader dr = komut2.ExecuteReader();
            while(dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.Id = Convert.ToInt32(dr["ogrid"].ToString());
                ent.Ad = dr["ograd"].ToString();
                ent.Soyad = dr["ogrsoyad"].ToString();
                ent.Numara = dr["ogrnumara"].ToString();
                ent.Sifre = dr["ogrsifre"].ToString();
                ent.Fotograf = dr["ogrfoto"].ToString();
                ent.Bakiye =Convert.ToDouble( dr["ogrbakiye"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        //ÖĞRENCİ SİLME
        public static bool OgrenciSil(int parametre)
        {
            SqlCommand komut3 = new SqlCommand("delete from tblogrenci where ogrid=@p1", baglanti.bgl);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@p1", parametre);
            return komut3.ExecuteNonQuery() > 0;
        }

        //GÜNCELLEME TABLOSUNA DEĞERLERİ GETİRME
        public static List<EntityOgrenci> OgrenciDetay(int id)
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand komut4 = new SqlCommand("select * from tblogrenci where ogrid=@p1", baglanti.bgl);
            komut4.Parameters.AddWithValue("@p1", id);
            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            SqlDataReader dr = komut4.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
             
                ent.Ad = dr["ograd"].ToString();
                ent.Soyad = dr["ogrsoyad"].ToString();
                ent.Numara = dr["ogrnumara"].ToString();
                ent.Sifre = dr["ogrsifre"].ToString();
                ent.Fotograf = dr["ogrfoto"].ToString();
                ent.Bakiye = Convert.ToDouble(dr["ogrbakiye"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static bool OgrenciGüncelle(EntityOgrenci deger)
        {
            SqlCommand komut5 = new SqlCommand("update tblogrenci set ograd=@p1,ogrsoyad=@p2," +
                "ogrnumara=@p3,ogrsifre=@p4,ogrfoto=@p5 where ogrid=@p6", baglanti.bgl);
            if (komut5.Connection.State != ConnectionState.Open)
            {
                komut5.Connection.Open();
            }
            komut5.Parameters.AddWithValue("@p1", deger.Ad);
            komut5.Parameters.AddWithValue("@p2", deger.Soyad);
            komut5.Parameters.AddWithValue("@p3", deger.Numara);
            komut5.Parameters.AddWithValue("@p4", deger.Sifre);
            komut5.Parameters.AddWithValue("@p5", deger.Fotograf);
            komut5.Parameters.AddWithValue("@p6", deger.Id);
            return komut5.ExecuteNonQuery() > 0;
        }
    }
}
