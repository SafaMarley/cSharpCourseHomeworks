using System;
using System.Collections.Generic;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> users = new Dictionary<int, string>();
            
            users.Add(3, "Safa");
            users.Add(6, "Okan");
            users.Add(9, "Etem");
            users.Add(5, "Thomas");

            Console.WriteLine(users.Count);
            foreach (var user in users)
            {
                Console.WriteLine(user);
            }

            Console.WriteLine(users[5]);

            Console.WriteLine(users.ContainsKey(9));
            Console.WriteLine(users.ContainsValue("Safa"));

            users.Remove(6);
            
            foreach (var user in users)
            {
                Console.WriteLine(user.Value);
            }
        }
    }
}
