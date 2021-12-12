
//Write a program in C# Sharp to display the name of the days of a week.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQAssignments_10Dec
{
    class LinqDays_10Dec
    {
        static void Main(string[] args)
        {
            string[] dayWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            var days = from WeekDay in dayWeek
                       select WeekDay;

            foreach (var WeekDay in days)
            {
                Console.WriteLine(WeekDay);
            }
            Console.ReadLine();

        }
    }
}
