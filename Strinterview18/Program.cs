using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strinterview18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string text = Console.ReadLine();
            Console.Write("Enter a letter to search for: ");
            string strletter = Console.ReadLine();
            char letter = strletter[0];
            string final = CharRemove(text, letter);
            Console.WriteLine("Your new string is: " + final);
            Console.ReadLine();

        }

        static string CharRemove(string word, char letter)
        {
            string final = "";
            for (int lcv = 0; lcv < word.Length; lcv++)
            {
                if (word[lcv] != letter)
                {
                    final += word[lcv];
                }
                    
            }
            return final;
        }
    }
}
