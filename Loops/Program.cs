using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i <= number; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }

            int loopCounter = 1;
            int sum = 0;
            while (loopCounter <= number)
            {
                sum += loopCounter;
                loopCounter++;
            }
            Console.WriteLine("Average value is = " + sum / number);

            int oddSum = 0;
            int evenSum = 0;
            for (int i = 0; i <= 1000; i++)
            {
                if (i % 2 == 1)
                {
                    oddSum += i;
                }
                else
                {
                    evenSum += i;
                }
            }
            Console.WriteLine("Sum of even numbers between 1 and 1.000 is = " + evenSum);
            Console.WriteLine("Sum of odd numbers between 1 and 1.000 is = " + oddSum);

            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                if (i == 6)
                {
                    break;
                }
                Console.WriteLine(i);
            }

            char character = 'a';
            while (character <= 'z')
            {
                if (character == 'z')
                {
                    Console.Write(character);
                }
                else
                {
                    Console.Write(character + ", ");
                }
                character++;
            }
            Console.WriteLine("");

            string[] cars = {"BMW", "Maserati", "Ford", "Nissan", "Honda"};
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
