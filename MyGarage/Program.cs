using MyGarage.Enum;
using MyGarage.Minivan;
using System;
using Type = MyGarage.Enum.Type;

namespace MyGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            GeneralGarage generalGarage = new GeneralGarage();
            Console.WriteLine(generalGarage);

            Honda honda = new Honda(DateTime.Parse("2005/01/11"), 5000, ConsoleColor.Red,Type.Automat);
            Console.WriteLine(honda);
            Console.WriteLine(honda[CarBrands.Audi]);

        }
    }
}
