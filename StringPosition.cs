using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class StringPosition
    {
        public static void Main(string[] args)
        {

            string str1;
            string findstr;

            Console.Write("Input a String: ");
            str1 = Console.ReadLine();

            Console.Write("Input a substring to be found in the string: ");
            findstr = Console.ReadLine();

            int index = str1.IndexOf(findstr);

            if (index < 0)

                Console.WriteLine("The substring no found  in the given string \n");

            else

                Console.WriteLine("Found '{0}' in '{1}' at position {2}",
                                  findstr, str1, index);

            Console.ReadLine();
        }
    }
}
