/*Write a program in C# Sharp to find the number of an array and the square of each number. 
Expected Output :
{ Number = 9, SqrNo = 81 }
{ Number = 8, SqrNo = 64 }
{ Number = 6, SqrNo = 36 }
{ Number = 5, SqrNo = 25 }  */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQAssignments_10Dec
{
    class LinqArraySquare_10Dec
    {
        static void Main(string[] args)
        {
            int[] n1 = new int[6] { 3, 9, 2, 8, 6, 5 };
           
            var sqNo = from  Number in n1
                       let SqrNo = Number * Number
                       where SqrNo > 20
                       select new { Number, SqrNo };

            foreach (var a in sqNo)

                Console.WriteLine(a);

            Console.ReadLine();
        }
    }
}
