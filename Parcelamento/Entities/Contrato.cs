using System;
using System.Collections.Generic;

namespace Parcelamento.Entities {
    public class Contrato {
        public int Número { get; set; }
        public DateTime Data { get; set; }
        public double ValorTotal { get; set; }
        public List<Prestação> Prestações { get; set; }

        public Contrato(int número, DateTime data, double valorTotal) {
            this.Número = número;
            this.Data = data;
            this.ValorTotal = valorTotal;
            this.Prestações = new List<Prestação>();
        }

        public void AdicionarPrestação(Prestação prestação) {
            this.Prestações.Add(prestação);
        }
    }
}