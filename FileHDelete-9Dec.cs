using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace FileAssignments_9Dec
{
    class FileHDelete_9Dec
    {
        static void Main(string[] args)
        {


            string fileName = @"C:\Users\Klaus\Desktop\mytest.txt";

            if (File.Exists(fileName))
            {
                File.Delete(fileName);

                Console.WriteLine(" The file {0} deleted successfully ", fileName);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(" File does not exist");
                Console.ReadLine();
            }


        }
    }
}
