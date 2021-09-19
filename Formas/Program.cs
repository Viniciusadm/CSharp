using System;
using System.Collections.Generic;
using System.Globalization;
using Formas.Entities;
using Formas.Entities.Enums;

namespace Formas {
    class Program {
        static void Main(string[] args) {
            List<Forma> formas = new List<Forma>();

            Console.Write("Digite a quantidade de figuras: ");
            int quantidade = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quantidade; i++) {
                Console.WriteLine($"Figura #{i}");
                
                Console.Write("Círculo ou retângulo? ");
                char resposta = Char.ToLower(char.Parse(Console.ReadLine()));

                Console.Write("Cor: ");
                Cor cor = Enum.Parse<Cor>(Console.ReadLine());

                if (resposta == 'c') {
                    Console.Write("Raio: ");
                    double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    formas.Add(new Círculo(cor, raio));
                } else if (resposta == 'r') {
                    Console.Write("Altura: ");
                    double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Largura: ");
                    double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    formas.Add(new Retângulo(cor, altura, largura));
                }
            }
            System.Console.WriteLine("Áreas das formas:");
            foreach (Forma forma in formas) {
                Console.WriteLine(forma);
            }
        }
    }
}
