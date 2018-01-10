using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class CircleArea
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double area = Math.PI * a * a;
            double perimeter = 2 * Math.PI * a;




            Console.WriteLine($"Area = {area}");
            Console.WriteLine($"Perimeter = {perimeter}");

        }
    }
}