﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrInterview8
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
            int counter = CharCounter(text, letter);
            Console.WriteLine(text + " contains the letter " + letter + " " + counter + " times.");
            Console.ReadLine();

        }

        static int CharCounter(string word, char letter)
        {
            int count = 0;
            for (int lcv = 0; lcv < word.Length; lcv++)
            {
                if (word[lcv] == letter)
                    count += 1;
            }
            return count;
        }
    }
}
