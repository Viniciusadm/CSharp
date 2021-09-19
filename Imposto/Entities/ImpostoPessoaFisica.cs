namespace Imposto.Entities {
    public class ImpostoPessoaFísica : TaxaDeImposto {
        public double GastosComSaúde { get; private set; }

        public ImpostoPessoaFísica(string nome, double rendaAnual, double gastosComSaúde) : base(nome, rendaAnual) {
            this.GastosComSaúde = gastosComSaúde;
        }

        public override double Imposto() {
            double impostoSobreRenda = 0;
            if (this.RendaAnual < 20000)
                impostoSobreRenda = this.RendaAnual * 0.15;
            else if (this.RendaAnual >= 20000)
                impostoSobreRenda = this.RendaAnual * 0.25;
            
            double impostoSobreSaúde = 0;
            if (this.GastosComSaúde > 0)
                impostoSobreSaúde = this.GastosComSaúde * 0.5;

            return impostoSobreRenda - impostoSobreSaúde;
        }
    }
}