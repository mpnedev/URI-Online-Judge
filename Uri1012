using System;
using System.Globalization;

namespace Projetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();
            double A = double.Parse(inputs[0]);
            double B = double.Parse(inputs[1]);
            double C = double.Parse(inputs[2]);

            double triangulo = (A * C) / 2.0;
            double circulo = 3.14159 * C * C;
            double trapezio = ((A + B) * C) / 2.0;
            double quadrado = B * B;
            double retangulo = A * B;

            Console.WriteLine($"TRIANGULO: {triangulo:F3}");
            Console.WriteLine($"CIRCULO: {circulo:F3}");
            Console.WriteLine($"TRAPEZIO: {trapezio:F3}");
            Console.WriteLine($"QUADRADO: {quadrado:F3}");
            Console.WriteLine($"RETANGULO: {retangulo:F3}");
        }
    }
}
