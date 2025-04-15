using System;
using System.Collections.Generic;
using System.IO;

namespace EternalQuest
{
    public class GoalManager
    {
        private List<Goal> _goals = new List<Goal>();
        private int _score;

        public void Start()
        {
            string choice = "";

            while (choice != "6")
            {
                Console.WriteLine();
                DisplayScore();
                Console.WriteLine();
                Console.WriteLine("Menu Options:");
                Console.WriteLine("1. Create New Goal");
                Console.WriteLine("2. List Goals");
                Console.WriteLine("3. Save Goals");
                Console.WriteLine("4. Load Goals");
                Console.WriteLine("5. Record Event");
                Console.WriteLine("6. Quit");
                Console.WriteLine("Select a choice from the menu: ");
                choice = Console.ReadLine();

                if (choice == "1")
                {

                    CreateGoal();
                }

                else if (choice == "2")
                {
                    ListGoals();
                    DisplayScore();

                }

                else if (choice == "3")
                {
                    Console.WriteLine("What is the filename for the goal file?");
                    string filename = Console.ReadLine();
                    SaveGoals(filename);

                }

                else if (choice == "4")
                {
                    Console.WriteLine("What is the filename for the goal file?");
                    string filename = Console.ReadLine();
                    LoadGoals(filename);
                }

                else if (choice == "5")
                {
                    RecordEvent();
                }

                else if (choice == "6")
                {
                    Console.WriteLine("Thank you for using the Eternal Quest Program!");
                    break;
                }

                else
                {
                    Console.WriteLine("Please select a valid choice from the menu.");
                }
            }
        }



        public void CreateGoal()
        {
            Console.WriteLine("The types of Goals are:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.WriteLine("Which type of goal would you like to create? ");
            string choice = Console.ReadLine();

            Console.WriteLine("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.WriteLine("What is a short description of your goal? ");
            string description = Console.ReadLine();
            Console.WriteLine("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());

            if (choice == "1")
            {
                _goals.Add(new SimpleGoal(name, description, points));
            }

            else if (choice == "2")
            {
                _goals.Add(new EternalGoal(name, description, points));
            }

            else if (choice == "3")
            {
                Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());
                Console.WriteLine("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
            }

        }

        public void RecordEvent()
        {
            Console.WriteLine("The goals are:");
           for (int i = 0; i < _goals.Count; i++)
           {
            Console.WriteLine($"{i+ 1}. {_goals[i].GetName()}");
           }
           Console.WriteLine("Which goal did you accomplish? (Enter the number)");

            int goalIndex = int.Parse(Console.ReadLine()) -1;  
            if (goalIndex >= 0 && goalIndex < _goals.Count)
            {
                Goal goal = _goals[goalIndex];
                goal.RecordEvent();
                _score += goal.GetPoints();

                if (goal is ChecklistGoal checklistGoal && checklistGoal.IsComplete())
                {
                    _score += checklistGoal.GetBonus();
                }
                
                Console.WriteLine($"Congratulations! You have earned {goal.GetPoints()} points!");
                Console.WriteLine($"You now have {_score} points!");
            }

            else 
            {
                Console.WriteLine("Invalid goal, please select a valid goal.");
            }
        }
        

        public void ListGoals()
        {
            Console.WriteLine("Your Goals are:");
            foreach (Goal goal in _goals)
            {
                if (goal is ChecklistGoal checklistGoal)
                {
                    string status = checklistGoal.IsComplete() ? "[ x ]" : "[ ]";
                    Console.WriteLine($"{status} {goal.GetName()} , {goal.GetDescription()} - Completed {checklistGoal.GetAmountCompleted()}/ {checklistGoal.GetTarget()} times");
                }

                else if (goal is SimpleGoal simpleGoal)
                {
                    string status = simpleGoal.IsComplete() ? "[ x ]" : "[ ]";
                    Console.WriteLine($"{status} {goal.GetName()} , {goal.GetDescription()}");
                }

                else
                {   
                    
                    Console.WriteLine($"[ ] {goal.GetName()} , {goal.GetDescription()}");
                }

            }
        }

        public void DisplayScore()
        {
            Console.WriteLine($"You have {_score} points.");
            int level = _score / 100 + 1;
            string levelTitle = "";

            if (level == 1)
            {
                levelTitle = "Beginner";
            }

            else if (level == 2)
            {
                levelTitle = "Bronze League";
            }

            else if (level == 3)
            {
                levelTitle = "Silver League";
            }
            else if (level == 4)
            {
                levelTitle = "Gold League";
            }
            else if (level == 5)
            {
                levelTitle = "Platinum League";
            }
            else if (level == 6)
            {
                levelTitle = "Diamond League";
            }
            Console.WriteLine($"You are level {level}: {levelTitle}");
        }
        



        public void SaveGoals(string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine(_score);
                foreach (Goal goal in _goals)
                {
                    if (goal is ChecklistGoal checklistGoal)
                    {
                    writer.WriteLine($"{goal.GetType().Name}, {goal.GetName()}, {goal.GetDescription()}, {goal.GetPoints()}, {checklistGoal.GetBonus()}, {checklistGoal.GetTarget()}, {checklistGoal.GetAmountCompleted()}, {checklistGoal.IsComplete()}");
                    }

                    else if (goal is SimpleGoal simpleGoal)
                    {
                        writer.WriteLine($"{goal.GetType().Name}, {goal.GetName()}, {goal.GetDescription()}, {goal.GetPoints()}, {simpleGoal.IsComplete()}");
                    }

                    else writer.WriteLine($"{goal.GetType().Name}, {goal.GetName()}, {goal.GetDescription()}, {goal.GetPoints()}, false");
                }
            }
        }

        public void LoadGoals(string filename)
        {
            _goals.Clear();
            using (StreamReader reader = new StreamReader(filename))
            {
                if (int.TryParse(reader.ReadLine(), out int loadedScore))
                {
                    _score = loadedScore;
                }

                else 
                {
                    Console.WriteLine("Could not load score");
                    _score = 0;
                }
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] parts = line.Split(',');


                    string type = parts[0];
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);

                    if (type == "SimpleGoal")
                    {
                        bool isComplete = bool.Parse(parts[4]);
                        SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                        if (isComplete)
                        {
                            simpleGoal.MarkComplete();
                        }
                        _goals.Add(simpleGoal);
                    }

                    else if (type == "EternalGoal")
                    {
                        EternalGoal eternalGoal = new EternalGoal(name, description, points);
                        _goals.Add(eternalGoal);

                    }

                    else if (type == "ChecklistGoal")
                    {
                        int bonus = int.Parse(parts[4]);
                        int target = int.Parse(parts[5]);
                        int amountCompleted = int.Parse(parts[6]);
                        ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
                        checklistGoal.SetAmountCompleted(amountCompleted);
                        if (amountCompleted >= target)
                        {
                            checklistGoal.MarkComplete();
                        }
                        _goals.Add(checklistGoal);
                    }
                }
            }
        }
    }
}