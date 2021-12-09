
/*Write a program in C# Sharp to print the first n natural number using recursion. 
Test Data :
How many numbers to print : 10
Expected Output :
1 2 3 4 5 6 7 8 9 10    */




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionAssignments
{
    class RecursionNatural
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("how many numbers to print: ");
            n = int.Parse(Console.ReadLine());

            PrintNatural(1, n);
            Console.ReadLine();
        }
        static int PrintNatural(int val,int n)
        {
            if(n < 1)
            {
                return val;
            }
            n--;
            Console.Write("{0} ", val);
            return PrintNatural(val + 1, n);
        }
    }
}
