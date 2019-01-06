using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

namespace HFWeb
{


    public class KimlikHeader : SoapHeader
    {
        public int SuppID { get; set; }
        public string SuppPassword { get; set; }
    }


    public class SuppOrder
    {
        public int OrderID { get; set; }
        public int CartID { get; set; }
        public string MovieName { get; set; }
        public int Quantity { get; set; }
    }


    /// <summary>
    /// Summary description for Supplier
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Supplier : System.Web.Services.WebService
    {
        public KimlikHeader Kimlik { get; set; }

        [WebMethod]
        [SoapHeader("Kimlik")]
        public DateTime GetServiceDateTime()
        {
            return DateTime.Now;
        }


        HAYATIMIZFILMEntities ctx = new HAYATIMIZFILMEntities();

        [WebMethod]
        [SoapHeader("Kimlik")]
        public List<SuppOrder> GetMyOrders()
        {
            List<SuppOrder> liste;

            liste = (from p in ctx.SRGOrderSupps
                     where p.SUPPID == Kimlik.SuppID
                     select new SuppOrder
                     {
                         CartID = p.CARTID,
                         MovieName = p.NAME,
                         OrderID = (int)p.ORDERID,
                         Quantity = (int)p.QUANTITY
                     }).ToList();

            return liste;
        }


        [WebMethod]
        [SoapHeader("Kimlik")]
        public void UpdateProductStatus(int ProductID, bool Status)
        {
            ctx.PRCMovieStatusUpdate(ProductID, Kimlik.SuppID, Status);
        }

    }
}
