using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileAssignments_9Dec
{
    class FileHAddText_9Dec
    {
        static void Main(string[] args)
        {


            string fileName = @"C:\Users\Klaus\Desktop\mytest.txt";

            try
            {

                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                using (StreamWriter fileStr = File.CreateText(fileName))
                {
                    fileStr.WriteLine(" Hello and Welcome");
                    fileStr.WriteLine(" It is the first content");
                    fileStr.WriteLine(" of the text file mytest.txt");
                    Console.WriteLine(" A file created with content name mytest.txt\n");
                    Console.ReadLine();
                }
            }
            catch (Exception MyExcep)
            {
                Console.WriteLine(MyExcep.ToString());
            }

        }
    }
}

