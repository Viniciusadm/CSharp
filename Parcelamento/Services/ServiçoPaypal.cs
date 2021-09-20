namespace Parcelamento.Services {
    public class ServiçoPaypal : IServiçoPagamentoOnline {
        private double Taxa = 0.02;
        private double TaxaDeServiço = 0.01;
        public double TaxaDePagamento(double valor) {
            return valor * TaxaDeServiço;
        }

        public double Parcelamento(double valor, int meses) {
            return valor * this.TaxaDeServiço * meses;
        }
    }
}