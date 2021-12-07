using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class StringMaxOccurence
    {

        static void Main(string[] args)
        {
            string str;
            int[] ch = new int[255];
            int i = 0, max ;
            int ascii;

            Console.Write("Enter the String :");
            str = Console.ReadLine();

            for (i = 0; i < 255; i++)  
            {
                ch[i] = 0;
            }

            i = 0;
            while (i < str.Length)
            {
                ascii = (int)str[i];
                ch[ascii] += 1;

                i++;
            }
            max = 0;
            for (i = 0; i < 255; i++)
            {
                if (i != 32)
                {
                    if (ch[i] > ch[max])
                        max = i;
                }
            }
            Console.Write("The Maximum Occurence of character '{0}' is appearing for number of times : {1} ", (char)max, ch[max]);
            Console.ReadLine();
        }
    }
    }
