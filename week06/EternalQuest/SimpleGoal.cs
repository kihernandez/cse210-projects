using System;

namespace EternalQuest
{
    public class SimpleGoal : Goal
    {
        private bool _IsComplete;


        public SimpleGoal(string name, string description, int points) : base(name, description, points)

        {
            _IsComplete = false;
        }
        
        public override void RecordEvent()
        {
            _IsComplete = true;
        }

        public override bool IsComplete()
        {
            return _IsComplete;
        }

        public void MarkComplete()
        {
            _IsComplete = true;
        }

        public override string GetDetails()
        {
            return $"{_shortName} ({_description})";
        }

    }
}