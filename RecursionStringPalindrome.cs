using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionAssignments
{
    class RecursionStringPalindrome
    {
        public static void Main(string[] args)
        {
            string str1;
            bool tf;

            Console.Write(" Input a string : ");
            str1 = Console.ReadLine();
            tf = IsPalindrome(str1);
            if (tf == true)
            {
                Console.WriteLine(" The string is Palindrome");
            }
            else
            {
                Console.WriteLine(" The string is not a Palindrome");
            }
            Console.ReadLine();
        }
             public static  bool IsPalindrome(string str)
            {
                if (str.Length <= 1)
                    return true;
                else
                {
                    if (str[0] != str[str.Length - 1])
                        return false;
                    else
                        return IsPalindrome(str.Substring(1, str.Length - 2));
                }
            }

        }
    }


