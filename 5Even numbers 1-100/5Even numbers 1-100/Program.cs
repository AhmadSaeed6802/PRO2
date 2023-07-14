using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5Even_numbers_1_100
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Even Numbers from 1-100");// print a message to inform the user about what is going to be done
            for (int i = 1; i <= 100; i++)          // for loop to iterate from 1 to 100
            {
                if (i % 2 == 0)             // cheking condition for even number
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
