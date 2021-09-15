using System;
using System.Globalization;

namespace aluno {
    class Program {
        static void Main(string[] args) {
            Console.Write("Nome do aluno: ");
            string nome = Console.ReadLine();

            Console.Write("Nota 1: ");
            double nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Nota 2: ");
            double nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.Write("Nota 3: ");
            double nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Aluno aluno = new Aluno(nome, nota1, nota2, nota3);

            System.Console.WriteLine(aluno);
        }
    }
}