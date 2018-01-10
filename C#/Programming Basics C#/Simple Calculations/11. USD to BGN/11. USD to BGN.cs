using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Моля въведете  сума в долари: ");
            double usd = double.Parse(Console.ReadLine());
            double bgn = usd * 1.79549;
            double result = Math.Round(bgn, 2);
            Console.WriteLine("{0} долара са равни на {1} лева", usd, result);
        }
    }
}
