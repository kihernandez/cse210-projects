// Added the ability to randomly select a scripture from the list of scriptures

using System;
using System.Data.Common;
namespace ScriptureMemorizer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Scripture> scriptures = new List<Scripture>
            {
                new Scripture(new Reference("2 Timothy", 3,16),"All scripture is given by inspiration of God, and is profitable for doctrine for doctrine for reproof for correction for instruction in righteousness"),
                new Scripture(new Reference("Galatians", 5, 22),"But the fruit of the Spirit is love joy peace longsuffering gentleness goodness faith."),
                new Scripture(new Reference("Isaiah", 40, 31),"But they that wait upon the LORD shall renew their strength they shall mount up with wings as eagles they shall run and not be weary and they shall walk and not faint."),
                new Scripture(new Reference("Phillipians", 4, 13),"I can do all things thorugh Christ which strenegtheneth me.")
            };

            Random random = new Random();
            Scripture selectedScripture = scriptures[random.Next(scriptures.Count)];
            while (true)
            {
                Console.Clear();
                Console.WriteLine(selectedScripture.GetText());
                Console.WriteLine("\nPress enter to continue or type 'quit' to exit.");

                string userResponse = Console.ReadLine();
                if (userResponse.ToLower() == "quit") { break; }
                else if (string.IsNullOrEmpty(userResponse))
                {
                    if (!selectedScripture.HideWord())
                    {
                        Console.Clear(); Console.WriteLine("Great job! you have memorized the scripture.");
                        Console.WriteLine(selectedScripture.GetText());
                        break;
                    }
                }
                else { Console.WriteLine("Invalid input. Please try again."); }
            }
        }
    }
}


