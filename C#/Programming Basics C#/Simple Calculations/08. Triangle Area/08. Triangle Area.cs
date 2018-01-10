using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
{
    class Program
    {
        static void Main(string[] args)
        {
            double strana = double.Parse(Console.ReadLine());
            double visochina = double.Parse(Console.ReadLine());
            double rezultat = strana * visochina / 2;
            Console.WriteLine(rezultat);

        }
    }
}