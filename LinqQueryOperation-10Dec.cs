/*Write a program in C# Sharp to shows how the three parts of a query operation execute. 
Expected Output:
The numbers which produce the remainder 0 after divided by 2 are :
0 2 4 6 8 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQAssignments_10Dec
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n1 = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var nQuery =
           from Num in n1
           where (Num % 2) == 0
           select Num;

            Console.Write("\nThe numbers which produce the remainder 0 after divided by 2 are : ");
            foreach (int Num in nQuery)
            {
                Console.Write("{0} ", Num);
            }
            Console.ReadLine();

        }
    }
}
