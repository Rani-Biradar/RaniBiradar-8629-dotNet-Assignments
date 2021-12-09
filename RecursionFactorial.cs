using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionAssignments
{
    class RecursionFactorial
    {
        public static void Main(string[] args)
        {
            Console.Write(" Input any positive number : ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            int fact = Factorial(n1);

            Console.WriteLine(" The factorial of {0} is : {1} ", n1, fact);
            Console.ReadLine();
        }

        private static int  Factorial(int n1)
        {
            if (n1 == 0)
            {
                return 1;
            }
            return n1 * Factorial(n1 - 1);
        }
    }
}
