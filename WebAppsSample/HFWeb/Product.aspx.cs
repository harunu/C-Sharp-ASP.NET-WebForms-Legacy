using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using System.Data.SqlClient;

namespace HFWeb
{
    public partial class Product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        [WebMethod(enableSession: true)]
        public static string Add2CartServer(int ProductId, decimal Price)
        {
            string Sonuc = "Ok";

            if (HttpContext.Current.Session["custid"] == null)
            {
                return "mustlogin";
            }

            int custid = (int)HttpContext.Current.Session["custid"];

            try
            {
                SqlConnection con = new SqlConnection();
                string cstr = System.Configuration.ConfigurationManager.ConnectionStrings["HAYATIMIZFILMConnectionString"].ConnectionString;
                con.ConnectionString = cstr;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "PRCAdd2Cart";


                cmd.Parameters.AddWithValue("@ProductID", ProductId);
                cmd.Parameters.AddWithValue("@CustID", custid);
                cmd.Parameters.AddWithValue("@Quantity", 1);
                cmd.Parameters.AddWithValue("@Price", Price);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {

                Sonuc = ex.Message;
            }


            return Sonuc;
        }
    }
}