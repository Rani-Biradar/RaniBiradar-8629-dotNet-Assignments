
/* Write a program in C# Sharp to print numbers from n to 1 using recursion. Go to the editor
Test Data :
How many numbers to print : 10
Expected Output :
10 9 8 7 6 5 4 3 2 1   */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionAssignments
{
    class RecursionPrintNumbers
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("how many numbers to print: ");
            n = int.Parse(Console.ReadLine());

            PrintNatural(n ,1);
            Console.ReadLine();
        }
        static int PrintNatural(int n ,int val)
        {
            if (n < 1)
            {
                return val;
            }
           
            Console.Write("{0} ", n);
            n--;
            return PrintNatural(n,val);
        }
    }
}
    

