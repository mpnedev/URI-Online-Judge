using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nFuncionario, horasTrabalhadas;
            double valorHora;

            Console.Write("Informe o número do empregado: ");
            nFuncionario = int.Parse(Console.ReadLine());

            Console.Write("Horas trabalhadas: ");
            horasTrabalhadas = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Informe o valor por hora trabalhada: ");
            valorHora = double.Parse(Console.ReadLine());

            double resultado = horasTrabalhadas * valorHora;

            Console.WriteLine("----------------------------");

            Console.WriteLine("Funcionario: " + nFuncionario);
            Console.WriteLine("Valor a receber: R$" + resultado.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
