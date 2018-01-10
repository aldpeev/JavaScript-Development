using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('*', n));

            for (int row = 0; row < n - 2; row++)
            {
                Console.Write("*");
                for (int col = 0; col < n - 2; col++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");

            }

            Console.WriteLine(new string('*', n));


        }
    }
}