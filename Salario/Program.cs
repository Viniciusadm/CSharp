using System;
using System.Collections.Generic;
using System.Globalization;

namespace Salario {
    class Program {
        static void Main(string[] args) {
            List<Funcionário> funcionários = new List<Funcionário>();

            Console.Write("Quantos funcionários serão registrados? ");
            int quantidadeDeFuncionários = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quantidadeDeFuncionários; i++) {
                Console.WriteLine($"Funcionário {i}");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Salário: ");
                double salário = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                funcionários.Add(new Funcionário(id, nome, salário));
            }

            Console.Write("Digite o ID do funcionário que receberá o aumento: ");
            int idDoFuncionário = int.Parse(Console.ReadLine());

            if (funcionários.Exists(funcionário => funcionário.ID == idDoFuncionário)) {
                Console.Write("Porcentagem do aumento: ");
                double aumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                int indiceDoFuncionário = funcionários.FindIndex(funcionário => funcionário.ID == idDoFuncionário);
                funcionários[indiceDoFuncionário].AumentarSalário(aumento);

                Console.WriteLine("\nDados dos funcionário: ");
                foreach (Funcionário funcionário in funcionários) {
                    Console.WriteLine(funcionário);
                }
            } else {
                Console.WriteLine("Funcionário inexistente");
            }
        }
    }
}
