using System;

namespace locadora.model
{
    public class Reserva
    {
        public double Conta { get; set; }
        public decimal TempoCarro { get; set; }

        public Reserva(decimal tempocarro)
        {
            this.TempoCarro = tempocarro;
        }
        public double CalcularConta(double preco)
        {
            return this.Conta = preco * Convert.ToDouble(this.TempoCarro);
        }
    }
}
