using System;
using System.Data;
using System.Diagnostics.CodeAnalysis;

namespace MindfullnessApp
{
    public class ListingActivity : Activity
    {
        private List<string> _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        public ListingActivity()
        {
            _name = "Lsisting Activity";
            _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in  a certain area";
        }

        public void Run()
        {
            DisplayStartingMessage();
            Console.WriteLine("Get ready...");
            ShowSpinner();
           // ShowCountDown(3, true);
            Console.Clear();
            Console.WriteLine("List as many responses you can to the following prompt:");
            GetRandomPrompt();
            Console.WriteLine();
            ShowCountDown(5,true);
            Console.WriteLine();

            DateTime endTime = DateTime.Now.AddSeconds(_duration);
            int count = 0;

            while (DateTime.Now < endTime)
            {
                if (Console.KeyAvailable)
                {
                    Console.ReadLine();
                    count++;
                }
            }

            Console.WriteLine($"Your listed {count} items!");
            DisplayEndingMessage();
            ShowSpinner();
            Console.Clear();
        }
        private void GetRandomPrompt()
        {
            Random random = new Random();
            int index = random.Next(_prompts.Count);
            Console.WriteLine($"\n---{_prompts[index]}---");
        }
    }
}
