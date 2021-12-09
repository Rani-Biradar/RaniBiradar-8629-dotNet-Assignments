/*Write a program in C# Sharp to count the number of digits in a number using recursion. Go to the editor
Test Data :
Input any number : 12345
Expected Output :
The number 12345 contains number of digits : 5 */




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionAssignments
{
    class RecursionCountNum
    {
        static void Main(string[] args)
        {
            Console.Write(" Input any number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n The number {0} contains number of digits : {1} ", num, getDigits(num, 0));
            Console.ReadLine();
        }

        public static int getDigits(int n1, int nodigits)
        {
            if (n1 == 0)
                return nodigits;

            return getDigits(n1 / 10, ++nodigits);
        }
    }
}

