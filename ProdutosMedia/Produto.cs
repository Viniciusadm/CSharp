namespace ProdutosMedia {
    public class Produto {
        public string Nome { get; set; }
        public double Preço { get; set; }

        public Produto(string nome, double preço) {
            this.Nome = nome;
            this.Preço = preço;
        }
    }
}