//Write a C# Sharp program that takes four numbers as input to calculate and print the average.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4,result;
            Console.WriteLine("Enter 1st number:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd number:");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 3rd number:");
            num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 4th number:");
            num4 = int.Parse(Console.ReadLine());

            result = (num1 + num2 + num3 + num4) / 4;
            Console.WriteLine("the Average of {0},{1},{2},{3} is: {4}", num1,num2,num3,num4,result);
            Console.ReadLine();
             


        }
    }
}
