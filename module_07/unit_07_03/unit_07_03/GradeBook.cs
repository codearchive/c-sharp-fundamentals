using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace unit_07_03
{
    public class GradeBook : GradeTracker
    {
        public GradeBook()
        {
            _name = "Empty";
            Grades = new List<float>();
        }

        public override GradeStatistics ComputeStatistics()
        {
            Console.WriteLine("GradeBook::ComputeStatistics");
            GradeStatistics stats = new GradeStatistics();

            float sum = 0;
            foreach (float grade in Grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }
            stats.AverageGrade = sum / Grades.Count;

            return stats;
        }

        public override void WriteGrades(TextWriter destination)
        {
            for (int i = 0; i < Grades.Count; i++)
            {
                destination.WriteLine(Grades[i]);
            }
        }

        public override void AddGrade(float grade)
        {
            Grades.Add(grade);
        }

        public override IEnumerator GetEnumerator()
        {
            return Grades.GetEnumerator();
        }
        protected List<float> Grades;
    }
}