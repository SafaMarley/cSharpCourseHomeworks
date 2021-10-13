using System;

namespace LibraryMethods
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
