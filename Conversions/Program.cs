using System;

namespace Converting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implicit Conversions");
            byte a = 5;
            sbyte b = 10;
            short c = 20;

            int d = a + b + c;
            Console.WriteLine("d = " + d);
            long h = d;
            Console.WriteLine("h = " + h);
            float j = h;
            Console.WriteLine("j = " + j);

            string name = "safa";
            char k = 'l';
            object o = name + k + j;
            Console.WriteLine(o);
            

            Console.WriteLine("Explicit Conversions");
            int l = 5;
            byte m = (byte)l;
            Console.WriteLine("m = " + m);

            float n = 10.5f;
            m = (byte)n;
            Console.WriteLine("m = " + m);

            string zz = l.ToString();
            Console.WriteLine("zz = " + zz);
            zz = n.ToString();
            Console.WriteLine("zz = " + zz);

            string str1 = "20";
            string str2 = "10";
            int int1 = Convert.ToInt32(str1);
            int int2 = Convert.ToInt32(str2);
            Console.WriteLine(int1 + int2);

            ParseMethod();
        }

        public static void ParseMethod()
        {
            string str1 = "30";
            string str2 = "5,25";
            int int1 = Int32.Parse(str1);
            Console.WriteLine("int1 = " + int1);
            double double1 = Double.Parse(str2);
            Console.WriteLine("double1 = " + double1);
        }
    }
}
