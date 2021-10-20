using System;
using System.Collections.Generic;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> phoneBook = new List<Person>();
            int choice = -1;
            while(choice != 0)
            {
                Console.WriteLine("Choose an operation:");
                Console.WriteLine("********************");
                Console.WriteLine("1.Save phone number");
                Console.WriteLine("2.Delete phone number");
                Console.WriteLine("3.Update phone number");
                Console.WriteLine("4.List phone numbers");
                Console.WriteLine("5.Search phone number");
                Console.WriteLine("0.Exit");

                try
                {
                    choice = int.Parse(Console.ReadLine());
                    if(choice < 0 || choice > 5)
                    {
                        throw new ("Unvalid input.");
                    }
                }

                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }

                if(choice == 0)
                {
                    Console.WriteLine("Have a nice day.");
                }

                else if(choice == 1)
                {
                    SavePhoneNumber();
                }

                else if(choice == 2)
                {
                    DeletePhoneNumber();
                }

                else if(choice == 3)
                {
                    UpdatePhoneNumber();
                }

                else if(choice == 4)
                {
                    ListPhoneNumbers();
                }

                else if(choice == 5)
                {
                    SearchPhoneNumbers();
                }
            }

            void SavePhoneNumber()
            {
                string tempName;
                string tempSurname;
                string tempPhoneNumber;
                Console.WriteLine("Name: ");
                tempName = Console.ReadLine();
                Console.WriteLine("Surame: ");
                tempSurname = Console.ReadLine();
                Console.WriteLine("Phone number: ");
                tempPhoneNumber = Console.ReadLine();

                Person personToSave = new Person(tempName, tempSurname, tempPhoneNumber);
                phoneBook.Add(personToSave);
            }

            void DeletePhoneNumber()
            {
                string tempString;
                int loopChecker = 1;
                Console.WriteLine("Name or surname: ");
                tempString = Console.ReadLine();
                foreach (Person item in phoneBook)
                {
                    if(item.name.Contains(tempString) || item.surname.Contains(tempString))
                    {
                        char tempChar;
                        Console.WriteLine(item.name + " " + item.surname + " is about to be deleted, do you wish to continue ?(y/n)");
                        tempChar = Console.ReadLine()[0];
                        if(tempChar == 'y')
                        {
                            phoneBook.Remove(item);
                            Console.WriteLine("Successfully deleted.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Deleting cancelled.");
                            break;
                        }
                    }
                    if(phoneBook.Count == loopChecker)
                    {
                        Console.WriteLine("Name not found.");
                    }
                    loopChecker++;
                }
            }

            void UpdatePhoneNumber()
            {
                string tempString;
                Console.WriteLine("Name or surname: ");
                tempString = Console.ReadLine();
                foreach (Person member in phoneBook)
                {
                    if(member.name.Contains(tempString) || member.surname.Contains(tempString))
                    {
                        string tempPhoneNumber;
                        Console.WriteLine("New phone number: ");
                        tempPhoneNumber = Console.ReadLine();
                        member.phoneNumber = tempPhoneNumber;
                        Console.WriteLine("Successfully updated.");
                        break;
                    }
                }
            }

            void ListPhoneNumbers()
            {
                foreach (Person member in phoneBook)
                {
                    Console.WriteLine("Person's name :         " + member.name);
                    Console.WriteLine("Person's surname :      " + member.surname);
                    Console.WriteLine("Person's phone number : " + member.phoneNumber);
                    Console.WriteLine();
                }
            }

            void SearchPhoneNumbers()
            {
                int nameOrNumber = 0;
                string tempString;
                Console.WriteLine("(1)Search by name or surname");
                Console.WriteLine("(2)Search by phone number");
                nameOrNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the searching parameter");
                tempString = Console.ReadLine();
                foreach (Person member in phoneBook)
                {
                    if(nameOrNumber == 1)
                    {
                        if(member.name.Contains(tempString) || member.surname.Contains(tempString))
                        {
                            Console.WriteLine("Person's name :         " + member.name);
                            Console.WriteLine("Person's surname :      " + member.surname);
                            Console.WriteLine("Person's phone number : " + member.phoneNumber);
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        if(member.phoneNumber.Contains(tempString))
                        {
                            Console.WriteLine("Person's name :         " + member.name);
                            Console.WriteLine("Person's surname :      " + member.surname);
                            Console.WriteLine("Person's phone number : " + member.phoneNumber);
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
    }

    class Person
    {
        public string name;
        public string surname;
        public string phoneNumber;

        public Person(string name, string surname, string phoneNumber)
        {
            this.name = name;
            this.surname = surname;
            this.phoneNumber = phoneNumber;
        }
    }
}
