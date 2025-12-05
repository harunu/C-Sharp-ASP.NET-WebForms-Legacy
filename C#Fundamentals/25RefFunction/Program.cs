using System;

namespace _25RefFunction
{
    class Program
    {
        static void Function(ref int a)
        {
            a = a + 5;
        }

        static void RemoveVowels(ref string text)
        {
            //text = text.Replace("a", "");
            //text = text.Replace("e", "");
            //text = text.Replace("u", "");
            //text = text.Replace("ü", "");
            //text = text.Replace("ö", "");
            //text = text.Replace("o", "");
            //text = text.Replace("ı", "");
            //text = text.Replace("i", "");
            string[] vowels = { "a", "e", "u", "ü", "ı", "i", "ö", "o" };

            foreach (var letter in vowels)
            {
                text = text.Replace(letter, "");
                text = text.Replace(letter.ToUpper(), "");
            }
        }

        static void Main(string[] args)
        {
            string strValue = "Ali Ihsan";

            strValue = strValue.Replace("Ali", "Haci");
            Console.WriteLine(strValue);
            string testText = "Merhaba Dünya, Hosgeldin Güle Güle";

            RemoveVowels(ref testText);
            Console.WriteLine(testText);

            int other = 9;
            Function(ref other);
            Console.WriteLine(other);
            Console.ReadLine();
        }
    }
}
