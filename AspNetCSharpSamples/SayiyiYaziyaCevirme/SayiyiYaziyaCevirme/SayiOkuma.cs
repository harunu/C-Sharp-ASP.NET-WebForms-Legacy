using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SayiyiYaziyaCevirme
{
  

        public class SayiOkuma
  
       {

            private readonly string  [] yuzler = new string[10]{"","Yüz","İkiYüz","ÜçYüz","DörtYüz","BeşYüz","AltıYüz","YediYüz","SekizYüz","DokuzYüz"};
            private readonly string  [] onlar  = new string[10]{"","On","Yirmi","Otuz","Kırk","Elli","Altmış","Yetmiş","Seksen","Doksan"};
            private readonly string  [] birler = new string[10]{"","Bir","İki","Üç","Dört","Beş","Altı","Yedi","Sekiz","Dokuz"};
            private readonly string  [] hane   = new string[5];
            private readonly string  [] rakam  = new string[5];    // {"0","1","2","3","4"};

            const int sabit = 15;



            public string oku(string sayi)
            {
    
                string sonuc = "";

                int uzunluk = sayi.Length;
                if (uzunluk > sabit)
                    return "Hata girilen değerin uzunluğu en fazla 15 olmalı";

                try
                {
                    int k = Convert.ToInt32(sayi);
                }
                catch (Exception ex)
                {
                    return ex.Message.ToString();
                }         
                //sayi = sayi.PadLeft(15,'0');
               
               sayi = "000000000000000" + sayi;
               sayi = sayi.Substring(uzunluk, sabit);

                //rakam.SetValue(sayi.Substring(0, 3), 0);
                rakam[0] = sayi.Substring(0,3);
                rakam[1] = sayi.Substring(3,3);
                rakam[2] = sayi.Substring(6,3);
                rakam[3] = sayi.Substring(9,3);
                rakam[4] = sayi.Substring(12,3);

                if (rakam[0].ToString() != "000")
                    hane[0] = "Trilyon";
                    //hane.SetValue("trilyon ", 0);
                if (rakam[1].ToString() != "000")
                    hane[1] = "Milyar";
                if (rakam[2].ToString() != "000")
                    hane[2] = "Milyon";
                if (rakam[3].ToString() != "000")
                    hane[3] = "Bin";
                else sonuc = "sıfır";

                for (int i = 0; i < hane.Length; i++)
                {
                    sonuc = sonuc + yuzler[Convert.ToInt32(rakam[i][0].ToString())] +
                    birsorunu(onlar[Convert.ToInt32(rakam[i][1].ToString())] + birler[Convert.ToInt32(rakam[i][2].ToString())] + hane[i]);
                }
     
                return sonuc;
            }

            private string birsorunu(string sorun)
            {
                string cozum = "";
                if (sorun == "BirBin")
                    cozum = "Bin ";
                else
                    cozum = sorun;
                return cozum;
            }

        //        private string test(string test) {

        //        char[] a = { '+'};
        //        test = test.TrimStart(a);

        //        if (test.StartsWith("-")){
        //            char[] b = {'-'};
        //            test = test.TrimStart(b);
        //             test = oku()
                    

         //}


        }
    }

