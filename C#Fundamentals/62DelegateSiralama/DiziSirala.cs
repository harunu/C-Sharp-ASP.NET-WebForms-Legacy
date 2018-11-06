using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _62DelegateSiralama
{
    public class DiziSirala
    {
        public delegate bool DiziSiralamaFonksiyonu(string a, string b);

        public string[] DiziSiralama(string[] dizi, DiziSiralamaFonksiyonu SirlaFonk)
        {


            for (int i = 1; i < dizi.Length; i++)
            {
                if (SirlaFonk(dizi[i], dizi[i - 1]) == true)
                {
                    string temp = dizi[i];
                    dizi[i] = dizi[i - 1];
                    dizi[i - 1] = temp;
                    i = 1;
                }
            }

            return dizi;

        }

    }
}
