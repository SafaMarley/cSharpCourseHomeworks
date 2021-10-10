using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Number you entered is: " + number);
            }
            catch(Exception ex)
            {
                Console.Write("Hata: " + ex.Message.ToString());
            }
            finally     //optional
            {
                Console.WriteLine("Process completed!");
            }

            try
            {
                //int i = int.Parse(null);
                //int i = int.Parse("safa");
                int i = int.Parse("-50000000000");
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine("You entered null value!");
                Console.WriteLine(ex);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Unsuitable data type!");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Number you entered is whether too large or too small");
                Console.WriteLine(ex);
            }
        }
    }
}
