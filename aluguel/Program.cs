using System;

namespace aluguel {
    class Program {
        static void Main(string[] args) {
            Estudante[] quartos = new Estudante[10];
            
            Console.Write("Quantos quartos serão ocupados? ");
            int quantidadeDeQuartos = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quantidadeDeQuartos; i++) {
                Console.WriteLine($"Aluguel #{i}: ");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                string email = nome.ToLower() + "@gmail.com";
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                quartos[quarto - 1] = new Estudante(nome, email);
            }

            Console.WriteLine("\nQuartos ocupados: ");
            for (int i = 0; i < quartos.Length; i++) {
                if (quartos[i] != null) {
                    string nome = quartos[i].Nome;
                    string email = quartos[i].Email;
                    System.Console.WriteLine($"{i + 1}: {nome}, {email}");
                }
            }
        }
    }
}
