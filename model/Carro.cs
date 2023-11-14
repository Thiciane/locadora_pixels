using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locadora.model
{
    public class Carro
    {
        private string Cor { get; set; }
        private string Placa { get; set; }
        private string Marca { get; set; }
        private int Ano { get; set; }
        public Carro(string cor, string placa, string marca, int ano)
        {
            Cor = cor;
            Placa = placa;
            Marca = marca;
            Ano = ano;
        }
    }
}
