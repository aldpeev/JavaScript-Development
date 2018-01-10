using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CurrencyConvertor
{
    class CurrencyConvertor
    {
        static void Main(string[] args)
        {
            var sum = Double.Parse(Console.ReadLine());
            var currencyIn = Console.ReadLine();
            var currencyOut = Console.ReadLine();
            if (currencyIn == "BGN")
            {

                if (currencyOut == "BGN")
                {
                    Console.WriteLine(sum);
                }
                else if (currencyOut == "USD")
                {
                    Console.WriteLine(sum / 1.79549);
                }
                else if (currencyOut == "EUR")
                {
                    Console.WriteLine(sum / 1.95583);
                }
                else if (currencyOut == "GBP")
                {
                    Console.WriteLine(sum / 2.53405);
                }
                else
                {
                    Console.WriteLine("Nepravilno vavedeni danni");
                }
            }
            if (currencyIn == "USD")
            {
                if (currencyOut == "USD")
                {
                    Console.WriteLine(sum);
                }
                else if (currencyOut == "BGN")
                {
                    Console.WriteLine(sum * 1.79549);
                }
                else if (currencyOut == "EUR")
                {
                    Console.WriteLine((sum * 1.79549) / 1.95583);
                }
                else if (currencyOut == "GBP")
                {
                    Console.WriteLine((sum * 1.79549) / 2.53405);
                }
                else
                {
                    Console.WriteLine("Nepravilno vavedeni danni");
                }
            }
            if (currencyIn == "EUR")
            {
                if (currencyOut == "EUR")
                {
                    Console.WriteLine(sum);
                }
                else if (currencyOut == "USD")
                {
                    Console.WriteLine((sum * 1.95583) / 1.79549);
                }
                else if (currencyOut == "BGN")
                {
                    Console.WriteLine(sum * 1.95583);
                }
                else if (currencyOut == "GBP")
                {
                    Console.WriteLine((sum * 1.95583) / 2.53405);
                }
                else
                {
                    Console.WriteLine("Nepravilno vavedeni danni");
                }
            }
            if (currencyIn == "GBP")
            {
                if (currencyOut == "GBP")
                {
                    Console.WriteLine(sum);
                }
                else if (currencyOut == "USD")
                {
                    Console.WriteLine((sum * 2.53405) / 1.79549);
                }
                else if (currencyOut == "BGN")
                {
                    Console.WriteLine(sum * 2.53405);
                }
                else if (currencyOut == "EUR")
                {
                    Console.WriteLine((sum * 2.53405) / 1.95583);
                }
                else
                {
                    Console.WriteLine("Incorect data");
                }
            }


        }
    }
}