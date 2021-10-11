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


            int month = DateTime.Now.Month;
            switch (month)
            {
                case 1:
                    Console.WriteLine("January");
                    break;

                case 2:
                    Console.WriteLine("February");
                    break;

                case 3:
                    Console.WriteLine("March");
                    break;

                case 4:
                    Console.WriteLine("April");
                    break;

                case 5:
                    Console.WriteLine("May");
                    break;

                case 6:
                    Console.WriteLine("June");
                    break;

                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                    Console.WriteLine("Second half of the year.");
                    break;

                default:
                    Console.WriteLine("There is a problem with date system.");
                    break;
            }
        }
    }
}
