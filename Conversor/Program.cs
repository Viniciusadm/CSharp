using System;
using System.Globalization;

namespace Conversor {
    class Program {
        static void Main(string[] args) {
            Console.Write("Cotação do dolar: ");
            double cotaçãoDoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Dolares a ser comprado: ");
            double dolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string valorConvertido = ConversorDeMoeda.ValorASerPago(cotaçãoDoDolar, dolares);
            Console.WriteLine($"Valor a ser pago em reais: R${valorConvertido}");
        }
    }
}
