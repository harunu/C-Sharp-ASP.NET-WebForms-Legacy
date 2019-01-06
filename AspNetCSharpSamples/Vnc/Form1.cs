using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Vnc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

    //        StreamReader reader = new StreamReader(@"C:\Users\h.yazganoglu\Documents\Visual Studio 2010\Projects\Vnc\Vnc\qpet_440012.vnc");
    //        try
    //        {
    //            string str;
    //            while (!String.IsNullOrEmpty(str = reader.ReadLine()))
    //            {
                    
    //                if (str.StartsWith("host="))
    //                {
    //                    //Console.WriteLine(str);
    //             string pattern = @"\b(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b";
    //             string ip = Regex.Match(str,pattern).ToString();
    //              Console.WriteLine(ip);
    //              label1.Text = ip;

    //}



    //                }
    //            }
                
            
    //        finally
    //        {
    //            reader.Dispose();
    //        }


        }

        private void button1_Click(object sender, EventArgs e)
        {

            StreamReader reader = new StreamReader(@"C:\Users\Harun\source\repos\AspNetCSharpSamples\Vnc\qpet_440012.vnc");
            try
            {
                string str;
                while (!String.IsNullOrEmpty(str = reader.ReadLine()))
                {

                    if (str.StartsWith("host="))
                    {
                        //Console.WriteLine(str);
                        string pattern = @"\b(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b";
                        string ip = Regex.Match(str, pattern).ToString();
                        Console.WriteLine(ip);
                        label1.Text = ip;

                    }



                }
            }


            finally
            {
                reader.Dispose();
            }


        }
    }
}
