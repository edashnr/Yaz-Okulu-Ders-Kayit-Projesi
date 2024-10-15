using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using BusinessLogicLayer;
using DataAccessLayer;

namespace YazOkuluDersler
{
    public partial class Dersler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                // Derslerin listesini DropDownList1'e yükle
                List<EntityDersler> derslerListesi = BLLDers.BllListele();
                DropDownList1.DataSource = derslerListesi;
                DropDownList1.DataTextField = "Dersad";
                DropDownList1.DataValueField = "Dersid";
                DropDownList1.DataBind();

                // Öğrencilerin listesini DropDownList2'ye yükle
                List<EntityOgrenci> ogrencilerListesi = BLLogrenci.BllListele();
                DropDownList2.DataSource = ogrencilerListesi;
                DropDownList2.DataTextField = "AdSoyad"; // Öğrenci adını buradan alıyoruz
                DropDownList2.DataValueField = "Id"; // Öğrenci Id'sini buradan alıyoruz
                DropDownList2.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //TextBox1.Text = DropDownList1.SelectedValue.ToString();

            EntityBasvuruForm ent = new EntityBasvuruForm();
            ent.Ogrid = int.Parse(DropDownList2.SelectedValue.ToString());
            ent.Dersid = int.Parse(DropDownList1.SelectedValue.ToString());
            BLLDers.TalepEkleBLL(ent);

        }
    }
}