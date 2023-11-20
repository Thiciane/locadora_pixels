using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace locadora.model
{
    internal class ClienteMetodos
    {
        public List<Cliente> listClientes = new List<Cliente>();

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
            string caminhoArquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Clientes.xml");

            if (File.Exists(caminhoArquivo))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Cliente>));

                using (FileStream fileStream = new FileStream(caminhoArquivo, FileMode.Open))
                {
                    this.listClientes = (List<Cliente>)serializer.Deserialize(fileStream);
                }
            }

            return this.listClientes;
        }

        //adiciona o cliente ao arquivo xml por meio da list
        public void SalvarCliente(Cliente a)
        {
            string caminhoArquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Clientes.xml");
            AdicionarClienteLista(a);

            XmlSerializer serializer = new XmlSerializer(typeof(List<Cliente>));

            using (FileStream fileStream = new FileStream(caminhoArquivo, FileMode.Create))
            {
                serializer.Serialize(fileStream, listClientes);
            }
        }
    }
}
