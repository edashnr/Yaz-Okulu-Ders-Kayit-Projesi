using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BLLBasvuruForm
    {
        public static List<EntityBasvuruForm> BllListele()
        {
            return DALBasvuruForm.BasvuruListesi();
        }
    }
}
