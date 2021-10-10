using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            byte b = 5;         //1byte
            sbyte c = 5;        //1byte

            short d = 5;        //2byte
            ushort e = 5;       //2byte

            Int16 int16 = 5;    //2byte
            int i = 5;          //4byte
            Int32 int32 = 5;    //4byte
            Int64 int64 = 5;    //8byte

            uint ui = 5;        //4byte
            long l = 5;         //8byte
            ulong ul = 5;       //8byte

            float f = 5;        //4byte
            double doub = 5;    //8byte
            decimal dec = 5;    //16byte

            char ch = '5';          //2byte
            string str = "Safa";   //xbyte

            bool b1 = true;         

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            object o1 = 5;
            object o2 = 0.5;
            object o3 = '5';
            object o4 = "05";

            string str1 = string.Empty;
            str1 = "not empty anymore";

            string name = "Safa";
            string surname = "Ktrcgl";
            string fullName = name + " " + surname;

            int int1 = 2;
            int int2 = 5;
            int int3 = int1 * int2;

            bool bool1 = 10 > 2;

            string str20 = "20";
            int int20 = 20;
            Console.WriteLine(str20 + int20.ToString());
            Console.WriteLine(int20 + Convert.ToInt32(str20));
            Console.WriteLine(int20 + int.Parse(str20));

            Console.WriteLine(DateTime.Now.ToString("dd.MM.yyyy"));
            Console.WriteLine(DateTime.Now.ToString("HH:mm"));
        }
    }
}
