using System;
using System.Runtime.InteropServices;


namespace GUID
{
    [Guid("BE44C98E-5607-4B73-B2E1-BA877168075B")]
    public class Class2
    {
        public Int32 isim(int a, int b)
        {
            //string harun = "merhaba dünya";
            //return harun;
            //const int a = 15;
            //const int b = 20;
            return a + b;
        }
    }
    [Guid("3533FC8C-EC33-4BD9-A488-D3A728B5F720")]
    public class Class3
    {
        public Int32 isim(int a, int b)
        {
            return a * b;
        }
    }
}