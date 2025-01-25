using System;
using System.Globalization;

namespace Projetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int km;
            double litros, resultado;

            km = int.Parse(Console.ReadLine());
            litros = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            resultado = km / litros;

            Console.Write(resultado.ToString("F3", CultureInfo.InvariantCulture) + " km/l");
        }
    }
}
