using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class StringSorting
    {
        public static void Main(string[] args)
        {
            string str;
            char[] arr;
            char ch;
            int i, j ;

            Console.Write("Input the string : ");
            str = Console.ReadLine();

            arr = str.ToCharArray(0, str.Length );

            for (i = 1; i < str.Length ; i++)
                for (j = 0; j < str.Length - i; j++)

                    if (arr[j] > arr[j + 1])
                    {
                        ch = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = ch;
                    }
            Console.Write("After sorting the string  : \n");
            foreach (char c in arr)
            {
                ch = c;
                Console.Write("{0} ", ch);
            }
            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }

    }

