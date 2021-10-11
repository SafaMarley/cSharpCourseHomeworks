using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 3;

            ClassA instance = new ClassA();
            instance.WriteToConsole(Sum(a, b).ToString());
            instance.WriteToConsole(instance.IncreaseThenSum(a, b).ToString());
            instance.WriteToConsole(Sum(a, b).ToString());
            instance.WriteToConsole(instance.IncreaseThenSumWithRef(ref a, ref b).ToString());
            instance.WriteToConsole(Sum(a, b).ToString());

            ClassB.WriteToConsole(Sum(a, b).ToString());
        }

        static int Sum(int value1, int value2)
        {
            return value1 + value2;
        }
    }

    class ClassA
    {
        public void WriteToConsole(string data)
        {
            Console.WriteLine(data);
        }
        public int IncreaseThenSum(int val1, int val2)
        {
            val1++;
            val2++;

            return val1 + val2;
        }
        public int IncreaseThenSumWithRef(ref int val1, ref int val2)
        {
            val1++;
            val2++;

            return val1 + val2;
        }
    }

    public class ClassB 
    {
        public static void WriteToConsole(string data)
        {
            Console.WriteLine(data);
        }
    }
}
