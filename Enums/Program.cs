using System;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Days.Monday);
            Console.WriteLine((int)Days.Wednesday);
            Console.WriteLine((int)Days.Friday);

            int temperature = 35;
            if(temperature <= (int)Weather.Cold)
            {
                Console.WriteLine("Its too cold outside.");
            }
            if(temperature < (int)Weather.Warm)
            {
                Console.WriteLine("Its nice outside.");
            }
            if(temperature < (int)Weather.Hot)
            {
                Console.WriteLine("Its barbeque weather.");
            }
            if(temperature >= (int)Weather.Cold)
            {
                Console.WriteLine("Its too hot outside.");
            }
        }
    }

    enum Days
    {
        //With "= 1" we starting the enum's index with 1.
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday = 15,
        Friday,
        Saturday,
        Sunday
    }

    enum Weather
    {
        Cold = 5,
        Warm = 20,
        Hot = 30,
    }
}
