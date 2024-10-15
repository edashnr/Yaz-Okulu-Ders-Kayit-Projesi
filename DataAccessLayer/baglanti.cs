using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class baglanti
    {
        public static SqlConnection bgl = new SqlConnection(@"Data Source=G770;
         Initial Catalog=DbYazOkuluDersler;Integrated Security=True ");
    }
}
