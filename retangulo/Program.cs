using System;
using System.Globalization;

namespace retangulo {
    class Program {
        static void Main(string[] args) {
            Console.Write("Altura: ");
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Largura: ");
            double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Retangulo retangulo = new Retangulo(altura, largura);
            System.Console.WriteLine($"Área: {retangulo.Área()}");
            System.Console.WriteLine($"Perímetro: {retangulo.Perímetro()}");
            System.Console.WriteLine($"Diagonal: {retangulo.Diagonal()}");
        }
    }
}
