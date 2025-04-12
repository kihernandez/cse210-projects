// Added the ability to keep a log of every activity

using System;

namespace MindfullnessApp
{


    class Program
    {
        static int _breathingCount = 0;
        static int _reflectingCount = 0;
        static int _listingCount = 0;


        static void Main(string[] args)
        {
            string userResponse = "";

            while (userResponse != "4")
            {
                DisplayActivitiesLog();
                Console.WriteLine();
                Console.WriteLine("Menu Options:");
                Console.WriteLine("1. Start Breathing Activity");
                Console.WriteLine("2. Start Reflecting Activity");
                Console.WriteLine("3. Start Listing Activity");
                Console.WriteLine("4. Quit");
                Console.WriteLine("Please select a number choice from the menu: ");
                userResponse = Console.ReadLine();


                {
                    if (userResponse == "1")
                    {
                        Console.Clear();
                        BreathingActivity breathingActivity = new BreathingActivity();
                        breathingActivity.Run();
                        _breathingCount++;
                        
                    }

                    else if (userResponse == "2")
                    {
                        Console.Clear();
                        ReflectingActivity reflectingActivity = new ReflectingActivity();
                        reflectingActivity.Run();
                        _reflectingCount++;
                        

                    }

                    else if (userResponse == "3")
                    {
                        Console.Clear();
                        ListingActivity listingActivity = new ListingActivity();
                        listingActivity.Run();
                        _listingCount++;
                    
                    }

                    else if (userResponse == "4")
                    {
                        Console.WriteLine("Have a great Day! Thank you for using the Mindfulness App!");
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Invalid choice, please try again");
                    }
                }
            }

            static void DisplayActivitiesLog()
            {
                Console.WriteLine("Activity Log:");
                Console.WriteLine($"Breathing Activity: {_breathingCount} time(s)");
                Console.WriteLine($"Breathing Activity: {_reflectingCount} time(s)");
                Console.WriteLine($"Breathing Activity: {_listingCount} time(s)");
            }
        }
    

    }
}