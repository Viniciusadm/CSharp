using System;

namespace matrix {
    class Program {
        static void Main(string[] args) {
            Console.Write("Número de linhas do array: ");
            int linhasDoArray = int.Parse(Console.ReadLine());

            Console.Write("Número de colunas do array: ");
            int colunasDoArray = int.Parse(Console.ReadLine());

            int[,] array = montarArray(linhasDoArray, colunasDoArray);

            printarArray(array);
        }
        public static int obterNúmeroAleatório(int tamanhoDoArray) {
            Random rnd = new Random();
            return rnd.Next(1, tamanhoDoArray + 3);
        }
        public static int[,] montarArray(int linhasDoArray, int colunasDoArray) {
            int tamanhoDoArray = linhasDoArray * colunasDoArray;
            int[,] array = new int[linhasDoArray, colunasDoArray];
            for (int linha = 0; linha < linhasDoArray; linha++) {
                for (int coluna = 0; coluna < colunasDoArray; coluna++) {
                    array[linha, coluna] = obterNúmeroAleatório(tamanhoDoArray);
                }
            }
            return array;
        }
        public static void printarArray(int[,] array) {
            int linhasDoArray = array.GetLength(0);
            int colunasDoArray = array.GetLength(1);

            Console.Clear();
            Console.WriteLine("Resultado do array:");
            for (int linha = 0; linha < linhasDoArray; linha++) {
                for (int coluna = 0; coluna < colunasDoArray; coluna++) {
                    string númeroAtual = array[linha, coluna].ToString();
                    if (númeroAtual.Length < 2) númeroAtual = "0" + númeroAtual;
                    if (coluna == colunasDoArray - 1) Console.Write(númeroAtual + "\n");
                    else Console.Write(númeroAtual + " ");
                }
            }
        }
    }
}
