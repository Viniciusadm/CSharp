using System;
using System.Collections.Generic;

namespace RedeSocial.Entities {
    public class Postagem {
        public DateTime Momento { get; private set; }
        public string Título { get; private set; }
        public string Conteúdo { get; private set; }
        public int Curtidas { get; set; }
        public List<Comentário> Comentários { get; private set; } = new List<Comentário>();

        public Postagem() {

        }

        public Postagem(DateTime momento, string título, string conteúdo, int curtidas) {
            this.Momento = momento;
            this.Título = título;
            this.Conteúdo = conteúdo;
            this.Curtidas = curtidas;
        }

        public void AdicionarComentário(Comentário comentário) {
            this.Comentários.Add(comentário);
        }

        public void RemoveComentário(Comentário comentário) {
            this.Comentários.Remove(comentário);
        }

        public override string ToString() {
            string comentários = "";
            foreach(Comentário comentário in this.Comentários) {
                comentários += comentário.Texto + "\n";
            }
            return $"{this.Título}\n{this.Curtidas} curtidas - {this.Momento}\n{this.Conteúdo}\nComentários:\n{comentários}";
        }
    }
}