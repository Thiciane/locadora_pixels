using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace locadora.model
{
    public class Cliente
    {
        public List<Cliente> listClientes { get; set; } = new List<Cliente>();

        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string Cpf { get; set; }
        public string Cnh { get; set; }

        public Cliente()
        {

        }
        public Cliente(string nome, string email, string cep, string bairro, string localidade, string cpf, string cnh)
        {
            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(email))
            {
                throw new ArgumentException("Esse dado não pode ser nulo ou vazio.");
            }
            this.Nome = nome;
            this.Email = email;
            this.Cep = cep;
            this.Bairro = bairro;
            this.Localidade = localidade;
            this.Cpf = cpf;
            this.Cnh = cnh;
        }

        //adiciona o cliente na lista
        public void AddCliente(Cliente a)
        {
            try
            {
                listClientes.Add(a);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro ao adicionar um cliente: {ex.Message}");
            }
        }

        //diz se o cliente existe por meio da existencia do email na lista
        public bool VerificarCliente(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return false;
            }
            return listClientes.Any(r => r.Email == email);

        }
        
    }   
}

    

