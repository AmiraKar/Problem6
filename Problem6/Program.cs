using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the word or phrase:");
            string
                actualWords = Console.ReadLine();
            string
                reverseWords = string.Empty;
            for (int i = actualWords.Length-1; i >= 0; i--)
            {
                reverseWords += actualWords[i];
            }
            Console.WriteLine(reverseWords);
            if(actualWords==reverseWords) 
                Console.WriteLine("Palindrome");
                else Console.WriteLine("Not Palindrome");
            }

        }
    }

