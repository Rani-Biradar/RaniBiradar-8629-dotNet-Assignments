using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileAssignments_9Dec
{
    class FileHMove_9Dec
    {
        static void Main(string[] args)
        {
            string sfileName = @"C:\Users\Klaus\Desktop\mytest.txt";
            string tfileName = @"C:\Users\Klaus\Desktop\mytest.tx ";


            if (File.Exists(sfileName))
            {
                File.Delete(sfileName);
            }
            if (File.Exists(tfileName))
            {
                File.Delete(tfileName);
            }

            using (StreamWriter fileStr = File.CreateText(sfileName))
            {
                fileStr.WriteLine("Hello and Welcome");
                fileStr.WriteLine(" It is the first content");
                fileStr.WriteLine(" of the text file mytest.txt");
            }
            using (StreamReader sr = File.OpenText(sfileName))
            {
                string s = "";
                Console.WriteLine(" Here is the content of the file {0} : ", sfileName);
                while ((s = sr.ReadLine())!=null)
                    {
                    Console.WriteLine(s);
                }
            }
            System.IO.File.Move(sfileName, tfileName);
            Console.WriteLine(" The file {0} successfully moved to the name {1} in the same directory.", sfileName, tfileName);

            using (StreamReader sr = File.OpenText(tfileName))
            {
                string s = "";
                Console.WriteLine(" Here is the content of the file {0} : ", tfileName);
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}

