using System;
using System.Windows.Forms;

namespace locadora.view
{

    public partial class Cadastro : Form
    {
        model.ClienteMetodos clienteMet = new model.ClienteMetodos();
        Home home = new Home();


        public Cadastro()
        {
            InitializeComponent();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
            clienteMet.ListarClientes();
        }

        private void bt_cadastrar_Click(object sender, EventArgs e)
        {
            if (ValidaCampus())
            {
                model.Cliente cliente = new model.Cliente()
                {
                    Nome = tbNome.Text,
                    Email = tbEmail.Text,
                    Cep = mkCep.Text,
                    Bairro = tbBairro.Text,
                    Localidade = tbLocalidade.Text,
                    Cpf = mkCpf.Text,
                    Cnh = mkCnh.Text
                };
                if (!clienteMet.VerificarCliente(cliente.Email))
                {
                    clienteMet.SalvarCliente(cliente);

                    home.lbLoginCadastro.Text = String.Empty;
                    home.lbAlugar.Text = "Alugar";
                    home.lbReservar.Text = "Reservar";
                    home.ShowDialog();
                    Close();

                }
                else
                {
                    MessageBox.Show("Usuário já cadastrado", "Faça login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }            
        }
        private bool ValidaCampus()
        {
            bool estado = true;
            if (tbNome.Text == "" || tbEmail.Text == "")
            {
                estado = false;
                errorProvider1.SetError(tbNome, "Campo obrigatório!");
                errorProvider1.SetError(tbEmail, "Campo obrigatório!");
            }
            return estado;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbNome.Text = String.Empty;
            tbEmail.Text = String.Empty;
            tbBairro.Text = String.Empty;
            tbLocalidade.Text = String.Empty;
            mkCep.Text = String.Empty;
            mkCnh.Text = String.Empty;
            mkCpf.Text = String.Empty;



            if (MessageBox.Show("Deseja mesmo cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                home.ShowDialog();
                Close();
            }
        }
    }
}