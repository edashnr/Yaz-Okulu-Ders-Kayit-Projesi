using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityOgrenci
    {
        private string ograd;
        private string ogrsoyad;
        private int ogrid;
        private string ogrnumara;
        private string ogrfotograf;
        private double ogrbakiye;
        private string ogrsifre;
        
       

        public string Ad { get => ograd; set => ograd = value; }
        public string Soyad { get => ogrsoyad; set => ogrsoyad = value; }
        public int Id { get => ogrid; set => ogrid = value; }
        public string Numara { get => ogrnumara; set => ogrnumara = value; }
        public string Fotograf { get => ogrfotograf; set => ogrfotograf = value; }
        public double Bakiye { get => ogrbakiye; set => ogrbakiye = value; }
        public string Sifre { get => ogrsifre; set => ogrsifre = value; }

        public string AdSoyad
        {
            get { return Ad + " " + Soyad; }
        }
    }
}
