using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPrint
{
    class ArrayMinmax_9_
    {
        public static void Main()
        {
            int[] arr = new int[100];
            int i, mx, mn, n;


            Console.Write("Input the number of elements to be stored in the array :");
            n = int.Parse(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            mx = arr[0];
            mn = arr[0];

            for (i = 1; i < n; i++)
            {
                if (arr[i] > mx)
                {
                    mx = arr[i];
                }

                if (arr[i] < mn)
                {
                    mn = arr[i];
                }
            }
            Console.Write("Maximum element is : {0}", mx);
            Console.Write("\nMinimum element is : {0}", mn);
            Console.ReadLine();

        }
    }
}
