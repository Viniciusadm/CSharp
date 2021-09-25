using System;
using System.Collections.Generic;

namespace Curso {
    class Program {
        static void Main(string[] args) {
            HashSet<int> alunos = new HashSet<int>();

            for (int i = 1; i <= 3; i++) {
                Console.Write($"Quantos alunos tem no curso {i}? ");
                int númeroDeAlunos = int.Parse(Console.ReadLine());

                for (int j = 1; j <= númeroDeAlunos; j++) {
                    Console.Write($"Aluno {j}: ");
                    alunos.Add(int.Parse(Console.ReadLine()));
                }
            }
            Console.WriteLine($"Total de estudantes: {alunos.Count}");
        }
    }
}