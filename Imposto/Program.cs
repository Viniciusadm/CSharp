using System;
using System.Collections.Generic;
using System.Globalization;
using Imposto.Entities;

namespace Imposto {
    class Program {
        static void Main(string[] args) {
            List<TaxaDeImposto> pessoas = new List<TaxaDeImposto>();

            Console.Write("Digite a quantidade de pagadores de imposto: ");
            int quantidade = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quantidade; i++) {
                Console.WriteLine($"Pessoa #{i}");

                Console.Write("Pessoa física ou jurídica? (f/j): ");
                char resposta = Char.ToLower(char.Parse(Console.ReadLine()));

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Renda anual: ");
                double rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (resposta == 'f') {
                    Console.Write("Gastos com saúde: ");
                    double gastosComSaúde = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    pessoas.Add(new ImpostoPessoaFísica(nome, rendaAnual, gastosComSaúde));
                }

                if (resposta == 'j') {
                    Console.Write("Número de funcionários: ");
                    int númeroDeFuncionários = int.Parse(Console.ReadLine());

                    pessoas.Add(new ImpostoPessoaJurídica(nome, rendaAnual, númeroDeFuncionários));
                }
            }

            Console.WriteLine("Taxa de imposto: ");
            foreach (TaxaDeImposto pessoa in pessoas) {
                Console.WriteLine(pessoa);
            }
        }
    }
}
