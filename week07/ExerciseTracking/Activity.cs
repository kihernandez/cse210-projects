using System;

namespace ExerciseTracking
{
    public class Activity
    {
        private string _date;
        private int _length;

        public Activity(string date, int length)
        {
            _date = date;
            _length = length;
            
        }

        public string GetDate()
        {
            return _date;
        }
        
        public double GetLength()
        {
            return _length;
        }

        public virtual double GetDistance()
        {
            return 0.0;
        }

        public virtual double GetSpeed()
        {
            return 0.0;
        }

        public virtual double GetPace()
        {
            return 0.0;
        }

        public virtual string GetSummary()
        {
            return $"{GetDate()} {GetType().Name} ({GetLength()} min), Distance: {GetDistance()} km, Speed: {GetSpeed()} km/h, Pace: {GetPace()} min/km";
        }

    }
}