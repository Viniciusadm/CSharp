using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace ProdutosMedia {
    class Program {
        static void Main(string[] args) {
            List<Produto> produtos = new List<Produto>();
            string path = @"/home/vinicius/Documentos/projetos/csharp/ProdutosMedia/text.csv";

            try {
                using(StreamReader reader = File.OpenText(path)) {
                    while (!reader.EndOfStream) {
                        string line = reader.ReadLine();
                        string nome = line.Split(",")[0];
                        double preço = double.Parse(line.Split(",")[1], CultureInfo.InvariantCulture);
                        produtos.Add(new Produto(nome, preço));
                    }
                }
            } catch (IOException erro) {
                Console.WriteLine(erro.Message);
            }

            double preçoMédio = produtos.Average(produto => produto.Preço);
            List<string> listaDeNomes = (from produto in produtos where produto.Preço < preçoMédio orderby produto.Nome select produto.Nome).ToList();

            Console.WriteLine($"Preço médio: {preçoMédio.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine("Produtos com valor a baixo da média");
            foreach (string nome in listaDeNomes) {
                Console.WriteLine(nome);
            }
        }
    }
}
