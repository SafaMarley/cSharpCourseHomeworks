using System;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            problem1();
            problem2();
            problem3();
            problem4();
        }

        static void problem1()
        {
            Console.WriteLine("Enter the size of an array: ");
            int arraySize = int.Parse(Console.ReadLine());
            int[] intArray = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                Console.WriteLine("Enter a positive value for index "+ i +" :");
                intArray[i] = int.Parse(Console.ReadLine());
            }
            foreach (int item in intArray)
            {
                if(item % 2 == 0)
                {
                    Console.WriteLine(item);
                }
            }
        }

        static void problem2()
        {
            Console.WriteLine("Enter the first positive value: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second positive value: ");
            int m = int.Parse(Console.ReadLine());

            int[] intArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter a positive value for index "+ i +" :");
                intArray[i] = int.Parse(Console.ReadLine());
            }
            foreach (int item in intArray)
            {
                if(item % m == 0)
                {
                    Console.WriteLine(item);
                }
            }
        }

        static void problem3()
        {
            Console.WriteLine("Enter the size of an array: ");
            int arraySize = int.Parse(Console.ReadLine());
            string[] stringArray = new string[arraySize];
            Array.Reverse(stringArray);
            foreach (string item in stringArray)
            {
                Console.WriteLine(item);
            }
        }

        static void problem4()
        {
            Console.WriteLine("Enter a sentence: ");
            string sentence = Console.ReadLine();
            string[] wordsArray = sentence.Split(" ");
            Console.WriteLine("There are " + (sentence.Length - wordsArray.Length + 1) + " characters in your sentence.");
            Console.WriteLine("There are " + wordsArray.Length + " words in your sentence.");
        }
    }
}
