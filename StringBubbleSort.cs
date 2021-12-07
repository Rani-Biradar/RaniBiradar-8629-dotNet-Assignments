using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class StringBubbleSort
    {
        public static void Main(string[] args)
        {
            string[] arr;
            string temp;
            int n, i, j;

            Console.Write("Input number of strings :");
            n = Convert.ToInt32(Console.ReadLine());
            arr = new string[n];
            Console.Write("Input {0} strings below :\n", n);
            for (i = 0; i < n; i++)
            {
                arr[i] = Console.ReadLine();
            }
           

            for (i = 0; i < arr.Length ; i++)
            {
                for (j = 0; j < arr.Length  - 1; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) > 0)
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.Write("After sorting the array will be  : \n");
            for (i = 0; i < arr.Length ; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
            Console.ReadLine();

        }
    }
}
