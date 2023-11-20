using System;
using System.Collections.Generic;
namespace locadora.model
{
    internal class Locacao
    {
        public DateTime DataRet { get; set; }
        public DateTime DataDev { get; set; }
        public string Seguro { get; set; }

        public Locacao()
        {
        }

        public Locacao(DateTime dataR, DateTime dataD, string seguro)
        {
            this.DataRet = dataR;
            this.DataDev = dataD;
            this.Seguro = seguro;

        }
        public bool Verifica(DateTime dataR, DateTime dataD)
        {
            if (dataD >= DateTime.Today)
            {
                if (dataD > dataR)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            /*if (tx_data_dev.Value == tx_data_ret.Value)
            {
                MessageBox.Show("O mínimo de tempo com o carro é 24 horas", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        public int TotalDias()
        {
            int dias = 0;
            TimeSpan ts = this.DataDev.Subtract(this.DataRet);
            string texto = ts.Days.ToString();//convertendo para dias
            dias = int.Parse(texto); //convertendo para int
            return dias;
        }


        public double ValorAluguel(double valorCarro)
        {
          
            if (this.Seguro == "Sim")
            {
                return (valorCarro * this.TotalDias()) + 100;
                 
            }

            else
            {
                return (valorCarro * this.TotalDias());
                
            }

        }
    }
}
