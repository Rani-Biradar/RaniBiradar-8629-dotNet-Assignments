using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileAssignments_9Dec
{
    class FileHAppend_9Dec
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
                }
                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s = "";
                    Console.WriteLine(" Here is the content of the file mytest.txt : ");
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                    Console.WriteLine("");
                }
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Klaus\Desktop\mytest.txt", true))
                {
                    file.WriteLine(" This is the line appended at last line.");
                }
                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s = "";
                    Console.WriteLine(" Here is the content of the file after appending the text : ");
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
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
