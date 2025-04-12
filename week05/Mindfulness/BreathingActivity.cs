using System;

namespace MindfullnessApp
{
    public class BreathingActivity : Activity
    {
        public BreathingActivity()
        {
            _name = "Breathing Activity";
            _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";

        }


        public void Run()
        {
            DisplayStartingMessage();
            Console.WriteLine("Get ready...\n");
            ShowSpinner();
            ShowCountDown(3, true);

            int cycleCount = 3;
            int cycleDuration = _duration / cycleCount;
            

            for (int i = 0; i < cycleCount; i++)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Breathe in...");
                ShowCountDown(cycleDuration / 2, false);
                Console.WriteLine("Breathe out...");
                ShowCountDown(cycleDuration / 2, false);

                Console.WriteLine();
            }

            DisplayEndingMessage();
            ShowSpinner();
            Console.Clear();
        }
    }
}