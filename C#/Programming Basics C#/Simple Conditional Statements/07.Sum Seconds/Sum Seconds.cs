using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int time1 = int.Parse(Console.ReadLine());
            int time2 = int.Parse(Console.ReadLine());
            int time3 = int.Parse(Console.ReadLine());
            int sum = time1 + time2 + time3;
            int minutes = 0;

            if (sum <= 59)
            {
                Console.WriteLine("{0:0}:{1:00}", minutes, sum);
            }

            else if (sum >= 120)
            {
                Console.WriteLine("{0:0}:{1:00}", minutes + 2, sum - 120);
            }
            else
            {
                Console.WriteLine("{0:0}:{1:00}", minutes + 1, sum - 60);
            }

        }
    }
}
