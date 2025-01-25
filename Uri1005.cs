using System;
using System.Globalization;

namespace Projetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, B, media;

            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double mediaPonderada = ((A * 3.5) + (B * 7.5)) / 11;

            Console.WriteLine("MEDIA = "+ mediaPonderada.ToString("F5", CultureInfo.InvariantCulture));  
        }
    }
}
