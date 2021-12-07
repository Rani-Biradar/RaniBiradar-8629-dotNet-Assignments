using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPrint
{
    class ArrayUnique
    {
        public static void Main()
        {
            int n, ctr = 0;
            int[] arr = new int[100];
            int i, j, k;

            Console.Write("number of element store in array: ");
            n = int.Parse(Console.ReadLine());

            Console.Write("input {0} number of elements in array : \n", n);

            for (i = 0; i < n; i++)
            {
                Console.Write("element-{0} : ", i);
                arr[i] = int.Parse(Console.ReadLine());

            }
            Console.Write(" unique elements in the array are : \n");
            for (i = 0; i < n; i++)
            {
                ctr = 0;

                for (j = 0; j < i - 1; j++)
                {
                   
                    if (arr[i] == arr[j])
                    {
                        ctr++;
                    }
                }
                for (k = i + 1; k < n; k++)
                {
                    if (arr[i] == arr[k])
                    {
                        ctr++;
                    }

                    if (arr[i] == arr[i + 1])
                    {
                        i++;
                    }
                }


                if (ctr == 0)
                {
                    Console.Write("{0} ", arr[i]);
                }
            }
            Console.ReadLine();

        }
    }
}
