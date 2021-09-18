namespace RedeSocial.Entities {
    public class Comentário {
        public string Texto { get; set; }

        public Comentário() {
            
        }
        public Comentário(string texto) {
            this.Texto = texto;
        }
    }
}