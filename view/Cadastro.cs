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
            cliente.Sexo = cbSexo.Text;
            cliente.Cep = mkCep.Text;
            cliente.Bairro = tbBairro.Text;
            cliente.Localidade = tbLocalidade.Text;
            cliente.Telefone = mkTelefone.Text;
            cliente.Cpf = mkCpf.Text;
            cliente.Cnh = mkCnh.Text;

            if (cliente.VerificarCliente(cliente.Email) == false)
            {
                cliente.AddCliente(cliente);

                Home home = new Home();
                //home.lbLoginCadastro.Text = cliente.Nome;
                //home.lbLoginCadastro.Location = new Point(0, 32);//.X = -562;
                //home.lbLoginCadastro.Left = 3;
                home.ShowDialog();
                Close();

            }
            else
            {
                MessageBox.Show("Usuário já cadastrado");
            }
        }

        private void Cadastro_Load_1(object sender, EventArgs e)
        {

        }
    }
}
