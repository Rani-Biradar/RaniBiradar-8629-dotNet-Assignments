
/*Write a program in C# Sharp to find the string which starts and ends with a specific character. 
Test Data :
The cities are : 'ROME','LONDON','NAIROBI','CALIFORNIA','ZURICH','NEW DELHI','AMSTERDAM','ABU DHABI','PARIS'
Input starting character for the string : A
Input ending character for the string : M
Expected Output :
The city starting with A and ending with M is : AMSTERDAM   */




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQAssignments_10Dec
{
    class LinqString_10Dec
    {
        static void Main(string[] args)
        {
            string chst, chen;
           
            string[] cities =
            {
                "ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI", "PARIS"
            };

            Console.Write("\nThe cities are : 'ROME','LONDON','NAIROBI','CALIFORNIA','ZURICH','NEW DELHI','AMSTERDAM','ABU DHABI','PARIS' \n");

            Console.Write("\nInput starting character for the string : ");
            chst = Console.ReadLine();

    
            Console.Write("\nInput ending character for the string : ");
            chen = Console.ReadLine();
       

            var result = from x in cities
                         where x.StartsWith(chst)
                         where x.EndsWith(chen)
                         select x;
            Console.Write("\n\n");
            foreach (var city in result)
            {
                Console.Write("The city starting with {0} and ending with {1} is : {2} \n", chst, chen, city);

            }
            Console.ReadLine();

        }
    }
}
