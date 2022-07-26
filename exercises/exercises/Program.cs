using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a string: ");
            string input = Console.ReadLine();

            Console.WriteLine("The input string is " + input);

            string reverse = string.Empty;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reverse += input[i];
            }

            if (input == reverse)
            {
                Console.WriteLine(input + " is Palindrome");
            }
            else
            {
                Console.WriteLine(input +" is not Palindrome");
            }
            Console.ReadLine();
        }
    }
}
