using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Smo;
using System.Data.SqlClient;
using System.IO;
using System.Xml.Serialization;


namespace DatabaseConfiguration
{
    public partial class Form1 : Form
    {
        string data;
        const string ip = "199.6.64.98\\sql2008";
        public Form1()
        {
            InitializeComponent();

        }

        protected void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            FillCombo(null,null);

            if (radioButton2.Checked == true)
            {
                radioButton1.Enabled = true;
                Username.Enabled = true;
                Password.Enabled = true;
            }
            else 
            {
                radioButton1.Enabled = true;
                Username.Text = "";
                Password.Text = "";
                Username.Enabled = false;
                Password.Enabled = false;
                checkBox1.Checked = false;

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {

                Veri kayit = new Veri();
                kayit.servername = Servername.Text;
                kayit.a = 1;
                data = SerializeObject(kayit);
                return;
            }


            if (radioButton2.Checked == true && checkBox1.Checked == true)
            {
                Veri kayit = new Veri();
                kayit.servername = Servername.Text;
                kayit.username = Username.Text;
                kayit.password = Password.Text;
                kayit.a = 2;
                data = SerializeObject(kayit);
            }
            else
            {
                MessageBox.Show("Checkbox Error");

            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Veri a = DeserializeObject();
            if (a.a == 1)
            {
                radioButton1.Checked = true;

                string deger1 = a.servername;
                Servername.Text = deger1;


            }
            else if (a.a == 2)
            {
                radioButton2.Checked = true;

                string deger1 = a.servername;
                string deger2 = a.username;
                string deger3 = a.password;

                Servername.Text = deger1;
                Username.Text = deger2;
                Password.Text = deger3;
            }
    
        }

        private void FillCombo (object sender, EventArgs e)
        {
            if (Servername.Text == String.Empty || Servername.Text != ip || Username.Text !="sa" || Password.Text!= "Asis2005Petech" )
            {
                comboBox1.DataSource = null;
                comboBox1.Items.Clear();
                return;
            }

            System.Data.SqlClient.SqlConnectionStringBuilder builder = new System.Data.SqlClient.SqlConnectionStringBuilder();
            
            builder.DataSource = Servername.Text;
            builder.InitialCatalog = "master";

            if (radioButton2.Checked)
            {

                builder.UserID = Username.Text;

                builder.Password = Password.Text;

                try
                {
                    SqlConnection con = new SqlConnection(builder.ConnectionString);
                    con.Open();
                    string query = "select * from sys.databases where database_id > 4 ORDER BY name asc";

                    SqlDataAdapter d = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();

                    if ((builder.UserID != "sa") || (builder.Password != "Asis") || (builder.DataSource != "199.6.64.84\\sql2008"))
                    {
                        return;
                    }

                    d.Fill(dt);

                    comboBox1.DataSource = dt;
                    comboBox1.ValueMember = "database_id";
                    comboBox1.DisplayMember = "name";

                    con.Close();

                }

                catch (Exception)
                {
                    MessageBox.Show("Hatalı Server");
                }


            }
            else
            {
                builder.IntegratedSecurity = true;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Veri a = DeserializeObject();
            if (a.a == 1)
            {
                radioButton1.Checked = true;
                    
                    string deger1 = a.servername;
                    Servername.Text = deger1;
              
                
            }
            else if (a.a==2)
            {
                radioButton2.Checked = true;

                string deger1 = a.servername;
                string deger2 = a.username;
                string deger3 = a.password;

                Servername.Text = deger1;
                Username.Text = deger2;
                Password.Text = deger3;
            }
        }

        private string SerializeObject(Veri kayit)
        {

                FileStream data = new FileStream("data.xml", FileMode.Create);
                XmlSerializer MySerializer = new XmlSerializer(typeof(Veri));
                TextWriter TW = new StringWriter();

                MySerializer.Serialize(TW, kayit);
                MySerializer.Serialize(data, kayit);
                data.Close();

                return TW.ToString();
        }


        private Veri DeserializeObject()
        {
            XmlSerializer MySerializer = new XmlSerializer(typeof(Veri));
            FileStream ReadFileStream = new FileStream("data.xml", FileMode.Open, FileAccess.Read, FileShare.Read);
           
            // Load the object saved above
            Veri LoadedObj = (Veri)MySerializer.Deserialize(ReadFileStream);
            ReadFileStream.Close();
            return LoadedObj;
      
        }
    }
}