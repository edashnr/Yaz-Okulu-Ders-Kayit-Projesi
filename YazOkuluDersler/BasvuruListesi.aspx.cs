using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;

namespace YazOkuluDersler
{
    public partial class BasvuruListesi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntityBasvuruForm> BasvuruListesi = BLLBasvuruForm.BllListele();
            Repeater1.DataSource = BasvuruListesi;
            Repeater1.DataBind();
        }
    }
}