
/*  Write a program in C# Sharp to find the sum of first n natural numbers using recursion. 
Test Data :
How many numbers to sum : 10
Expected Output :
The sum of first 10 natural numbers is : 55   */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionAssignments
{
    class RecursionSum
    {

        static void Main(string[] args)
        {
            Console.Write(" How many numbers to sum : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write(" The sum of first {0} natural numbers is : {1}", n, Sum(1, n));
            Console.ReadLine();
        }
     

        static int Sum(int min, int n)
        {
            if (n == min)
                return n;
            return n+ Sum(min, n- 1);
        }
    }

}

