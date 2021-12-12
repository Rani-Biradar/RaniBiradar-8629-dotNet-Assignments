/*
Write a program in C# Sharp to find the +ve numbers from a list of numbers using two where conditions in LINQ Query.
Expected Output:
The numbers within the range of 1 to 11 are :
1 3 6 9 10 */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQAssignments_10Dec
{
    class LinqPositiveNum_10Dec
    {
        static void Main(string[] args)
        {
            int[] n1 = new int[10] { 1, 3, -2, -4, -7, 8, 11, 12, 14, 9 };

            var nQuery =
           from Num in n1
           where Num > 0
           where Num < 12
           select Num;

            Console.Write("\nThe numbers within the range of 1 to 11 are: ");

            foreach (int Num in nQuery)
            {
                Console.Write("{0} ", Num);
            }
            Console.ReadLine();
        }
    }
}
