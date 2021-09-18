using System;
using System.Globalization;
using ContratoDeTrabalho.Entities;
using ContratoDeTrabalho.Entities.Enums;

namespace ContratoDeTrabalho {
    class Program {
        static void Main(string[] args) {
            Console.Write("Nome do departamento: ");
            string nomeDoDepartamento = Console.ReadLine();

            Console.Write("Nome do trabalhador: ");
            string nomeDoTrabalhador = Console.ReadLine();

            Console.Write("Nível do trabalhador (Júnior/Pleno/Sênior): ");
            NívelDoTrabalhador nívelDoTrabalhador = Enum.Parse<NívelDoTrabalhador>(Console.ReadLine());

            Console.Write("Salário base do trabalhador: ");
            double salárioBaseDoTrabalhador = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        
            Trabalhador trabalhador = new Trabalhador(nomeDoTrabalhador, nívelDoTrabalhador, salárioBaseDoTrabalhador, new Departamento(nomeDoDepartamento));
        
            Console.Write("Quantidade de contratos: ");
            int quantidadeDeContratos = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quantidadeDeContratos; i++) {
                Console.Write($"Contrato #{i}\n");
                
                Console.Write("Data (DD/MM/AAAA): ");
                DateTime dataDoContrato = DateTime.Parse(Console.ReadLine());
                
                Console.Write("Valor por hora: ");
                double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Duração (horas): ");
                int horas = int.Parse(Console.ReadLine());

                trabalhador.AdicionarContrato(new ContratoDeHoras(dataDoContrato, valorHora, horas));
            }

            System.Console.Write("Escolha o mês e o ano para caucular o ganho (MM/YY): ");
            string data = Console.ReadLine();
            DateTime dataFormatada = DateTime.Parse(data);

            Console.WriteLine($"Nome: {trabalhador.Nome}");
            Console.WriteLine($"Departamento: {trabalhador.Departamento.Nome}");

            string ganho = trabalhador.Ganho(dataFormatada.Year, dataFormatada.Month).ToString("F2", CultureInfo.InvariantCulture);
            Console.WriteLine($"Ganhos em {data}: R${ganho}");
        }
    }
}
