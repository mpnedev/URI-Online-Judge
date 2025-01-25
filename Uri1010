using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codPeca1, numPeca1;
            double valorPeca1, valorTotal1;

            int codPeca2, numPeca2;
            double valorPeca2, valorTotal2;

            string[] vet1 = Console.ReadLine().Split(' ');
            codPeca1 = int.Parse(vet1[0], CultureInfo.InvariantCulture);
            numPeca1 = int.Parse(vet1[1], CultureInfo.InvariantCulture);
            valorPeca1 = double.Parse(vet1[2], CultureInfo.InvariantCulture);

            string[] vet2 = Console.ReadLine().Split(' ');
            codPeca2 = int.Parse(vet2[0], CultureInfo.InvariantCulture);
            numPeca2 = int.Parse(vet2[1], CultureInfo.InvariantCulture);
            valorPeca2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);


            valorTotal1 = valorPeca1 * numPeca1;
            valorTotal2 = valorPeca2 * numPeca2;

            double resultado = valorTotal1 + valorTotal2;

            Console.WriteLine("VALOR A PAGAR: R$ " + resultado.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();

        }
    }
}
