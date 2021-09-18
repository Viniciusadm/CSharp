namespace Loja.Entities {
    public class ItemDoPedido {
        public int Quantidade { get; private set; }
        public double Preço { get; private set; }
        public Produto Produto { get; private set; }

        public ItemDoPedido(int quantidade, Produto produto) {
            this.Quantidade = quantidade;
            this.Preço = produto.Preço;
            this.Produto = produto;
        }

        public double SubTotal() {
            return this.Preço * this.Quantidade;
        }

        public override string ToString() {
            return $"{this.Produto.Nome}, R${this.Preço}, Quantidade: {this.Quantidade}, Subtotal: {this.SubTotal()}";
        }
    }
}