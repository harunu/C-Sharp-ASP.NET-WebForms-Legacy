using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HFWeb
{
    public partial class viewcart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["custid"] == null)
            {
                Response.Redirect("login.aspx");
            }
        }

        protected void btnSiparisVer_Click(object sender, EventArgs e)
        {
            int custid = (int)HttpContext.Current.Session["custid"];

            try
            {
                SqlConnection con = new SqlConnection();
                string cstr = System.Configuration.ConfigurationManager.ConnectionStrings["HAYATIMIZFILMConnectionString"].ConnectionString;
                con.ConnectionString = cstr;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "PRCOder";

                //            @CustID int,
                //@Address varchar(150),
                //@Notlar varchar(150)

                cmd.Parameters.AddWithValue("@CustID", custid);
                cmd.Parameters.AddWithValue("@Address", txtAdres.Text);
                cmd.Parameters.AddWithValue("@Notlar", txtNotlar.Text);
                con.Open();
                int OrderID = (int)cmd.ExecuteScalar();
                con.Close();

                lblMesaj.Text = string.Format("{0} Numaralı siparişiniz başarılı bir şekilde oluşturuldu.", OrderID);
                btnSiparisVer.Enabled = false;
            }
            catch (Exception ex)
            {

                lblMesaj.Text = ex.Message;
            }

        }
    }
}