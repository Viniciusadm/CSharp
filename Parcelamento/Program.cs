using System;
using System.Globalization;
using Parcelamento.Entities;
using Parcelamento.Services;

namespace Parcelamento {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Entre com os dados do contrato");
            Console.Write("Número: ");
            int númeroDoContrato = int.Parse(Console.ReadLine());
            Console.Write("Data (dd/MM/yyyy): ");
            DateTime dataDoContrato = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Valor do contrato: ");
            double valorDoContrato = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre com o número de parcelas: ");
            int meses = int.Parse(Console.ReadLine());

            Contrato meuContrato = new Contrato(númeroDoContrato, dataDoContrato, valorDoContrato);

            ServiçoContrato serviçoContrato = new ServiçoContrato(new ServiçoPaypal());
            serviçoContrato.ProcessarContrato(meuContrato, meses);

            Console.WriteLine("Prestações:");
            foreach (Prestação prestação in meuContrato.Prestações) {
                Console.WriteLine(prestação);
            }
        }
    }
}