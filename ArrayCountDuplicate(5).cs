using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPrint
{
    class CountDuplicateArray
    {
        public static void Main()
        {
            int i, j, n1, m = 1, ctr = 0;
            int[] arr1 = new int[10];
            int[] arr2 = new int[10];
            int[] arr3 = new int[10];

            Console.Write("number of element store in array: ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("input {0} number of elements in array : \n", n1);

            for (i = 0; i < n1; i++)
            {
                Console.Write("element-{0} : ", i);
                arr1[i] = int.Parse(Console.ReadLine());

            }
            for (i = 0; i < n1; i++)
            {
                arr2[i] = arr1[i];
                arr3[i] = 0;
            }

            for (i = 0; i < n1; i++)
            {
                for (j = 0; j < n1; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        arr3[j] = m;
                        m++;
                    }
                }
                m = 1;

            }
        
        for(i=0 ; i<n1 ; i++)
            {
            if(arr3[i]==2)
            {
            ctr++;
            }
         }
       Console.Write("number of duplicate element in array is : {0} ", ctr);
       Console.ReadLine(); 
       }

        }
    }

