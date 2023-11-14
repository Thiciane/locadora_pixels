using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locadora.model
{
    internal class Locacao
    {
        public DateTime dataR { get; set; }
        public DateTime dataD { get; set; }
        public double valorC { get; set; }
        public string seguro { get; set; }


        public Locacao(DateTime dataR, DateTime dataD, double valorC, string seguro, double multa)
        {
            this.dataR = dataR;
            this.dataD = dataD;
            this.valorC = valorC;
            this.seguro = seguro;

        }

        public Locacao()
        {
        }

        public int Dias(DateTime dataR, DateTime dataD)
        {
            this.dataR = dataR;
            this.dataD = dataD;
            TimeSpan ts = dataD.Subtract(dataR);
            string texto = ts.Days.ToString();
            int dias = int.Parse(texto);
            return dias;
        }

        public double Carros(double valorC, string seguro, DateTime dataR, DateTime dataD)
        {
            double valor = 0;
            if (seguro == "Sim")
            {
                valor = (valorC * Dias(dataR, dataD)) + 100;

                return valor;
            }

            else
            {
                valor = (valorC * Dias(dataR, dataD)) + 0;

                return valor;
            }

        }
    }
}
