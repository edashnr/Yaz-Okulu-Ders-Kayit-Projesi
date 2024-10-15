using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;
using BusinessLogicLayer;
using DataAccessLayer;


namespace YazOkuluDersler
{
    public partial class OgrenciSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["ogrid"]);
            Response.Write(x);
            EntityOgrenci ent = new EntityOgrenci();
            ent.Id = x;
            BLLogrenci.OgrenciSilBLL(ent.Id);
            Response.Redirect("OgrenciListesi.aspx");
        }
    }
}