using System;

namespace Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            Civic civic = new Civic();
            Console.WriteLine("Brand: " + civic.WhichBrand().ToString());
            Console.WriteLine("Number of wheels: " + civic.NumberOfWheels().ToString());
            Console.WriteLine("Default color: " + civic.DefaultColor().ToString());

            Corolla corolla = new Corolla();
            Console.WriteLine("Brand: " + corolla.WhichBrand().ToString());
            Console.WriteLine("Number of wheels: " + corolla.NumberOfWheels().ToString());
            Console.WriteLine("Default color: " + corolla.DefaultColor().ToString());

            Focus focus = new Focus();
            Console.WriteLine("Brand: " + focus.WhichBrand().ToString());
            Console.WriteLine("Number of wheels: " + focus.NumberOfWheels().ToString());
            Console.WriteLine("Default color: " + focus.DefaultColor().ToString());

            Console.WriteLine("************************ABSTRACTS************************");

            NewFocus newFocus = new NewFocus();
            Console.WriteLine("Brand: " + newFocus.WhichBrand().ToString());
            Console.WriteLine("Number of wheels: " + newFocus.NumberOfWheels().ToString());
            Console.WriteLine("Default color: " + newFocus.DefaultColor().ToString());

            NewCorolla newCorolla = new NewCorolla();
            Console.WriteLine("Brand: " + newCorolla.WhichBrand().ToString());
            Console.WriteLine("Number of wheels: " + newCorolla.NumberOfWheels().ToString());
            Console.WriteLine("Default color: " + newCorolla.DefaultColor().ToString());

            NewCivic newCivic = new NewCivic();
            Console.WriteLine("Brand: " + newCivic.WhichBrand().ToString());
            Console.WriteLine("Number of wheels: " + newCivic.NumberOfWheels().ToString());
            Console.WriteLine("Default color: " + newCivic.DefaultColor().ToString());                        
        }
    }
}
