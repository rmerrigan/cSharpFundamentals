using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 34.1;
            double y = 2.9;
            var result = x + y;
            Console.WriteLine($"Hello, {result}");

            var numbers = new[] {69, 69, 69, 69};
            int sum = 0;

            foreach (var number in numbers)
            {
                sum+=number;
            }
            System.Console.WriteLine($"Hello, {sum}");

            var grades = new List<double>() { 12.7, 10.3, 6.1, 4.1}; 
            grades.Add(56.1);
            var listSum = 0.0;
            foreach (var grade in grades)
            {
                listSum += grade;
            }
            System.Console.WriteLine($"Hello, {listSum:N1}");
            var gradeAverage = listSum/grades.Count;
            System.Console.WriteLine($"Hello, {gradeAverage:N7}");
        }
    }
}
