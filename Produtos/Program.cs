using System;
using System.Collections.Generic;
using System.Globalization;
using Produtos.Entities;

namespace Produtos {
    class Program {
        static void Main(string[] args) {
            List<Produto> produtos = new List<Produto>();

            Console.Write("Digite o número de produtos: ");
            int númeroDeProdutos = int.Parse(Console.ReadLine());

            for (int i = 1; i <= númeroDeProdutos; i++) {
                Console.WriteLine($"\nDados do produto #{i}");
                Console.Write("Comum, importado ou usado? (c, i, u): ");
                char resposta = Char.ToLower(char.Parse(Console.ReadLine()));
                
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Preço: ");
                double preçoDoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (resposta == 'c') {
                    produtos.Add(new Produto(nome, preçoDoProduto));
                } else if (resposta == 'u') {
                    Console.Write("Data de fabricação: ");
                    DateTime dataDeFabricação = DateTime.Parse(Console.ReadLine());

                    produtos.Add(new ProdutoUsado(nome, preçoDoProduto, dataDeFabricação));
                } else if (resposta == 'i') {
                    Console.Write("Taxa de alfândega: ");
                    double taxaDeAlfândega = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    
                    produtos.Add(new ProdutoImportado(nome, preçoDoProduto, taxaDeAlfândega));
                }
            }

            Console.WriteLine("\nEtiquetas De Preço: ");

            foreach (Produto produto in produtos) {
                Console.WriteLine(produto.EtiquetaDePreço());
            }
        }
    }
}
