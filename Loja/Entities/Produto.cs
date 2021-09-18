namespace Loja.Entities {
    public class Produto {
        public string Nome { get; private set; }
        public double Preço { get; private set; }
        
        public Produto() {

        }
        public Produto(string nome, double preço) {
            this.Nome = nome;
            this.Preço = preço;
        }
    }
}