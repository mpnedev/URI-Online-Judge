using System;
using System.Globalization;

namespace Projetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade1, idade2;
            double media;
            string nome1, nome2;

            string[] vet = Console.ReadLine().Split(' ');
            nome1 = vet[0];
            idade1 = int.Parse(vet[1]);

            string[] vet2 = Console.ReadLine().Split(' ');
            nome2 = vet2[0];
            idade2 = int.Parse(vet2[1]);

            media = (double) (idade1 + idade2) / 2;

            Console.WriteLine("A idade média de " +nome1+ " e " +nome2+ " é de " +media.ToString("F1", CultureInfo.InvariantCulture)+ " anos");
        }
    }
}
