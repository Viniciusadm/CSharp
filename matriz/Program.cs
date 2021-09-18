using System;

namespace matriz {
    class Program {
        static void Main(string[] args) {
            Console.Write("Número de linhas da matriz: ");
            int linhasDaMatriz = int.Parse(Console.ReadLine());

            Console.Write("Número de colunas da matriz: ");
            int colunasDaMatriz = int.Parse(Console.ReadLine());

            Matriz matriz = new Matriz(linhasDaMatriz, colunasDaMatriz);

            Console.Write("Digite o número que você deseja analizar: ");
            int númeroAnalizado = int.Parse(Console.ReadLine());

            matriz.PrintarPosições(númeroAnalizado);
        }
    }
}

