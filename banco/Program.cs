using System;
using System.Globalization;

namespace banco {
    class Program {
        static void Main(string[] args) {
            Random rnd = new Random();
            int númeroDaConta = rnd.Next(1000, 9999);
            Conta conta;

            System.Console.Write("Títular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá deposito inicial? (s/n) ");
            char resposta = Char.ToLower(char.Parse(Console.ReadLine()));

            while (true) {
                if (resposta == 's') {
                    Console.Write("Valor do deposito: ");
                    double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    conta = new Conta(númeroDaConta, nome, depositoInicial);
                    Console.Clear();
                    System.Console.WriteLine("Conta criada com sucesso\n");
                    break;
                } else if (resposta == 'n') {
                    conta = new Conta(númeroDaConta, nome);
                    Console.Clear();
                    System.Console.WriteLine("Conta criada com sucesso\n");
                    break;
                } else {
                    Console.Write("Resposta inválida!\nHaverá deposito inicial? (s/n) ");
                    resposta = Char.ToLower(char.Parse(Console.ReadLine()));
                }
            }

            while (true) {
                double valor;
                Console.WriteLine("Menu:\n1- Depositar dinheiro\n2- Sacar dinheiro\n3- Mostrar dados da conta\n4- Sair do programa");
                char respostaMenu = Char.ToLower(char.Parse(Console.ReadLine()));

                if (respostaMenu == '1') {
                    Console.Clear();
                    Console.Write("Valor a ser depositado: ");
                    valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    
                    conta.DepositarDinheiro(valor);
                    
                    System.Console.WriteLine("Deposito realizado com sucesso!");
                    Console.WriteLine(conta);
                } else if (respostaMenu == '2') {
                    Console.Clear();
                    
                    Console.Write("Valor a ser retirado: ");
                    valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    
                    bool válido = conta.SacarDinheiro(valor);
                    
                    if (válido == true) Console.WriteLine("Saque realizado com sucesso!");
                    else if (válido == false) Console.WriteLine("Saldo insuficiente!");

                    Console.WriteLine(conta);
                } else if (respostaMenu == '3') {
                    Console.Clear();
                    Console.WriteLine(conta);
                } else if (respostaMenu == '4') {
                    Console.Clear();
                    System.Console.WriteLine("Obrigado por usar o programa");
                    break;
                } else {
                    Console.Clear();
                    Console.WriteLine("Resposta inválida");
                }
            }

        }
    }
}
