using System;
using System.Collections;

namespace ListsQuestion1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = new int[20];
            for(int i = 0; i < 20; i++)
            {
                int input;
                try
                {
                    Console.WriteLine("Enter a positive integer: ");
                    input = int.Parse(Console.ReadLine());
                    if(input < 0)
                    {
                        throw new Exception("You entered nonvalid value.");
                    }
                    else
                    {
                        inputArray[i] = input;
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    i--;
                }

            }

            ArrayList primeList = new ArrayList();
            ArrayList notPrimeList = new ArrayList();
            
            foreach(int input in inputArray)
            {
                for(int i = 2; i < input; i++)
                {
                    if(input % i == 0)
                    {
                        notPrimeList.Add(input);
                        break;
                    }
                    else if(i == input - 1)
                    {
                        primeList.Add(input);
                    }
                }
            }
            primeList.Sort();
            notPrimeList.Sort();
            primeList.Reverse();
            notPrimeList.Reverse();

            int Sum = 0;
            Console.WriteLine("Prime numbers: ");
            foreach(int prime in primeList)
            {
                Console.WriteLine(prime);
                Sum += prime;
            }
            Console.WriteLine("Average of prime numbers = " + Sum / primeList.Count);
            
            Sum = 0;
            Console.WriteLine("Nonprime numbers: ");
            foreach(int nonprime in notPrimeList)
            {
                Console.WriteLine(nonprime);
                Sum += nonprime;
            }
            Console.WriteLine("Average of nonprime numbers = " + Sum / notPrimeList.Count);
        }
    }
}
