using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPrint
{
    class SumOfArray
    {
        public static void Main()
        {
            int i, n, Sum=0 ;
            int[] arr = new int[10];

            Console.Write("number of element store in array: ");
            n = int.Parse(Console.ReadLine());

            Console.Write("input {0} number of elements in array : \n",n);

            for (i = 0; i < n; i++)
            {
                Console.Write("element-{0} : ", i);
                arr[i] = int.Parse(Console.ReadLine());
                
            }

            for(i=0 ; i<n ; i++)
            {
                Sum = Sum + arr[i];
            }
            Console.Write("Enter sum of all elements stored in array is: {0} ", Sum);
            Console.ReadLine();
        }
    }
}
