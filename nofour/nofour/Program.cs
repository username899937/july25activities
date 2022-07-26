using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nofour
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1 = 1, num2 = 0, result, input;

            Console.WriteLine("Enter the number");
                input = Convert.ToInt32(Console.ReadLine());


            for (int i = 2; i <= input; i++)
            {
                result = num1 + num2;
                Console.Write(result + " ");
                num1 = num2;
                num2 = result;
            }
            Console.ReadLine();
        }
    }
}
