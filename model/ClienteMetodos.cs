using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace locadora.model
{
    internal class ClienteMetodos
    {
        private string caminhoArquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Clientes.xml");
        private XmlSerializer serializer = new XmlSerializer(typeof(List<Cliente>));
        private List<Cliente> listClientes = new List<Cliente>();

        //adiciona o cliente na list
        public void AdicionarClienteLista(Cliente a)
        {
            listClientes.Add(a);
        }

        //diz se o cliente existe por meio da existencia do email na list
        public bool VerificarCliente(string email)
        {
            return this.listClientes.Any(r => r.Email == email);
        }

        //transforma o arquivo xml em list 
        public List<Cliente> ListarClientes()
        {

            if (File.Exists(this.caminhoArquivo))
            {

                using (FileStream fileStream = new FileStream(this.caminhoArquivo, FileMode.Open))
                {
                    this.listClientes = (List<Cliente>)this.serializer.Deserialize(fileStream);
                }
            }

            return this.listClientes;
        }

        //adiciona o cliente ao arquivo xml por meio da list
        public void SalvarCliente(Cliente a)
        {
            AdicionarClienteLista(a);

            using (FileStream fileStream = new FileStream(this.caminhoArquivo, FileMode.Create))
            {
                this.serializer.Serialize(fileStream, listClientes);
            }
        }
    }
}
