using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HFWeb
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGiris_Click(object sender, EventArgs e)
        {
            int kisiid = 0;
            var sonuc = (DataView)dtsGiris.Select(DataSourceSelectArguments.Empty);

            if (sonuc.Table.Rows[0][0] != null && sonuc.Table.Rows[0][0].ToString() != String.Empty)
            {
                 kisiid = (int)(sonuc.Table.Rows[0][0]);

                if (kisiid > 0)
                {
                    Session["custid"] = kisiid;
                    Session["email"] = txtEposta.Text;
                    Response.Redirect("Default.aspx");
                }
            } 
            else
            {
                lblMesaj.Visible = true;
            }
        }

    }
}