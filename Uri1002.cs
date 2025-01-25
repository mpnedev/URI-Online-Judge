using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double area,
                n = 3.14159,
                raio;

            Console.Write("Informe o valor do raio: ");
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = n * Math.Pow(raio,raio);

            Console.Write("Area = " + area.ToString("F4", CultureInfo.InvariantCulture));
        
            Console.ReadLine();
        }
    }
}
