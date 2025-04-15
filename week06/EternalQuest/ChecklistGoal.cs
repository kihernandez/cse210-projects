using System;

namespace EternalQuest
{
    public class ChecklistGoal : Goal
    {
        private int _amountCompleted;
        private int _target;
        private int _bonus;

        public ChecklistGoal(string name, string description, int points, int target, int bonus): base(name, description, points)
        {
            _amountCompleted = 0;
            _target = target;
            _bonus = bonus;
        }

        public override void RecordEvent()
        {
            _amountCompleted++;
        }

        public override bool IsComplete()
        {
            return _amountCompleted >= _target;
        }

        public int GetAmountCompleted()
        {
            return _amountCompleted;
        }

        public int GetTarget()
        {
            return _target;
        }
        
        public int GetBonus()
        {
            return _bonus;
        }

        public void SetAmountCompleted(int amount)
        {
            _amountCompleted = amount;
        }

        public void MarkComplete()
        {
            _amountCompleted = _target;
        }

        public override string GetDetails()
        {
            return $"{_shortName} ({_description}) --Completed {_amountCompleted}/{_target} times";
        }
    }
}