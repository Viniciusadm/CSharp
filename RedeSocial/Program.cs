using System;
using RedeSocial.Entities;

namespace RedeSocial {
    class Program {
        static void Main(string[] args) {
            Comentário comentário1 = new Comentário("Tenha uma boa viagem");
            Comentário comentário2 = new Comentário("Isso é incrível");

            Postagem postagem1 = new Postagem(
                DateTime.Parse("17/09/2021 13:04:34"),
                "Viajando pra Coréia do Sul",
                "Estou indo visitar um país maravilhoso",
                12
            );

            postagem1.AdicionarComentário(comentário1);
            postagem1.AdicionarComentário(comentário2);

            Comentário comentário3 = new Comentário("Boa noite");
            Comentário comentário4 = new Comentário("Que a força esteja com você");

            Postagem postagem2 = new Postagem(
                DateTime.Parse("17/09/2021 23:18:46"),
                "Boa noite gente",
                "Vejo vocês amanhã",
                5
            );

            postagem2.AdicionarComentário(comentário3);
            postagem2.AdicionarComentário(comentário4);

            Console.WriteLine(postagem1);
            Console.WriteLine(postagem2);
        }
    }
}
