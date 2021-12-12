
/*Write a program in C# Sharp to accept the members of a list through the keyboard and display the members more than a specific value.
Test Data :
Input the number of members on the List : 5
Member 0 : 10
Member 1 : 48
Member 2 : 52
Member 3 : 94
Member 4 : 63
Input the value above you want to display the members of the List : 59
Expected Output :
The numbers greater than 59 are :
94
63 */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQAssignments_10Dec
{
    class LinqAccept_10Dec
    {
        static void Main(string[] args)
        {
            int i = 0;
            int memlist, n, m;
            List<int> templist = new List<int>();

            Console.Write("Input the number of members on the List : ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                Console.Write("Member {0} : ", i);
                memlist = Convert.ToInt32(Console.ReadLine());
                templist.Add(memlist);
            }

            Console.Write("\nInput the value above you want to display the members of the List : ");
            m = Convert.ToInt32(Console.ReadLine());

            List<int> ResultList = templist.FindAll(x => x > m ? true : false);
            Console.WriteLine("\nThe numbers greater than {0} are : ", m);
            foreach (var num in ResultList)
            {
                Console.WriteLine(num);
            }

            Console.ReadLine();
        }
    }
}
