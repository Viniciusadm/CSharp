namespace Parcelamento.Services {
    public interface IServiĆ§oPagamentoOnline {
        public double TaxaDePagamento(double valor);
        public double Parcelamento(double valor, int meses);
    }
}