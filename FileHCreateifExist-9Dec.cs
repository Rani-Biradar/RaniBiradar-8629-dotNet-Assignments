
//Write a program in C# Sharp to create a blank file in the disk if the same file already exists



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileAssignments_9Dec
{
    class FileHCreate_9Dec
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


                using (FileStream fileStr = File.Create(fileName))
                {
                    Console.WriteLine(" A file created with name mytest.txt ");
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
