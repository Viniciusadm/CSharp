using System;
using System.Globalization;

namespace Produtos.Entities {
    public class ProdutoUsado : Produto {
        public DateTime DataDeFabricação { get; set; }

        public ProdutoUsado(string nome, double preço, DateTime dataDeFabricação) : base(nome, preço) {
            this.DataDeFabricação = dataDeFabricação;
        }

        public override string EtiquetaDePreço() {
            string dataDeFabricação = this.DataDeFabricação.ToString("dd/MM/yyyy");
            return $"{this.Nome} (usado) R${this.Preço.ToString("F2", CultureInfo.InvariantCulture)} (Data de fabricação: R${dataDeFabricação})";
        }
    }
}