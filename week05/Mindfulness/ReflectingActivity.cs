using System;

namespace MindfullnessApp
{
    public class ReflectingActivity : Activity
    {
        private List<string> _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Thing of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        private List<string> _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than others when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };


        public ReflectingActivity()
        {
            _name = "Reflecting";
            _description = "This activity will help you relfect on time in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        }

        public void Run()
        {
            DisplayStartingMessage();
            Console.WriteLine("Get ready...\n");
            ShowSpinner();
            ShowCountDown(4,true);
            Console.Clear();
            GetRandomPrompt();
            DateTime endTime = DateTime.Now.AddSeconds(_duration);
            
            while (DateTime.Now < endTime)
            {
                GetRandomQuestion();
            }

            DisplayEndingMessage();
            ShowSpinner();
            Console.Clear();
        }

        private void GetRandomPrompt()
        {
            Random random = new Random();
            int index = random.Next(_prompts.Count);
            Console.WriteLine($"Consider the following prompt:\n");
            Console.WriteLine($" ---{_prompts[index]}---\n");
            Console.WriteLine("When you have something in mind, press enter to continue.");
            Console.ReadLine();
            Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
            Console.WriteLine("You may begin in:");
            ShowCountDown(3, false);
            Console.Clear();
        }

        private void GetRandomQuestion()
        {
            Random random = new Random();
            int index = random.Next(_questions.Count);
            Console.WriteLine($">{_questions[index]}");
            ShowSpinner();
        }
    }
}