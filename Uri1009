using System;
using System.Globalization;

namespace Projetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salarioFixo, vendas, salarioFinal;

            Console.Write("Informe seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Informe seu salário fixo: ");
            salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Informe o total de vendas no mês: ");
            vendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salarioFinal = salarioFixo + (vendas * 0.15);

            Console.WriteLine("TOTAL = R$" + salarioFinal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
