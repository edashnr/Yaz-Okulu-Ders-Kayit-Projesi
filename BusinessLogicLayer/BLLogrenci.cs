using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BLLogrenci
    {
        public static int OgrenciEkleBLL(EntityOgrenci p)
        {
            if (p.Ad != null && p.Soyad != null && p.Numara != null && p.Sifre != null
                && p.Fotograf != null)
            {
                return DALogrenci.OgrenciEkle(p);
            }
            return -1;
        }
        public static List<EntityOgrenci> BllListele()
        {
            return DALogrenci.OgrenciListesi();
        }
        public static bool OgrenciSilBLL(int p)
        {
            if (p >= 0)
            {
                return DALogrenci.OgrenciSil(p);
            }
            return false;
        }
        public static List<EntityOgrenci> BllDetay(int p)
        {
            return DALogrenci.OgrenciDetay(p);
        }

        public static bool OgrenciGüncelleBLL(EntityOgrenci p)
        {

            if (p.Ad != null && p.Ad != "" && p.Soyad != null && p.Soyad != "" && p.Numara != null && p.Numara!="" && p.Sifre != null
                && p.Sifre!="" && p.Fotograf != null && p.Fotograf!="" && p.Id>0)
            {
                return DALogrenci.OgrenciGüncelle(p);
            }
            return false;
        }
    }
}
