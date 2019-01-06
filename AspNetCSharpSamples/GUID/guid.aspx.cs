using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Globalization;

namespace GUID
{
    public partial class guid : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            if (Page.IsPostBack == false)
            {

                DropDownList1.Items.Add("topla");
                DropDownList1.Items[0].Value = typeof (Class2).GUID.ToString();
                DropDownList1.Items.Add("carpma");
                DropDownList1.Items[1].Value = typeof(Class3).GUID.ToString();               
                DropDownList1.Items.Add("çıkart");
                DropDownList1.Items[2].Value = typeof(Class4).GUID.ToString(); 

            }

            GuidAttribute IMyInterfaceAttribute = (GuidAttribute)Attribute.GetCustomAttribute(typeof(Class2), typeof(GuidAttribute));
            Type clsType = typeof(Class2);
            object obj = Activator.CreateInstance(clsType);
            MethodInfo mInfo = clsType.GetMethod("isim");


            Label1.Text = mInfo.Invoke(obj, BindingFlags.Public | BindingFlags.InvokeMethod, null, new object[] {1,2}, CultureInfo.InvariantCulture).ToString();
     


     

           
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (TextBox1.Text == ""|| TextBox2.Text == "")
                return;
            else
            {
                int a = Convert.ToInt32(TextBox1.Text);
                int b = Convert.ToInt32(TextBox2.Text);
                Type[] types = Assembly.GetExecutingAssembly().GetTypes();

                Type clsType = (Type)types.Where(t => t.GUID.Equals(new Guid(DropDownList1.SelectedValue))).First();
                MethodInfo mInfo = clsType.GetMethod("isim");
                object obj = Activator.CreateInstance(clsType);


                Label2.Text = mInfo.Invoke(obj, BindingFlags.Public | BindingFlags.InvokeMethod, null, new object[] { a, b }, CultureInfo.InvariantCulture).ToString();

                //textBox_sayi2.Text= mInfo.Invoke(obj, BindingFlags.Public|Bind

            }



        }
    }
}