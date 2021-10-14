using System;
using System.Collections.Generic;

namespace ListsQuestion3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence: ");
            string sentence = Console.ReadLine();
            List<char> charList = new List<char>();

            for(int i = 0; i < sentence.Length; i++)
            {
                char charToExamine = sentence[i];
                bool isVowel = "aeiouAEIOU".IndexOf(charToExamine) >= 0;
                if(isVowel)
                {
                    charList.Add(charToExamine);
                }
            }
            charList.Sort();
            foreach (char item in charList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
