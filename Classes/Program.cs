using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            class className
            {
                [Access Modifier] [Data Type] DataName;
                [Access Modifier] [Return Type] MethodName([Parameter Type] parameterName)
                {
                    Method code block
                }
            }
            */

            /*
            Access Modifiers;
            -Public: Open access.
            -Private: Accessable only in the class that its identified.
            -Internal: Accessable only in the project that its identified.
            -Protected: Accessable in the class that its identified and the child classes of identified class.
            */
            Employee emp1 = new Employee();
            emp1.no = 10966901;
            emp1.name = "John";
            emp1.surname = "Wick";
            emp1.department = "Engineering";
            emp1.EmployeeInfo();

            Employee emp2 = new Employee();
            emp2.no = 96100169;
            emp2.name = "Darlene";
            emp2.surname = "Ericksen";
            emp2.department = "Human Resources";
            emp2.EmployeeInfo();
        }
    }

    class Employee
    {
        public int no;
        public string name;
        public string surname;
        public string department;

        public void EmployeeInfo()
        {
            Console.WriteLine("Employee Number: {0}", no);
            Console.WriteLine("Employee Name: {0}", name);
            Console.WriteLine("Employee Surname: {0}", surname);
            Console.WriteLine("Employee Department: {0}", department);
        }
    }
}
