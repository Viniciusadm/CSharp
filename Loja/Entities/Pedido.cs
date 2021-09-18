using System;
using System.Text;
using System.Collections.Generic;
using Loja.Entities.Enums;

namespace Loja.Entities {
    public class Pedido {
        public DateTime Momento { get; set; }
        public EstadoDoPedido Estado { get; set; }
        public Cliente Cliente { get; private set; }
        public List<ItemDoPedido> Pedidos = new List<ItemDoPedido>();

        public Pedido() {

        }

        public Pedido(DateTime momento, EstadoDoPedido pedido, Cliente cliente) {
            this.Momento = momento;
            this.Estado = pedido;
            this.Cliente = cliente;
        }

        public void AdicionarItem(ItemDoPedido item) {
            Pedidos.Add(item);
        }
        public void RemoverPedido(ItemDoPedido item) {
            Pedidos.Remove(item);
        }

        public double Total() {
            double soma = 0;
            foreach (ItemDoPedido item in Pedidos) {
                soma += item.SubTotal();
            }
            return soma;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\nDetalhes do pedido: ");
            sb.AppendLine($"Momento do pedido: {this.Momento}");
            sb.AppendLine($"Estado do pedido: {this.Estado}");
            sb.AppendLine($"Cliente: {this.Cliente}");
            sb.AppendLine("\nDetalhes dos itens: ");
            foreach (ItemDoPedido item in this.Pedidos) {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine($"Preço total: R${this.Total()}");
            return sb.ToString();
        }

    }
}