using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPrint
{
    class ArrayFrequency_8_
    {

        public static void Main()
        {
            int[] arr = new int[100];
            int[] fr1 = new int[100];
            int n, i, j, ctr;

            Console.Write("Input the number of elements to be stored in the array :");
            n = int.Parse(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr[i] = int.Parse(Console.ReadLine());
                fr1[i] = -1;
            }

            for (i = 0; i < n; i++)
            {
                ctr = 1;
                for (j = i + 1; j < n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        ctr++;
                        fr1[j] = 0;
                    }
                }

                if (fr1[i] != 0)
                {
                    fr1[i] = ctr;
                }
            }
            Console.Write("\nThe frequency of all elements of the array : \n");
            for (i = 0; i < n; i++)
            {
                if (fr1[i] != 0)
                {
                    Console.Write("{0} occurs {1} times\n", arr[i], fr1[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
