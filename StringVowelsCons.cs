using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class StringVowelsCons
    {
        static void Main(string[] args)
        {
            string str;
            int i, Vowels, Cons;

            Console.Write("Enter the String :");
            str = Console.ReadLine();

            
            Vowels = 0;
            Cons = 0;

            for (i = 0; i < str.Length; i++)

            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u' || str[i] == 'A' || str[i] == 'E' || str[i] == 'I' || str[i] == 'U')
                {
                    Vowels++;

                }

                if (str[i] >= 'a' && str[i] <= 'z' || str[i] >= 'A' && str[i] <= 'Z')
                {
                    Cons++;
                }
            }

                Console.Write("Total Number of Vowels in string : {0} ", Vowels);
                Console.Write("\nTotal Number of Consonants in string : {0} ", Cons);

            
            Console.ReadLine();
        }
    }
}
