using System;
using AluguelDeCarros.Entities;

namespace AluguelDeCarros.Services {
    public class ServiçoDeAluguel {
        public double PreçoPorHora { get; private set; }
        public double PreçoPorDia { get; private set; }
        private TaxaDeImpostoBrasil _taxaDeImpostoBrasil = new TaxaDeImpostoBrasil();

        public ServiçoDeAluguel(double preçoPorHora, double preçoPorDia) {
            this.PreçoPorHora = preçoPorHora;
            this.PreçoPorDia = preçoPorDia;
        }

        public void GerarFatura(Aluguel aluguel) {
            TimeSpan duração = aluguel.Fim.Subtract(aluguel.Início);

            double pagamentoBase = 0;
            if (duração.TotalHours <= 12) {
                pagamentoBase = this.PreçoPorHora * Math.Ceiling(duração.TotalHours);
            } else {
                pagamentoBase = this.PreçoPorDia * Math.Ceiling(duração.TotalDays);
            }

            double taxa = _taxaDeImpostoBrasil.Taxa(pagamentoBase);
            
            aluguel.Fatura = new Fatura(pagamentoBase, taxa);
        }
        
    }
}