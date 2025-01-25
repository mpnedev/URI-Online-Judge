using System;
using System.Globalization;

namespace Projetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, B, C;

            Console.Write("Informe as três notas separadas por espaço: ");
            string[] v = Console.ReadLine().Split(' ');
            A = double.Parse(v[0], CultureInfo.InvariantCulture);
            B = double.Parse(v[1], CultureInfo.InvariantCulture);
            C = double.Parse(v[2], CultureInfo.InvariantCulture);

            double media = ((A * 2) + (B * 3) + (C * 5)) / 10;

            Console.WriteLine("MEDIA = " + media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
