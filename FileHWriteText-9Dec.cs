using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileAssignments_9Dec
{
    class FileHWriteText_9Dec
    {
        static void Main(string[] args)
        {
            string fileName = @"C:\Users\Klaus\Desktop\mytest.txt";

            string[] ArrLines;
            string str;

            int n, i;

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            Console.Write(" Input the string to ignore the line : ");
            str = Console.ReadLine();

            Console.Write(" Input number of lines to write in the file  : ");
            n = Convert.ToInt32(Console.ReadLine());
            ArrLines = new string[n];

            Console.Write(" Input {0} strings below :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write(" Input line {0} : ", i + 1);
                ArrLines[i] = Console.ReadLine();
            }

            using (System.IO.StreamWriter file =
           new System.IO.StreamWriter(@"C:\Users\Klaus\Desktop\mytest.txt"))
            {
                foreach (string line in ArrLines)
                {
                    if (!line.Contains(str))
                    {
                        file.WriteLine(line);
                    }
                }
            }
            using (StreamReader sr = File.OpenText(fileName))
            {
                string s = "";
                Console.Write("\n The line has ignored which contain the string '{0}'. \n", str);
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
