using System;
using System.Collections;
using System.Collections.Generic;

namespace ListsQuestion2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myArrayList = new ArrayList();
            Console.WriteLine("Enter 20 numbers");
            for(int i = 0; i < 20; i++)
            {
                try
                {
                    myArrayList.Add(int.Parse(Console.ReadLine()));
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            List<int> maxValues = new List<int>();
            List<int> minValues = new List<int>();

            for(int i = 0; i < 3; i++)
            {
                int max = int.MinValue;
                int min = int.MaxValue;
                foreach (int item in myArrayList)
                {
                    if(item > max)
                    {
                        max = item;
                    }
                    if(min > item)
                    {
                        min = item;
                    }
                }
                maxValues.Add(max);
                myArrayList.Remove(max);

                minValues.Add(min);
                myArrayList.Remove(min);
            }

            int Sum = 0;
            Console.WriteLine("Average of max 3 values: ");
            foreach (int item in maxValues)
            {
                Sum += item;
            }
            Console.WriteLine(Sum / 3);

            Sum = 0;
            Console.WriteLine("Average of min 3 values: ");
            foreach (int item in minValues)
            {
                Sum += item;
            }
            Console.WriteLine(Sum / 3);
        }
    }

    
}
