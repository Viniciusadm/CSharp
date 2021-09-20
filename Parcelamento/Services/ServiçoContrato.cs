using System;

using Parcelamento.Entities;

namespace Parcelamento.Services {
    public class ServiçoContrato {
        private IServiçoPagamentoOnline _serviçoPagamentoOnline;
        public ServiçoContrato(IServiçoPagamentoOnline serviçoPagamentoOnline) {
            this._serviçoPagamentoOnline = serviçoPagamentoOnline;
        }

        public void ProcessarContrato(Contrato contrato, int meses) {
            double valorBase = contrato.ValorTotal / meses;
            for (int i = 1; i <= meses; i++) {
                DateTime data = contrato.Data.AddMonths(i);
                double valorAtualizado = valorBase + _serviçoPagamentoOnline.Parcelamento(valorBase, i);
                double valorTotal =  valorAtualizado + _serviçoPagamentoOnline.TaxaDePagamento(valorAtualizado);
                contrato.AdicionarPrestação(new Prestação(data, valorTotal));
            }
        }
    }
}