using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Salarios {
    class Program {
        static void Main(string[] args) {
            List<Funcionario> funcionários = new List<Funcionario>();
            string path = "/home/vinicius/Documentos/projetos/csharp/Salarios/text.csv";

            try {
                using (StreamReader reader = File.OpenText(path)) {
                    while (!reader.EndOfStream) {
                        string line = reader.ReadLine();
                        string nome = line.Split(",")[0];
                        string email = line.Split(",")[1];
                        double salário = double.Parse(line.Split(",")[2], CultureInfo.InvariantCulture);

                        funcionários.Add(new Funcionario(nome, email, salário));
                    }
                }
            } catch (IOException erro) {
                Console.WriteLine(erro.Message);
            }

            Console.Write("Digite o salário: ");
            double salárioMáximo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            List<string> emails = (from funcionário in funcionários where funcionário.Salário > salárioMáximo orderby funcionário.Nome select funcionário.Email).ToList();
            double somaDeSalário = (from funcionário in funcionários where funcionário.Nome[0] == 'M' select funcionário.Salário).Sum();

            Console.WriteLine($"Email das pessoas que o salário são maiores que R${salárioMáximo.ToString("F2", CultureInfo.InvariantCulture)}: ");
            foreach (string email in emails) {
                Console.WriteLine(email);
            }

            Console.WriteLine($"Soma dos salários das pessoas que começam com a letra M: {somaDeSalário.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
