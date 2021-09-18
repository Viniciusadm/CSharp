using System;
using System.Globalization;
using Loja.Entities;
using Loja.Entities.Enums;

namespace Loja {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Coloque os dados do cliente: ");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            string email = nome.ToLower() + "@gmail.com";

            Console.Write("Data de aniversário: ");
            DateTime dataDeAniversário = DateTime.Parse(Console.ReadLine());

            Cliente cliente = new Cliente(nome, email, dataDeAniversário);

            Console.WriteLine("Coloque os dados do pedido: ");
            
            Console.Write("Estado: ");
            EstadoDoPedido estado = Enum.Parse<EstadoDoPedido>(Console.ReadLine());

            Pedido pedido = new Pedido(DateTime.Now, estado, cliente);

            Console.Write("Quantidade de itens do pedido: ");
            int quantidadeDeItensDoPedido = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quantidadeDeItensDoPedido; i++) {
                Console.WriteLine($"Item #{i}: ");
                
                Console.Write("Nome do produto: ");
                string nomeDoProduto = Console.ReadLine();

                Console.Write("Preço do produto: ");
                double preçoDoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Quantidade: ");
                int quantidade = int.Parse(Console.ReadLine());

                Produto produto = new Produto(nomeDoProduto, preçoDoProduto);
                ItemDoPedido item = new ItemDoPedido(quantidade, produto);
                
                pedido.AdicionarItem(item);
            }
            Console.WriteLine(pedido);
        }
    }
}
