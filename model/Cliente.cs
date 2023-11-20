namespace locadora.model
{
    public class Cliente
    {

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
            this.Nome = nome;
            this.Email = email;
            this.Cep = cep;
            this.Bairro = bairro;
            this.Localidade = localidade;
            this.Cpf = cpf;
            this.Cnh = cnh;
        }
    }
}