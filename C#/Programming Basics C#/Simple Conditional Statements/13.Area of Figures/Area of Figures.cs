using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string text1 = Console.ReadLine();


            if (text1 == "square")
            {
                double x = double.Parse(Console.ReadLine());
                double sum = x * x;
                Console.WriteLine("{0:f3}", sum);
            }
            else if (text1 == "rectangle")
            {
                double x = double.Parse(Console.ReadLine());
                double x1 = double.Parse(Console.ReadLine());
                double sum = x * x1;
                Console.WriteLine("{0:f3}", sum);
            }
            else if (text1 == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double sum = Math.PI * radius * radius;
                Console.WriteLine("{0:f3}", sum);
            }
            else if (text1 == "triangle")
            {
                double x = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                double sum = (x * h) / 2;
                Console.WriteLine("{0:f3}", sum);


            }
        }
    }
}
