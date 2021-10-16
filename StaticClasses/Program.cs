using System;

namespace StaticClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number of employee: {0}", Employee.NumberOfEmployee);
            Employee emp1 = new Employee("Polly", "Green", "Purchasing");
            Console.WriteLine("Number of employee: {0}", Employee.NumberOfEmployee);
            Employee emp2 = new Employee("Rachel", "Goodman", "Engineering");
            Employee emp3 = new Employee("Emily", "Reynolds", "Advertising");
            Console.WriteLine("Number of employee: {0}", Employee.NumberOfEmployee);

            Console.WriteLine(Operations.Summation(50, 150));
            Console.WriteLine(Operations.Extraction(100, 50));
        }
    }

    class Employee
    {
        private static int numberOfEmployee;

        public static int NumberOfEmployee { get => numberOfEmployee; }

        private string name;
        private string surname;
        private string deparment;

        //Static constructor is only executed once when the class first visited.
        static Employee()
        {
            numberOfEmployee = 0;
        }

        public Employee(string name, string surname, string deparment)
        {
            this.name = name;
            this.surname = surname;
            this.deparment = deparment;
            numberOfEmployee++;
        }
    }

    static class Operations
    {
        public static int Summation(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Extraction(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}
