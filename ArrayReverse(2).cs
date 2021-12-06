using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPrint
{
    class ArrayStorePrint
    {
        public static void Main()
        {
            int i , n ;
            int[] arr = new int[10];

            Console.Write("number of element store in array: ");
            n = int.Parse(Console.ReadLine());

            Console.Write("input {0} number of elements in array : \n",n);

            for(i=0 ; i<n ; i++)
            {
                Console.Write("element-{0} : ", i);
                arr[i] = int.Parse(Console.ReadLine());

            }
            Console.Write("elements store into array are :");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", arr[i]);

            }
            Console.Write("\nElements store in array in reverse order are : ");

            for (i=n-1 ; i>=0 ; i--)
            {
                Console.Write("{0} ", arr[i]);

            }
            Console.ReadLine();

        }
    }
}