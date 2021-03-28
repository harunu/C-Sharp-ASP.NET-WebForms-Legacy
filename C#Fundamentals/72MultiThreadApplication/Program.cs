using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _72MultiThreadApplication
{
    class Program
    {
        public static string[] URLS = new string[5];
        static void Main(string[] args)
        {
            SetURLS();
            DateTime baslangic = DateTime.Now;

            //ThreadKullanimi();
            //Parallel();

            WebClient client = new WebClient();
            client.DownloadStringCompleted += new DownloadStringCompletedEventHandler(client_DownloadStringCompleted);

            client.DownloadStringAsync(new Uri("http://tr.wikipedia.org/wiki/T%C3%BCrkiye".ToString()), "http://tr.wikipedia.org/wiki/T%C3%BCrkiye");
            client.Dispose();

            DateTime bitis = DateTime.Now;
            var sure = (bitis - baslangic).TotalSeconds;
            Console.WriteLine("İşlem {0} saniye sürdü.", sure);
            Console.ReadLine();

        }

        static void client_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            Console.WriteLine("{0} Adresinden {1} karakter veri {2} thread tarafından indirildi.", e.UserState, e.Result.Length, Thread.CurrentThread.ManagedThreadId);
        }

        private static void Parallel()
        {
            //Parallel.ForEach(URLS, url =>
            //{
            //    WebClient client = new WebClient();
            //    string gelenveri = client.DownloadString(url.ToString());

            //    client.Dispose();

            //    Console.WriteLine("{0} Adresinden {1} karakter veri {2} thread tarafından indirildi.", url, gelenveri.Length, Thread.CurrentThread.ManagedThreadId);

            //});

            //Parallel.For(1, 50, i =>
            //    Console.WriteLine(i));
        }

        private static void ThreadKullanimi()
        {
            foreach (string url in URLS)
            {
                var start = new ParameterizedThreadStart(DownloadURL);

                Thread tr = new Thread(start);
                tr.Start(url);
            }
        }

        private static void DownloadURL(object url)
        {
            WebClient client = new WebClient();
            string gelenveri = client.DownloadString(url.ToString());

            client.Dispose();
            Console.WriteLine("{0} Adresinden {1} karakter veri {2} thread tarafından indirildi.", url, gelenveri.Length, Thread.CurrentThread.ManagedThreadId);
        }


        public static void SetURLS()
        {
            URLS[0] = "http://tr.wikipedia.org/wiki/T%C3%BCrkiye";
            URLS[1] = "http://tr.wikipedia.org/wiki/%C4%B0stanbul";
            URLS[2] = "http://tr.wikipedia.org/wiki/Atat%C3%BCrk";
            URLS[3] = "http://tr.wikipedia.org/wiki/Atat%C3%BCrk";
            URLS[4] = "http://www.codeproject.com/Articles/479478/Learnplusdesignpluspatternsplusfromplusrealpluspro";
        }
    }
}
