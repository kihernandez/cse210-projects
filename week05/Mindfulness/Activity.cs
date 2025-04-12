using System;

namespace MindfullnessApp
{
    public class Activity
    {
        protected string _name;
        protected string _description;
        protected int _duration;


        protected void DisplayStartingMessage()
        {
            Console.WriteLine($"Welcome to the {_name} activity!\n");
            Console.WriteLine(_description);
            Console.WriteLine("\nHow long, in seconds, would you like for your session?");
            string userResponse = Console.ReadLine();
            if (int.TryParse(userResponse, out int duration))
            {
                _duration = duration;
            }
            else
            {
                Console.WriteLine("Invalid. Please enter a number.");
            }
        }
           
        

        public void DisplayEndingMessage()
        {
            Console.WriteLine($"Excellent job ! You have completed the {_name} activity for {_duration} seconds.");
        }

        protected void ShowSpinner()
        {
           string[] spinner = { "|", "/", "-", "\\" };
            for (int i = 0; i < 10; i++)
            {
                foreach (string s in spinner)
                {
                    Console.Write(s);
                    Thread.Sleep(100);
                    Console.Write("\b");
                }
            }
            Console.WriteLine();
        }

        public void ShowCountDown(int seconds,bool showMessage)
        {
            if (showMessage)
            {
                Console.WriteLine("Starting in...");
            }

            for (int i = seconds; i > 0; i--)
            {
                Console.Write($"{i}...");
                Thread.Sleep(1000);
            }

            Console.WriteLine();
        }
    }   


}