using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPrint
{
    class ArrayOddEven_10_
    {
        public static void Main()
        {
            int i, j = 0, k = 0, n;
            int[] arr1 = new int[10];
            int[] arr2 = new int[10];
            int[] arr3 = new int[10];

            Console.Write("number of element store in array: ");
            n = int.Parse(Console.ReadLine());

            Console.Write("input {0} number of elements in array : \n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element-{0} : ", i);
                arr1[i] = int.Parse(Console.ReadLine());

            }
            for (i = 0; i < n; i++)
            {
                if (arr1[i] % 2 == 0)
                {
                    arr2[j] = arr1[i];
                    j++;
                }

                else
                {
                    arr3[k] = arr1[i];
                    k++;
                }
            }
            Console.Write("even elements are: ");
                for (i = 0; i < j; i++)
            {
                Console.Write("{0} ", arr2[i]);
            }
            Console.Write("\nodd elements are: ");
                for (i = 0; i < k; i++)
            {
                Console.Write("{0} ", arr3[i]);
            }
            Console.ReadLine();

        }
    }
}
