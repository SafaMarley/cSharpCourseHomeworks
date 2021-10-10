using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 10;

            y /= 2;
            x *= 3;
            x -= 5;
            y += 10;

            Console.WriteLine("x = " + x + ", y = " + y);

            bool isInProgress = true;
            bool isCompleted = false;

            if (isInProgress && isCompleted)
            {
                Console.WriteLine("Well done");
            }
            if (isInProgress || isCompleted)
            {
                Console.WriteLine("Nice");
            }
            if(!isInProgress && !isCompleted)
            {
                Console.WriteLine("Not Good");
            }

            int a = 5;
            int b = 10;
            bool result = b > a;
            Console.WriteLine(result);
            result = !result;
            Console.WriteLine(result);
            a++;
            a = b % a;
            Console.WriteLine(a);
        }
    }
}
