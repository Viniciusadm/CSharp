using System;
using System.Collections.Generic;
using System.Text;

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
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.Título);
            sb.AppendLine($"{this.Curtidas} curtidas - {this.Momento}");
            sb.AppendLine(this.Conteúdo);
            sb.AppendLine("Comentários: ");
            foreach(Comentário comentário in this.Comentários) {
                sb.AppendLine(comentário.Texto);
            }
            return sb.ToString();
        }
    }
}