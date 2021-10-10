using System;


class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        Console.WriteLine("Your name:");
        string name = Console.ReadLine();
        Console.WriteLine("Your surname:");
        string surname = Console.ReadLine();
        Console.WriteLine("Hi " + name + " " + surname);
    }
}
