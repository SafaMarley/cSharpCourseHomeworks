using System;

namespace LibraryMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //String Methods
            
            string justString = "cSharp library methods";
            Console.WriteLine("String has " + justString.Length + " characters.");

            Console.WriteLine(justString.ToUpper());
            Console.WriteLine(justString.ToLower());

            Console.WriteLine(String.Concat(justString, " Hi concat!"));

            string justAnotherString = "cSharp library method";
            Console.WriteLine(justString.CompareTo(justAnotherString));
            bool ignoreUpperLowerCase = true;
            Console.WriteLine(String.Compare(justAnotherString, justString, ignoreUpperLowerCase));

            Console.WriteLine(justString.Contains(justAnotherString));

            Console.WriteLine(justString.StartsWith("cSharp"));
            Console.WriteLine(justString.EndsWith("methods"));

            Console.WriteLine(justString.IndexOf("library"));
            Console.WriteLine(justString.IndexOf("safa"));
            Console.WriteLine(justString.LastIndexOf("r"));

            Console.WriteLine(justString.Insert(0, "Hello ^^ "));

            Console.WriteLine(justString + justAnotherString.PadLeft(30));
            Console.WriteLine(justString + justAnotherString.PadRight(30, '*'));

            Console.WriteLine(justString.Remove(10));
            Console.WriteLine(justString.Remove(0, 10));

            Console.WriteLine(justString.Replace("cSharp", "C#"));

            Console.WriteLine(justString.Split(" ")[1]);

            Console.WriteLine(justString.Substring(5));
            Console.WriteLine(justString.Substring(0, 5));

            //DateTime Methods

            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());

            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.AddYears(1));
            Console.WriteLine(DateTime.Now.AddDays(10));

            //Formats
            Console.WriteLine(DateTime.Now.ToString("dd"));
            Console.WriteLine(DateTime.Now.ToString("ddd"));
            Console.WriteLine(DateTime.Now.ToString("dddd"));

            Console.WriteLine(DateTime.Now.ToString("MM"));
            Console.WriteLine(DateTime.Now.ToString("MMM"));
            Console.WriteLine(DateTime.Now.ToString("MMMM"));

            Console.WriteLine(DateTime.Now.ToString("yy"));
            Console.WriteLine(DateTime.Now.ToString("yyy"));

            //Math Methods

            Console.WriteLine(Math.Abs(-25));
            Console.WriteLine(Math.Sin(30));
            Console.WriteLine(Math.Cos(30));
            Console.WriteLine(Math.Tan(30));

            Console.WriteLine(Math.Ceiling(10.1));
            Console.WriteLine(Math.Round(10.9));
            Console.WriteLine(Math.Round(10.1));
            Console.WriteLine(Math.Floor(10.9));

            Console.WriteLine(Math.Max(3, 9));
            Console.WriteLine(Math.Min(3, 9));

            Console.WriteLine(Math.Pow(3, 4));
            Console.WriteLine(Math.Sqrt(81));
            Console.WriteLine(Math.Log(Math.Exp(3)));
            Console.WriteLine(Math.Log10(100));
        }
    }
}
