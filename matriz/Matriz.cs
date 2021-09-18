using System;

namespace matriz {
    public class Matriz {
        public int LinhasDaMatriz { get; private set; }
        public int ColunasDaMatriz { get; private set; }
        public int[,] matriz { get; private set; }
        public Matriz(int linhasDaMatriz, int colunasDaMatriz) {
            this.LinhasDaMatriz = linhasDaMatriz;
            this.ColunasDaMatriz = colunasDaMatriz;
            this.montarMatriz();
            this.printarMatriz();
        }
        public int obterNúmeroAleatório(int tamanhoDaMatriz) {
            Random rnd = new Random();
            return rnd.Next(1, tamanhoDaMatriz + 3);
        }
        public void montarMatriz() {
            int tamanhoDaMatriz = this.LinhasDaMatriz * this.ColunasDaMatriz;
            this.matriz = new int[this.LinhasDaMatriz, this.ColunasDaMatriz];
            for (int linha = 0; linha < this.LinhasDaMatriz; linha++) {
                for (int coluna = 0; coluna < this.ColunasDaMatriz; coluna++) {
                    this.matriz[linha, coluna] = obterNúmeroAleatório(tamanhoDaMatriz);
                }
            }
        }
        public void printarMatriz() {
            Console.Clear();
            Console.WriteLine("Resultado da matriz:");
            for (int linha = 0; linha < this.LinhasDaMatriz; linha++) {
                for (int coluna = 0; coluna < this.ColunasDaMatriz; coluna++) {
                    string númeroAtual = this.matriz[linha, coluna].ToString();
                    
                    if (númeroAtual.Length < 2) númeroAtual = "0" + númeroAtual;

                    if (coluna == ColunasDaMatriz - 1) Console.Write(númeroAtual + "\n");
                    else Console.Write(númeroAtual + " ");
                }
            }
        }
        public void PrintarPosições(int número) {
            for (int linha = 0; linha < this.LinhasDaMatriz; linha++) {
                for (int coluna = 0; coluna < this.ColunasDaMatriz; coluna++) {
                    if (this.matriz[linha, coluna] == número) {
                        Console.WriteLine($"\nPosição {linha}, {coluna}");
                        if (coluna - 1 >= 0)
                            Console.WriteLine($"Esquerda: {this.matriz[linha, coluna - 1]}");
                        if (coluna + 1 < this.ColunasDaMatriz)
                            Console.WriteLine($"Direita: {this.matriz[linha, coluna + 1]}");
                        if (linha - 1 >= 0)
                            Console.WriteLine($"Acima: {this.matriz[linha -1, coluna]}");
                        if (linha + 1 < this.LinhasDaMatriz)
                            Console.WriteLine($"Abaixo: {this.matriz[linha + 1, coluna]}");
                    }
                }
            }
        }
    }
}