namespace Imposto.Entities {
    public class ImpostoPessoaJurídica : TaxaDeImposto{
        public int NúmeroDeFuncionários { get; private set; }

        public ImpostoPessoaJurídica(string nome, double rendaAnual, int númeroDeFuncionários) : base(nome, rendaAnual) {
            this.NúmeroDeFuncionários = númeroDeFuncionários;
        }

        public override double Imposto() {
            double impostoSobreRenda = 0;
            if (this.NúmeroDeFuncionários <= 10)
                impostoSobreRenda = this.RendaAnual * 0.16;
            else if (this.NúmeroDeFuncionários > 10)
                impostoSobreRenda = this.RendaAnual * 0.14;

            return impostoSobreRenda;
        }
    }
}