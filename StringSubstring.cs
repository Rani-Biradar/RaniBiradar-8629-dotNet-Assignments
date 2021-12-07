using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class StringSubstring
    {
        public static void Main(string[] args)
        {
            string str;
            char[] arr;
            int pos ,len, c = 0;


            Console.Write("Input the string : ");
            str = Console.ReadLine();
            arr = str.ToCharArray(0, str.Length );

            Console.Write("Input the position to start extraction :");
            pos = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the length of substring :");
            len = Convert.ToInt32(Console.ReadLine());

            Console.Write("The substring retrieve from the string is : ");
            while (c < len)
            {
                Console.Write(arr[pos + c - 1]);
                c++;
            }
           // Console.Write("\n\n");
            Console.ReadLine();
        }
    }
}
