using System;
using System.Text;

namespace AluguelDeCarros.Entities {
    public class Aluguel {
        public DateTime Início { get; set; }
        public DateTime Fim { get; set; }
        public Veículo Veículo { get; set; }
        public Fatura Fatura { get; set; }

        public Aluguel(DateTime início, DateTime fim, Veículo veículo) {
            this.Início = início;
            this.Fim = fim;
            this.Veículo = veículo;
        }
    }
}