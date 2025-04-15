using System;

namespace EternalQuest
{
    public class EternalGoal : Goal
    {
        public EternalGoal(string name, string description, int points) : base(name, description, points)
        {

        }
     
        public override void RecordEvent()
        {

        }

        public override bool IsComplete()
        {
            return false;
        }

        public override string GetDetails()
        {
            return $"{_shortName} ({_description})";
        }
    }
}