using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPrint
{
    class Program
    {

        public static void Main()
        {
            int i;
            int[] arr = new int[10];

            Console.Write("Enter 10 elements in array \n",n);

            for (i = 0; i < 10; i++)
            {
                Console.Write("element-{0}:", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("elements in array are ");
            for (i = 0; i < 10; i++)
            {
                Console.Write("{0}  ", arr[i]);
                
            }
            Console.Write("\n");
            Console.Read();

        }
    }
}




