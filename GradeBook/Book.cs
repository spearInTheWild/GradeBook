using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        public Book(string name)
        {
            Name = name;
            grades = new List<double>();
        }

        public string  Name { get; set; }
                
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void ShowStatistics()
        {
            var sumOfGrades = 0.0;
            var highestGrade = double.MinValue;
            var lowestGrade = double.MaxValue;

            foreach (var grade in grades)
            {
                sumOfGrades += grade;
                highestGrade = Math.Max(grade, highestGrade);
                lowestGrade = Math.Min(grade, lowestGrade);
            }

            Console.WriteLine($"The average grade is :  {sumOfGrades / grades.Count}.");
            Console.WriteLine($"The highest grade is :  {highestGrade}.");            
            Console.WriteLine($"The lowest grade is :  {lowestGrade}.");
        }

        private List<double> grades { get; set; }        
    }
}       