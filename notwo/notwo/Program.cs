using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
                for (int n = 1; n <= i; n++)
                   Console.Write("{0}", i);
                   Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}


        
 
