
/*Write a program in C# Sharp to display the individual digits of a given number using recursion. 
Test Data :
Input any number : 1234
Expected Output :
The digits in the number 1234 are : 1 2 3 4 */




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionAssignments
{
    class RecursionDisplay
    {
        static void Main(string[] args)
        {
            Console.Write(" Input any number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.Write(" The digits in the number {0} are : ", num);
            separateDigits(num);
            Console.ReadLine();
        }

        static void separateDigits(int n)
        {
            if (n < 10)
            {
                Console.Write("{0}  ", n);
                return;
            }


            separateDigits(n / 10);
            Console.Write(" {0} ", n % 10);
           
        }
    }
}
