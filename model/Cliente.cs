using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locadora.model
{
    public class Cliente
    {
        public List<Cliente> listClientes { get; set; } = new List<Cliente>();
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Sexo { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }
        public string Cnh { get; set; }

        public Cliente()
        {
        }

        public Cliente(string nome, string email, string sexo, string cep, string bairro, string localidade, string telefone, string cpf, string cnh)
        {
            this.Nome = nome;
            this.Email = email;
            this.Sexo = sexo;
            this.Cep = cep;
            this.Bairro = bairro;
            this.Localidade = localidade;
            this.Telefone = telefone;
            this.Cpf = cpf;
            this.Cnh = cnh;
        }

        //adiciona o cliente na lista
        public void AddCliente(Cliente a)
        {
            try
            {
                listClientes.Add(a);
                //SalvarClientesEmJson();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro ao adicionar um cliente: {ex.Message}");
            }
        }

        //diz se o cliente existe por meio da existencia do email na lista
        public bool VerificarCliente(string email)
        {
            return listClientes.Any(r => r.Email == email);
        }
        //tenta salvar o cliente que estão na lista em json

        /*public void SalvarClientesEmJson()
        {
            try
            {
                var settings = new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                    PreserveReferencesHandling = PreserveReferencesHandling.Objects
                };

                string json = JsonConvert.SerializeObject(listClientes);
                File.WriteAllText("clientes.json", json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro ao salvar os clientes em JSON: {ex.Message}");
            }

        }*/

    }
}
