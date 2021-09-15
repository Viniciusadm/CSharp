using System;
using System.Globalization;

namespace Funcionario {
    class Program {
        static void Main(string[] args) {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Salário bruto: ");
            double salário = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            double imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Funcionário funcionário = new Funcionário(nome, salário, imposto);

            Console.WriteLine($"Funcionário: {funcionário}");

            Console.Write("Aumento: ");
            double aumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            funcionário.AumentarSalário(aumento);

            Console.WriteLine($"Dados atualizados: {funcionário}");
        }
    }
}
