using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "999";
            int output;

            bool result = int.TryParse(input, out output);
            if (result)
            {
                Console.WriteLine("Completed");
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine("Failed");
            }
            Methods instance = new Methods();
            instance.Sum(4, 15, out int summationResult);
            Console.WriteLine(summationResult);

            instance.PrintToConsole("Hi");
            instance.PrintToConsole(5);
            instance.PrintToConsole(5, 10);
        }
    }

    class Methods
    {
        public void Sum(int a, int b, out int summation)
        {
            summation = a + b;
        }

        public void PrintToConsole(string data)
        {
            Console.WriteLine(data);
        }

        public void PrintToConsole(int data)
        {
            Console.WriteLine(data);
        }

        public void PrintToConsole(int data1, int data2)
        {
            Console.WriteLine(data1 + data2);
        }
    }
}
