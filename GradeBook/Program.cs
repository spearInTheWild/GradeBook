using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Matt's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.1);
            book.AddGrade(85.5);
            book.AddGrade(100);
            book.ShowStatistics();
        }
    }
}
