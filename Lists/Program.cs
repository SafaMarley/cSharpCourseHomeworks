using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = new List<int>();

            numberList.Add(13);
            numberList.Add(24);
            numberList.Add(35);
            numberList.Add(69);
            numberList.Add(78);
            numberList.Add(18);
            numberList.Add(82);

            List<string> colorList = new List<string>();

            colorList.Add("Purple");
            colorList.Add("Blue");
            colorList.Add("Red");
            colorList.Add("Yellow");
            colorList.Add("Green");
            colorList.Add("Orange");

            Console.WriteLine(numberList.Count);
            Console.WriteLine(colorList.Count);

            foreach(int number in numberList)
            {
                Console.WriteLine(number);
            }

            foreach(string color in colorList)
            {
                Console.WriteLine(color);
            }

            numberList.Remove(18);
            colorList.Remove("Green");
            numberList.RemoveAt(1);
            colorList.RemoveAt(0);

            numberList.ForEach(number => Console.WriteLine(number));
            colorList.ForEach(color => Console.WriteLine(color));

            if(numberList.Contains(69))
            {
                Console.WriteLine("Successful search");
            }

            Console.WriteLine(colorList.BinarySearch("Red"));

            string[] animalsArray = {"Cats", "Dogs", "Birds"};
            List<string> animalsList = new List<string>(animalsArray);

            animalsList.Clear();

            List<Users> userList = new List<Users>();
            Users user0 = new Users();
            user0.Name = "Lily";
            user0.Surname = "Long";
            user0.Age = 25;

            Users user1 = new Users();
            user1.Name = "Hugh";
            user1.Surname = "Strong";
            user1.Age = 28;

            userList.Add(new Users()
            {
                Name = "Morgan",
                Surname = "Rich",
                Age = 30,
            });
            userList.Add(user0);
            userList.Add(user1);

            foreach(Users user in userList)
            {
                Console.WriteLine(user.Name);
                Console.WriteLine(user.Surname);
                Console.WriteLine(user.Age);
            }
        }
    }

    public class Users
    {
        private string name;
        private string surname;
        private int age;

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Surname
        {
            get => surname;
            set => surname = value;
        }

        public int Age
        {
            get => age;
            set => age = value;
        }
    }
}
