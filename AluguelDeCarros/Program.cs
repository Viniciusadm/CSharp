using System;
using System.Globalization;
using AluguelDeCarros.Entities;
using AluguelDeCarros.Services;

namespace AluguelDeCarros {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre com os dados do aluguel");
            
            Console.Write("Modelo do carro: ");
            string modelo = Console.ReadLine();

            Console.Write("Início: ");
            DateTime dataInício = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Fim: ");
            DateTime dataFim = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
        
            Aluguel aluguel = new Aluguel(dataInício, dataFim, new Veículo(modelo));

            Console.Write("Digite o preço por hora: ");
            double preçoPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite o preço por dia: ");
            double preçoPorDia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            ServiçoDeAluguel serviçoDeAluguel = new ServiçoDeAluguel(preçoPorHora, preçoPorDia, new TaxaDeImpostoBrasil());

            serviçoDeAluguel.GerarFatura(aluguel);

            Console.WriteLine("Fatura:");
            Console.WriteLine(aluguel.Fatura);
        }
    }
}