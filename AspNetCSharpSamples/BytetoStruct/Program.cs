using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.IO ;
using System.Runtime.Serialization.Formatters.Binary;

namespace BytetoStruct
{


    class Program
    {

        public struct SimpleStruct
        {

            private int companyId;
            private int stationId;
            private int subcode;
            private string stationName;

            public string StationName
            {
                get { return stationName; }
                set { stationName = value; }
            }

            public int Subcode
            {
                get { return subcode; }
                set { subcode = value; }
            }


            public int StationId
            {
                get
                {
                    return stationId;
                }
                set
                {
                    stationId = value;
                }
            }

            public int CompanyId
            {
                get
                {
                    return companyId;
                }
                set
                {
                    companyId = value;
                }
            }

            static byte[] structtobyte(object obj)
            {
                int len = Marshal.SizeOf(obj);
                byte[] arr = new byte[len];
                IntPtr ptr = Marshal.AllocHGlobal(len);
                Marshal.StructureToPtr(obj, ptr, true);
                Marshal.Copy(ptr, arr, 0, len);
                Marshal.FreeHGlobal(ptr);
                return arr;
            }

            public static double ConvertByteArrayToDouble(byte[] b)
            {

                return BitConverter.ToDouble(b, 0);

            }

            private byte[] StructToByte(SimpleStruct str)
            {
                int len = Marshal.SizeOf(str);
                byte[] arr = new byte[len];
                IntPtr ptr = Marshal.AllocHGlobal(len);
                Marshal.StructureToPtr(str, ptr, true);
                Marshal.Copy(ptr, arr, 0, len);
                Marshal.FreeHGlobal(ptr);
                return arr;
            }

            private void StructToByte2(SimpleStruct str, out byte[] arr)
            {
                IntPtr ptr = IntPtr.Zero;
                try
                {

                    int len = Marshal.SizeOf(str);
                    arr = new byte[len];
                    ptr = Marshal.AllocHGlobal(len);
                    Marshal.StructureToPtr(str, ptr, true);
                    Marshal.Copy(ptr, arr, 0, len);
                }

                finally
                {

                    Marshal.FreeHGlobal(ptr);

                }

            }

            public static SimpleStruct ByteToStruct(byte[] arr)
            {
                IntPtr ptPoit = IntPtr.Zero;
                try
                {
                    SimpleStruct str = new SimpleStruct();
                    ptPoit = Marshal.AllocHGlobal(Marshal.SizeOf(str));
                    Marshal.Copy(arr,
                        0, ptPoit, Marshal.SizeOf(str));
                    str = (SimpleStruct)Marshal.PtrToStructure(ptPoit, typeof(SimpleStruct));
                    return str;

                }
                finally
                {
                    Marshal.FreeHGlobal(ptPoit);
                }
            }


            public void DisplayX()
            {

                SimpleStruct str = new SimpleStruct();
                str.CompanyId = 2056;
                str.StationId = 305;
                str.Subcode = 0;
                str.StationName = "Başak Petrol";

                byte[] arr;
                StructToByte2(str, out arr);


                FileStream fs = new FileStream("file3.bin", FileMode.Create, FileAccess.Write);

                BinaryWriter writer = new BinaryWriter(fs);
                writer.Write(arr);
                Console.WriteLine(BitConverter.ToString(arr));
                writer.Close();

                fs = new FileStream("file3.bin", FileMode.Open, FileAccess.Read);

                BinaryReader reader = new BinaryReader(fs);

                str = ByteToStruct(arr);

                Console.WriteLine(str.StationId);
                Console.WriteLine(str.StationName);

                //SimpleStruct  theStruct = reader.ReadStruct(str);

                reader.Close();

            }

        }


        static void Main(string[] args)
        {

            SimpleStruct ss = new SimpleStruct();

            ss.DisplayX();
            Console.ReadLine();
        }
    }
}
