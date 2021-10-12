using System;

namespace RecursiveAndExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 1;
            for (int i = 0; i < 4; i++)
            {
                result *= 3;
            }
            Console.WriteLine(result);

            Calculations instance = new Calculations();
            Console.WriteLine(instance.Multiplication(5, 3));

            //Extension Methods
            string name = "M. Safa Ktrcgl";
            bool isThereSpace = name.CheckSpaces();
            Console.WriteLine(name);
            Console.WriteLine(isThereSpace);
            if (isThereSpace)
            {
                Console.WriteLine(name.RemoveSpaces());
            }
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.ToLower());

            int[] intArray = {0, 3, 2, 5, 1, 6, 7, 9, 8, 4};
            intArray.SortArray();
            intArray.PrintIntArrayToConsole();
            
            Console.WriteLine(intArray[5].IsEvenNumber());
            Console.WriteLine(intArray[6].IsEvenNumber());
            
            Console.WriteLine(name.GetFirstCharacter());
        }
    }

    class Calculations
    {
        public int Multiplication(int number, int power)
        {
            if (power == 1)
            {
                return number;
            }
            else
            {
                return Multiplication(number, power - 1) * number;
            }
        }
    }

    public static class Extensions
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }

        public static string RemoveSpaces(this string str)
        {
            string[] strArray = str.Split(" ");
            return string.Join("", strArray);
        }

        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }

        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }

        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }

        public static void PrintIntArrayToConsole(this int[] param)
        {
            foreach (int item in param)
            {
                Console.WriteLine(item);
            }
        }

        public static bool IsEvenNumber(this int param)
        {
            return param % 2 == 0;
        }

        public static string GetFirstCharacter(this string param)
        {
            return param.Substring(0, 1);
        }
    }
}
