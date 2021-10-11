using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colors = new string[5];
            string[] animals = {"Cats", "Dogs", "Birds", "Foxes"};
            string[] countries;
            countries = new string[5];

            colors[0] = "Blue";
            countries[3] = "Turkey";

            Console.WriteLine(colors[0]);
            Console.WriteLine(animals[1]);
            Console.WriteLine(countries[3]);

            Console.WriteLine("Enter the length of the array");
            int arrayLength = int.Parse(Console.ReadLine());
            int[] array = new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                Console.WriteLine("Enter a value to index " + i + ":");
                array[i] = int.Parse(Console.ReadLine());
            }
            int Sum = 0;
            foreach (var num in array)
            {
                Sum += num;
            }
            Console.WriteLine("Average value is = " + Sum / arrayLength);
        }
    }
}
