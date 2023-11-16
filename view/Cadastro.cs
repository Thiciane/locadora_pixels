using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace locadora.view
{
    public partial class Cadastro : Form
    {

        public Cadastro()
        {
            InitializeComponent();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void bCadastrar_Click(object sender, EventArgs e)
        {
            model.Cliente cliente = new model.Cliente();
            cliente.Nome = tbNome.Text;
            cliente.Email = tbEmail.Text;
            cliente.Cep = mkCep.Text;
            cliente.Bairro = tbBairro.Text;
            cliente.Localidade = tbLocalidade.Text;
            cliente.Cpf = mkCpf.Text;
            cliente.Cnh = mkCnh.Text;

            if (cliente.VerificarCliente(cliente.Email) == false)
            {
                cliente.AddCliente(cliente);

                Home home = new Home();
                home.lbUsuario.Text = cliente.Nome;
                home.lbLoginCadastro.Text = String.Empty;
                home.lbAlugar.Text = "Alugar";
                home.lbReservar.Text = "Reservar";
                home.ShowDialog();
                Close();

            }
            else if(tbNome.Text.Equals("adm") && tbEmail.Text.Equals("adm@gmail.com"))
            {
                MessageBox.Show("Usuário já cadastrado", "Faça login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}