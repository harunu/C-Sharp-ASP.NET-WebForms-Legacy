using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HFWeb
{
    public partial class HF : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAra_Click(object sender, ImageClickEventArgs e)
        {
            if (txtAranan.Text != "")
            {
                string KategiriID = ddlArananKategori.SelectedValue;
                string KategoriAdi = ddlArananKategori.SelectedItem.Text;
                string Aranan = txtAranan.Text;

                string url = string.Format("default.aspx?catid={0}&catname={1}&search={2}", KategiriID, KategoriAdi, Aranan);
                Response.Redirect(url);
            }
        }

        public string UyeBilgiGetir()
        {
            if (Session["email"] == null)
            {
                return "Üye Kaydı";
            }
            else
            {
                return Session["email"].ToString();
            }
        }
    }
}