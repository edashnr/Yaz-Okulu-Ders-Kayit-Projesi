using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityBasvuruForm
    {
        private int basvuruid;
        private int dersid;
        private int ogrid;
        private string dersad;
        private string ograd;

        public int Basvuruid { get => basvuruid; set => basvuruid = value; }
        public int Dersid { get => dersid; set => dersid = value; }
        public int Ogrid { get => ogrid; set => ogrid = value; }
        public string Dersad { get => dersad; set => dersad = value; }
        public string Ograd { get => ograd; set => ograd = value; }

        private void BindRepeater()
        {

            string connectionString = @"Data Source = G770;
            Initial Catalog = DbYazOkuluDersler; Integrated Security = True ";
            using (SqlConnection sql1 = new SqlConnection(connectionString))
            {
                string sql = $@"SELECT d.dersad ,o.ograd+' ' +o.ogrsoyad 'AD SOYAD'
                        FROM tblbasvuruformu b 
                        INNER JOIN tbldersler d ON b.dersid = d.dersid
                        INNER JOIN tblogrenci o ON b.ogrid = o.ogrid";

                
            }
            
        }
        
    }
       
}
