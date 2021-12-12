using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace FileAssignments_9Dec
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
                string fileName = @"C:\Users\Klaus\Desktop\mytest.txt";

            try
            {
                
                using (FileStream fileStr = File.Create(fileName))
                {
                    Console.WriteLine(" A file created with name mytest.txt\n\n");
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
