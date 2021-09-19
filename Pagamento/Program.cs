using System;
using System.Globalization;
using System.Collections.Generic;
using Pagamento.Entities;

namespace Pagamento {
    class Program {
        static void Main(string[] args) {
            List<Funcionário> funcionários = new List<Funcionário>();

            Console.Write("Digite o número de funcionários: ");
            int númeroDeFuncionários = int.Parse(Console.ReadLine());

            for (int i = 1; i <= númeroDeFuncionários; i++) {
                Console.WriteLine("Dados do funcionário #1");
                
                Console.Write("Terceirizado? (s/n): ");
                char resposta = Char.ToLower(char.Parse(Console.ReadLine()));
                
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Horas: ");
                int horas = int.Parse(Console.ReadLine());

                Console.Write("Valor por hora: ");
                double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (resposta == 's') {
                    Console.Write("Gasto adicional: ");
                    double gastoAdicional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    funcionários.Add(new FuncionárioTerceirizado(nome, horas, valorPorHora, gastoAdicional));
                } else {
                    funcionários.Add(new Funcionário(nome, horas, valorPorHora));
                }

                Console.WriteLine("\nPagamentos:");

                foreach (Funcionário funcionário in funcionários) {
                    Console.WriteLine(funcionário);
                }
            }
        }
    }
}
