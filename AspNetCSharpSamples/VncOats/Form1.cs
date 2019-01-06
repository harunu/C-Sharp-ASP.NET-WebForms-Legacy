using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;
using System.Text.RegularExpressions;

//    ALTER TABLE dbo.ac_tr_STATION_Ips ADD
//    AcmIp varchar(20) NULL
//    GO
namespace VncOats
{
    public partial class Form1 : Form
    {
        SqlConnection Myconnection;

        public Form1()
        {
            InitializeComponent();
            Myconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string a = folderBrowserDialog1.SelectedPath;

                label3.Visible = false;
                progressBar1.Visible = true;
                button1.Enabled = false;
                backgroundWorker1.RunWorkerAsync(a);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string path = e.Argument.ToString();
            

            DirectoryInfo dir = new DirectoryInfo(path);
            FileInfo[] files = dir.GetFiles("*.vnc", SearchOption.TopDirectoryOnly);

            if (files.Length == 0)
            {
                //backgroundWorker1.ReportProgress(0, "Geçerli dosya yok");
                e.Cancel = true;
                return;
            }



            Myconnection.Open();

            //foreach (FileInfo file in files)
            //{
            // Console.WriteLine(file.Name);
            //}
            SqlCommand cmd = new SqlCommand("select CompanyID from Companies ", Myconnection);
            SqlDataReader reader = cmd.ExecuteReader();
            List<int> companies = new List<int>();

            while (reader.Read())
            {
                companies.Add(Convert.ToInt32(reader["CompanyId"]));
            }
            reader.Close();


            foreach (int companyId in companies)
            {
                SqlCommand cmd2 = new SqlCommand("select CompanyId,BaseCompanyId,StationIdInt,StationId,SubCode from UserStations(11,@CompanyId,0,0,NULL)", Myconnection);
                //SqlCommand cmd2 = new SqlCommand("select StationId, SubCode from ac_tr_STATIONS where CompanyId = @CompanyId", Myconnection);
                cmd2.Parameters.Add("@CompanyId", SqlDbType.Int).Value = companyId;
                Console.Write(companyId + " ");
                SqlDataAdapter dbp = new SqlDataAdapter(cmd2);
                DataTable table = new DataTable("test");
                dbp.Fill(table);

                //DataTable table = ds.Tables[0];

                int b = table.Rows.Count;

                foreach (DataRow dr in table.Rows)
                {
                    b--;
                    backgroundWorker1.ReportProgress(b);

                    int Subcode = Convert.ToInt32(dr["Subcode"]);

                    int StationId = Convert.ToInt32(dr["StationId"]);

                    string filename = String.Format("{0}.vnc", StationId);
                    if (Subcode > 0)
                    {
                        filename = String.Format("{0}-{1}.vnc", StationId,
                            Subcode);
                    }
                    var result = from a in files where a.Name == filename select a;

                    if (result.Any())
                    {
                        Console.WriteLine("Dosya Var "
                            + dr["StationId"].ToString());


                        StreamReader reader2 = new StreamReader(result.First().FullName);
                        try
                        {
                            string str;
                            while (!String.IsNullOrEmpty(str = reader2.ReadLine()))
                            {
                                if (str.StartsWith("host="))
                                {
                                    //Console.WriteLine(str);                                 
                                    string pattern = @"\b(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b";
                                    string ip = Regex.Match(str, pattern).ToString();
                                    Console.WriteLine(ip);



                                    cmd2.CommandText = "UPDATE dbo.ac_tr_STATION_Ips SET  [AcmIp] = @AcmIp WHERE CompanyId = @CompanyId and StationId = @StationId and SubCode = @Subcode";
                                    cmd2.Parameters.Clear();
                                    cmd2.Parameters.AddWithValue("@AcmIp", ip);
                                    cmd2.Parameters.AddWithValue("@CompanyId", companyId);
                                    cmd2.Parameters.AddWithValue("@StationId", StationId);
                                    cmd2.Parameters.AddWithValue("@Subcode", Subcode);
                                    cmd2.ExecuteNonQuery();
                                }
                            }
                        }
                        finally
                        {
                            reader.Dispose();
                        }
                    }
                }
                Console.WriteLine(table.Rows.Count);
            }

            

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            label1.Text = e.ProgressPercentage.ToString("N0");
            if (e.UserState != null)
                label1.Text = e.UserState.ToString();

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar1.Visible = false;
            label3.Visible = true;
            button1.Enabled = true;

            if (e.Cancelled)
            {
                label3.Text = "Hiç dosya yok.";
            }
            else
            {
                label3.Text = "İşleminiz başarıyla tamamlanmıştır.";
            }
        }

    }
}
