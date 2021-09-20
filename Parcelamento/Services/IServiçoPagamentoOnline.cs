namespace Parcelamento.Services {
    public interface IServiçoPagamentoOnline {
        public double TaxaDePagamento(double valor);
        public double Parcelamento(double valor, int meses);
    }
}