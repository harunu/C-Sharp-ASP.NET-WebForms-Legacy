using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Switch
{

    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;

            deyim:

            //if (a == 1)
            //{
            //    Console.WriteLine("anın değeri 1dir");
            //}
            //else if (a == 2)
            //{
            //    Console.WriteLine("anın değeri 2dir");
            //}
            //else if (a == 5)
            //{
            //    Console.WriteLine("anın değeri 5dir");
            //}
            //else
            //{
            //    Console.WriteLine("anın değeri farklı bişey");
            //}



            switch (a)
            {
                case 1:
                case 2:
                    Console.WriteLine("anın değeri 2dir");
                    break;

                default:
                    Console.WriteLine("anın değeri farklı bişey");
                    break;

                case 5:
                    Console.WriteLine("anın değeri 5dir");
                    goto case 1;
                    string b = "";
                    b = b + "abc";
                    break;

            }


            Console.ReadLine();
            goto deyim;

        }
    }



}

