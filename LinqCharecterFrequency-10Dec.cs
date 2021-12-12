


/*Write a program in C# Sharp to display the characters and frequency of character from giving string.
Test Data:
Input the string: apple
Expected Output:
The frequency of the characters are :
Character a: 1 times
Character p: 2 times
Character l: 1 times
Character e: 1 times */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQAssignments_10Dec
{
    class LinqCharecterFrequency_10Dec
    {
        static void Main(string[] args)
        {
            string str;

            Console.Write("Input the string : ");
            str = Console.ReadLine();

            var FreQ = from x in str
                       group x by x into y
                       select y;

            Console.Write("The frequency of the characters are :\n");

            foreach (var ArrEle in FreQ)
            {
                Console.Write("Character " + ArrEle.Key + ": " + ArrEle.Count() + " times\n");
               
            }
            Console.ReadLine();
        }
    }
}
    

