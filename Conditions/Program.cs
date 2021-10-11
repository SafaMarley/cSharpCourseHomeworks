using System;

namespace Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;
            if(time >= 6 && time <= 11) {
                Console.WriteLine("Have a nice morning.");
            }
            if(time <= 18) {
                Console.WriteLine("Have a nice day.");
            }
            else
            {
                Console.WriteLine("Have a nice night.");
            }

            string greeting = time >= 6 && time <= 11 ? "Have a nice morning." : time <= 18 ? "Have a nice day." : "Have a nice night.";
            Console.WriteLine(greeting);

        }
    }
}
