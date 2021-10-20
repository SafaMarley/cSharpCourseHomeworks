using System;
using System.Collections.Generic;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = -1;

            Dictionary<int, string> projectMembers = new Dictionary<int, string>();
            projectMembers.Add(0, "Safa");
            projectMembers.Add(1, "Okan");
            projectMembers.Add(2, "Etem");

            List<Cards> ToDoLine = new List<Cards>();
            List<Cards> InProgressLine = new List<Cards>();
            List<Cards> Done = new List<Cards>();

            while(choice != 0)
            {
                Console.WriteLine("Choose an option: ");
            
                Console.WriteLine("1-Add a card");
                Console.WriteLine("2-Update a card");
                Console.WriteLine("3-Delete a card");
                Console.WriteLine("4-Move a card");
                Console.WriteLine("5-List the board");
                Console.WriteLine("0-Exit");
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                if(choice == 0)
                {
                    Console.WriteLine("Bye bye!");
                }

                else if(choice == 1)
                {
                    AddACard();
                }

                else if(choice == 2)
                {
                    UpdateACard();
                }

                else if(choice == 3)
                {
                    DeleteACard();
                }

                else if(choice == 4)
                {
                    MoveACard();
                }

                else if(choice == 5)
                {
                    ListTheBoard();
                }
            }

            void AddACard()
            {
                string tempTitle;
                string tempContent;
                int tempToWhom;
                int tempVolume;
                Console.WriteLine("Card's title: ");
                tempTitle = Console.ReadLine();
                Console.WriteLine("Card's content: ");
                tempContent = Console.ReadLine();
                Console.WriteLine("To Whom: (ID)");
                tempToWhom = int.Parse(Console.ReadLine());
                Console.WriteLine("Card's volume: (1)XS, (2)S, (3)M, (4)L, (5)XL");
                tempVolume = int.Parse(Console.ReadLine());
                Cards cardToAdd = new Cards(tempTitle, tempContent, tempToWhom, tempVolume);
                ToDoLine.Add(cardToAdd);
            }

            void UpdateACard()
            {
                string cardTitle;
                Console.WriteLine("Enter the title of the card you want to update: ");
                cardTitle = Console.ReadLine();

                foreach (Cards card in ToDoLine)
                {
                    if(card.title.Contains(cardTitle))
                    {
                        string veryTempTitle;
                        Console.WriteLine("Enter a new title: ");
                        veryTempTitle = Console.ReadLine();
                        card.title = veryTempTitle;
                        break;
                    }
                }

                foreach (Cards card in InProgressLine)
                {
                    if(card.title.Contains(cardTitle))
                    {
                        string veryTempTitle;
                        Console.WriteLine("Enter a new title: ");
                        veryTempTitle = Console.ReadLine();
                        card.title = veryTempTitle;
                        break;
                    }
                }

                foreach (Cards card in Done)
                {
                    if(card.title.Contains(cardTitle))
                    {
                        string veryTempTitle;
                        Console.WriteLine("Enter a new title: ");
                        veryTempTitle = Console.ReadLine();
                        card.title = veryTempTitle;
                        break;                        
                    }
                }

            }

            void DeleteACard()
            {
                bool cardFound = false;
                string tempTitle;
                Console.WriteLine("Enter the title of the card you want to remove: ");
                tempTitle = Console.ReadLine();

                foreach (Cards card in ToDoLine)
                {
                    if(card.title.Contains(tempTitle))
                    {
                        ToDoLine.Remove(card);
                        cardFound = true;
                        break;
                    }
                }


                foreach (Cards card in InProgressLine)
                {
                    if(card.title.Contains(tempTitle))
                    {
                        InProgressLine.Remove(card);
                        cardFound = true;
                        break;
                    }
                }

                foreach (Cards card in Done)
                {
                    if(card.title.Contains(tempTitle))
                    {
                        Done.Remove(card);
                        cardFound = true;
                        break;
                    }
                }

                if(!cardFound)
                {
                    Console.WriteLine("Card not found.");
                }
            }

            void MoveACard()
            {
                bool cardFound = false;
                string tempTitle;
                Console.WriteLine("Enter the title of the card you want to remove: ");
                tempTitle = Console.ReadLine();
                foreach (Cards card in ToDoLine)
                {
                    if(card.title.Contains(tempTitle))
                    {
                        int choice;
                        Console.WriteLine("Choose a line to move (1)To do line (2)In progress line (3)Done");
                        choice = int.Parse(Console.ReadLine());
                        if(choice == 1)
                        {
                            
                        }
                        else if(choice == 2)
                        {
                            ToDoLine.Remove(card);
                            InProgressLine.Add(card);
                        }
                        else if(choice == 3)
                        {
                            ToDoLine.Remove(card);
                            Done.Add(card);
                        }
                        cardFound = true;
                        break;
                    }
                }


                foreach (Cards card in InProgressLine)
                {
                    if(card.title.Contains(tempTitle))
                    {
                        int choice;
                        Console.WriteLine("Choose a line to move (1)To do line (2)In progress line (3)Done");
                        choice = int.Parse(Console.ReadLine());
                        if(choice == 1)
                        {
                            InProgressLine.Remove(card);
                            ToDoLine.Add(card);
                        }
                        else if(choice == 2)
                        {
                            
                        }
                        else if(choice == 3)
                        {
                            InProgressLine.Remove(card);
                            Done.Add(card);
                        }
                        cardFound = true;
                        break;
                    }
                }

                foreach (Cards card in Done)
                {
                    if(card.title.Contains(tempTitle))
                    {
                        int choice;
                        Console.WriteLine("Choose a line to move (1)To do line (2)In progress line (3)Done");
                        choice = int.Parse(Console.ReadLine());
                        if(choice == 1)
                        {
                            Done.Remove(card);
                            ToDoLine.Add(card);
                        }
                        else if(choice == 2)
                        {
                            Done.Remove(card);
                            InProgressLine.Add(card);
                        }
                        else if(choice == 3)
                        {

                        }
                        cardFound = true;
                    }
                }

                if(!cardFound)
                {
                    Console.WriteLine("Card not found.");
                }
            }

            void ListTheBoard()
            {
                Console.WriteLine("To Do Line");
                Console.WriteLine("**********");
                foreach (Cards card in ToDoLine)
                {
                    Console.WriteLine("Title: " + card.title);
                    Console.WriteLine("Content: " + card.content);
                    Console.WriteLine("To whom: " + projectMembers[card.toWhom]);
                    Console.WriteLine("Volume: " + card.volume);
                    Console.WriteLine();
                }

                Console.WriteLine("In Progress Line");
                Console.WriteLine("****************");
                foreach (Cards card in InProgressLine)
                {
                    Console.WriteLine("Title: " + card.title);
                    Console.WriteLine("Content: " + card.content);
                    Console.WriteLine("To whom: " + projectMembers[card.toWhom]);
                    Console.WriteLine("Volume: " + card.volume);
                    Console.WriteLine();
                }

                Console.WriteLine("Done");
                Console.WriteLine("****");
                foreach (Cards card in Done)
                {
                    Console.WriteLine("Title: " + card.title);
                    Console.WriteLine("Content: " + card.content);
                    Console.WriteLine("To whom: " + projectMembers[card.toWhom]);
                    Console.WriteLine("Volume: " + card.volume);
                    Console.WriteLine();
                }
            }
        }
    }

    class Cards
    {
        public string title;
        public string content;
        public int toWhom;
        public Volume volume;

        public Cards(string title, string content, int toWhom, int volume)
        {
            this.title = title;
            this.content = content;
            this.toWhom = toWhom;
            this.volume = (Volume)volume;
        }
    }

    enum Volume
    {
        XS = 1,
        S,
        M,
        L,
        XL
    }
}
