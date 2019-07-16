using System;

namespace unit_07_03
{
    public class ThrowAwayGradeBook : GradeBook
    {
        public override GradeStatistics ComputeStatistics()
        {
            Console.WriteLine("ThrowAwayGradeBook::ComputeStatistics");
            
            float lowest = float.MaxValue;
            foreach (float grade in Grades)
            {
                lowest = Math.Min(grade, lowest);
            }
            Grades.Remove(lowest);
            return base.ComputeStatistics();
        }
    }
}
