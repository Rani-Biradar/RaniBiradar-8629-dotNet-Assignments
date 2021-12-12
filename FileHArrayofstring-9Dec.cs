using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileAssignments_9Dec
{
    class FileHArrayofstring_9Dec
    {
        static void Main(string[] args)
        {
            string fileName = @"C:\Users\Klaus\Desktop\mytest.txt";

            string[] ArrLines;
            int n, i;

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            Console.Write(" Input number of lines to write in the file  :");
            n = Convert.ToInt32(Console.ReadLine());

            ArrLines = new string[n];
            Console.Write(" Input {0} strings below :", n);

            for (i = 0; i < n; i++)
            {
                Console.Write(" Input line {0} : ", i );
                ArrLines[i] = Console.ReadLine();
            }
            System.IO.File.WriteAllLines(fileName, ArrLines);

            using (StreamReader sr = File.OpenText(fileName))
            {
                string s = "";
                Console.Write("\n The content of the file is  :\n", n);

                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(" {0} ", s);
                }
                Console.ReadLine();

            }
        }
    }
}