using System;
using System.Globalization;

namespace Projetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maior, a, b, c;

            string[] vetor = Console.ReadLine().Split(' ');

            a = int.Parse(vetor[0], CultureInfo.InvariantCulture);
            b = int.Parse(vetor[1], CultureInfo.InvariantCulture);
            c = int.Parse(vetor[2], CultureInfo.InvariantCulture);

            maior = (a > b) ? a : b;
            maior = (maior > c) ? maior : c;

            Console.WriteLine(maior + " eh o maior");
        }
    }
}
