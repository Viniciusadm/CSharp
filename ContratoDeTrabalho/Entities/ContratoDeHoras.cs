using System;

namespace ContratoDeTrabalho.Entities {
    public class ContratoDeHoras {
        public DateTime Data { get; set; }
        public double ValorPorHora { get; set; }
        public int Horas { get; set; }

        public ContratoDeHoras() {

        }

        public ContratoDeHoras(DateTime data, double valorPorHora, int horas) {
            this.Data = data;
            this.ValorPorHora = valorPorHora;
            this.Horas = horas;
        }

        public double ValorTotal() {
            return this.ValorPorHora * this.Horas;
        }
    }
}