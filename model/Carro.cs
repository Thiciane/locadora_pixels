using System;

namespace locadora.model
{
    public class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public double Preco { get; set; }
        public Carro(string marca, string modelo)
        {
            this.Marca = marca;
            this.Modelo = modelo;
        }

        public double DefinirPreco()
        {
            if (this.Marca == "Chevrolet")
            {
                if (this.Modelo == "Montana")
                    this.Preco = 250;

                else if (this.Modelo == "S10")
                    this.Preco = 300;

                else if (this.Modelo == "Onix")
                    this.Preco = 100;
            }
            else if (this.Marca == "Fiat")
            {
                if (this.Modelo == "Strada")
                    this.Preco = 200;

                if (this.Modelo == "Cronos")
                    this.Preco = 150;

                if (this.Modelo == "Mobi")
                    this.Preco = 80;
            }
            return this.Preco;
        } 
    }
}
