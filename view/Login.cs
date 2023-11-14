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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void bt_logar_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.ShowDialog();
        }
        private void lbCadastro_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.ShowDialog();
            Close();

        }
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void bLogar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbEmail.Text))
                {
                    MessageBox.Show("Por favor, insira um endereço de e-mail.");
                    return;
                }

                model.Cliente cliente = new model.Cliente();
                if (cliente.VerificarCliente(tbEmail.Text))
                {
                    Home home = new Home();
                    home.lbLoginCadastro.Text = tbNome.Text;
                    home.lbLoginCadastro.Location = new Point(0, 32);
                    home.lbLoginCadastro.Left = 3;
                    home.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Usuário não cadastrado. Verifique se o e-mail está correto ou cadastre-se.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}");
            }
        }

        private void tbNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
