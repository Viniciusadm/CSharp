using System;

namespace teste {
    class Program {
        static void Main(string[] args) {
            Teste teste = new Teste();
            teste.Número = 2;
            Teste teste2 = teste;
            Console.WriteLine(teste2.Número);
            teste.Número = 3;
            Console.WriteLine(teste2.Número);

            int número = 1;
            int número2 = número;
            Console.WriteLine(número2);
            número = 10;
            System.Console.WriteLine(número2);
        }
    }
}
