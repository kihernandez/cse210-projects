using System;

namespace JournalProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal userJournal = new Journal();
            
            bool openJournal = true;
            while (openJournal)
        
            {   
                Console.WriteLine("\nWelcome to the Journal App!");
                Console.WriteLine("Please select one of the following choices\n");
                Console.WriteLine("Journal Menu");
                Console.WriteLine("1. Write New Entry");
                Console.WriteLine("2. Display Entries");
                Console.WriteLine("3. Save Entries");
                Console.WriteLine("4. Load Entries");
                Console.WriteLine("5. Quit");

                Console.Write("What would you like to do? ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    userJournal.TypeEntry();
                }

                else if (choice =="2")
                {
                    userJournal.DisplayEntry();
                }

                else if (choice =="3")
                {
                    userJournal.SaveEntry();

                }

                else if (choice =="4")
                {
                    userJournal.LoadEntry();
                }

                else if (choice == "5")
                {
                    openJournal = false;
                    Console.WriteLine("Have a wonderful day! See you again next time!");
                }

                else 
                {
                    Console.WriteLine("Invalid Choice, Please Try again !");
                }
            }    
        }
    }
}
