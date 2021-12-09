

//Write a program in C# Sharp to check whether a number is prime or not using recursion.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionAssignments
{
    class RecursionPrime
    {
        static void Main(string[] args)
        {
            int n1, primeNo;

            Console.Write(" Input any positive number : ");
            n1 = Convert.ToInt32(Console.ReadLine());

            primeNo = checkForPrime(n1, n1 / 2);

            if (primeNo == 1)
                Console.Write(" The number {0} is a prime number", n1);
            else
                Console.WriteLine(" The number {0} is not a prime number ", n1);
            Console.ReadLine();
            
        }
        static int checkForPrime(int n1, int i)
        {
            if (i == 1)
            {
                return 1;
            }
            else
            {
                if (n1 % i == 0)
                    return 0;
                else
                    return checkForPrime(n1, i - 1);

            }
        }
    }
}

