// I added the ability to have a level system for the user.
using System;


namespace EternalQuest
{


    class Program
    {
        static void Main(string[] args)
        {
            GoalManager goalManager = new GoalManager();
            goalManager.Start();
        }
    }
}