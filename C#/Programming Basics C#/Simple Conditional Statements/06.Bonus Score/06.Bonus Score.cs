using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double bonus = 0;


            if (number <= 100)
            {
                bonus += 5;
            }
            else if (number <= 1000)
            {
                bonus = number * 0.2;
            }
            else
            {
                bonus = number * 0.10;
            }
            if (number % 2 == 0)
            {
                bonus += 1;
            }
            else if (number % 10 == 5)
            {
                bonus += 2;
            }

            Console.WriteLine("Bonus score: {0}", bonus);
            Console.WriteLine("Total score: {0}", number + bonus);

        }
    }
}
