
/*Write a program in C# Sharp to create a list of numbers and display the numbers greater than 80 as output
Test Data :
The members of the list are :
55 200 740 76 230 482 95
Expected Output :
The numbers greater than 80 are :
200
740
230
482
95 */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQAssignments_10Dec
{
    class LinqGreaterNumber_10Dec
    {
        static void Main(string[] args)
        {
            
            List<int> templist = new List<int>();
            templist.Add(55);
            templist.Add(200);
            templist.Add(740);
            templist.Add(76);
            templist.Add(230);
            templist.Add(482);
            templist.Add(95);

            Console.WriteLine("\nThe members of the list are : ");
            foreach (var lstnum in templist)
            {
                Console.Write(lstnum + " ");
            }

            List<int> ResultList = templist.FindAll(x => x > 80 ? true : false);

            Console.WriteLine("\n\nThe numbers greater than 80 are : ");
            foreach (var num in ResultList)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();

        }
    }
}
