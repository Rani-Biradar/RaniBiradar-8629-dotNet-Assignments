using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class StringAppeared
    {
        public static void Main(string[] args)
        {
            string str1;
            string findstring;
            int strt = 0;
            int cnt = -1;
            int idx = -1;

            Console.Write("Input the original string : ");
            str1 = Console.ReadLine();

            Console.Write("Input the string to be searched for : ");
            findstring = Console.ReadLine();


            while (strt != -1)
            {
                strt = str1.IndexOf(findstring, idx + 1);
                cnt += 1;
                idx = strt;
            }
            Console.Write("The string '{0}' occurs {1} times.\n", findstring,cnt);
            Console.ReadLine();
        }
    }
    }

