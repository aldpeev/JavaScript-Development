using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Personal_Titles
{
    class _01
    {
        static void Main(string[] args)
        {
            double agre = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();

            if (gender == "m" && agre >= 16)
            {
                Console.WriteLine("Mr.");
            }
            if (gender == "m" && agre < 16)
            {
                Console.WriteLine("Master");
            }
            if (gender == "f" && agre >= 16)
            {
                Console.WriteLine("Ms.");
            }
            if (gender == "f" && agre < 16)
            {
                Console.WriteLine("Miss");
            }
        }
    }
}
