using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPrint
{
    class ArrayCopy_4_
    {
        public static void Main()
        {
            int i, n;
            int[] arr1 = new int[50];
            int[] arr2 = new int[50];

            Console.Write(" Enter number of element store in array: ");
            n = int.Parse(Console.ReadLine());

            Console.Write("input {0} number of elements in array : \n", n);

            for (i = 0; i < n; i++)
            {
                Console.Write("element-{0} : ", i);
                arr1[i] = int.Parse(Console.ReadLine());

            }


            for (i = 0; i < n; i++)
            {
                arr2[i] = arr1[i];
            }

            Console.Write("elements stored in first array are ");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", arr1[i]);

            }

            Console.Write("\nelements copied into second  array are ");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", arr2[i]);

            }
            Console.ReadLine();

        }
    }
}
