
/*Write a program in C# Sharp to display numbers, multiplication of number with frequency and frequency of a number of giving array. 
Test Data :
The numbers in the array are :
5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2
Expected Output :
Number Number*Frequency Frequency
------------------------------------------------
5 15 3
1 1 1
9 9 1
2 4 2 */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQAssignments_10Dec
{
    class LinqDisplay_10Dec
    {

        static void Main(string[] args)
        {
            int[] nums = new int[] { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };

            Console.Write("The numbers in the array are : \n");
            Console.Write("  5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 ");


            var m = from x in nums
                    group x by x into y
                    select y;
            Console.Write("\nNumber" + " " + "Number*Frequency" + " " + "Frequency" + "\n");


            foreach (var arrEle in m)
            {
                Console.WriteLine(arrEle.Key + " " + arrEle.Sum() + " " + arrEle.Count());
            }
            Console.ReadLine();

        }
    }
}
