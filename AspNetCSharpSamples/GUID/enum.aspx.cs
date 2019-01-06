using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace GUID
{
    public partial class _enum : System.Web.UI.Page
    {


        private enum deneme
        {
            test1 = 10,
            test2 = 1,
            test3 = 12
        };

        protected void Page_Load(object sender, EventArgs e)
        {

            foreach (string item in Enum.GetNames(typeof(deneme)))
            {
                int value = (int)Enum.Parse(typeof(deneme), item);
                ListItem listItem = new ListItem(item, value.ToString());
                Ddl.Items.Add(listItem);
            }



            
  //      CarTypes myCarType = CarTypes.Morgan;
  //TextBox1.Text = Enum.GetName(typeof(CarTypes), myCarType) + ", " + myCarType.ToString() + ", " + (myCarType==CarTypes.Morgan).ToString();
  
  //myCarType = (CarTypes)Enum.Parse(typeof(CarTypes), "Atom");
  //TextBox2.Text += "\r\n" + Enum.GetName(typeof(CarTypes), myCarType) + ", " + myCarType.ToString() + ", " + (myCarType == CarTypes.Atom).ToString();

  //myCarType = (CarTypes)Enum.Parse(typeof(CarTypes), "loTus", true);
  //TextBox3.Text += "\r\n" + Enum.GetName(typeof(CarTypes), myCarType) + ", " + myCarType.ToString() + ", " + (myCarType == CarTypes.Lotus).ToString();





            
            }

        }
    }
