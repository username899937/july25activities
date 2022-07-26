using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nofive
{
    class Program
    {
   public static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();

            int spaces = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    spaces++;
                }
            }
            Console.WriteLine("The " + "\"" +input + "\""+ " contains " + spaces + " spaces");
            Console.ReadLine();
        }
    }
}
