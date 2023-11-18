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
            return Conta = preco * Convert.ToDouble(TempoCarro);
        }
    }
}
