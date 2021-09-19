using System.Globalization;

namespace Produtos.Entities {
    public class Produto {
        public string Nome { get; set; }
        public double Preço { get; set; }

        public Produto(string nome, double preço) {
            this.Nome = nome;
            this.Preço = preço;
        }

        public virtual string EtiquetaDePreço() {
            return $"{this.Nome} R${this.Preço.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}