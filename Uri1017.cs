using System;
using System.Globalization;

namespace Projetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tempo, km, litro = 12;

            tempo = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            km = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = (km / litro) * tempo;

            Console.WriteLine("Será gasto: " + resultado.ToString("F3", CultureInfo.InvariantCulture) + " litros de gasolina.");
        }
    }
}
