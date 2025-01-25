using System;
using System.Globalization;

namespace Projetos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Informe quantos KM: ");
            int km = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 

            int resultado = km * 2;

            Console.WriteLine(resultado + " minutos");
        }
    }
}
