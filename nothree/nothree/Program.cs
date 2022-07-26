using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nothree
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;

            Console.WriteLine("Enter your preferred year to know if it is a leap year or not");
            year = Convert.ToInt32(Console.ReadLine());

            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine(year + " is a leap year");
            }
            else
            {
                Console.WriteLine(year + " is not a leap year");
            }
            Console.ReadLine();

        }
    }
}
