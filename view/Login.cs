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
                model.Cliente cliente = new model.Cliente();
                if (cliente.VerificarCliente(tbEmail.Text) || tbNome.Text.Equals("adm") && tbEmail.Text.Equals("adm@gmail.com"))
                {
                    Home home = new Home();
                    home.lbLoginCadastro.Text = String.Empty;
                    home.lbAlugar.Text = "Alugar";
                    home.lbReservar.Text = "Reservar";
                    home.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show( "Verifique se o e-mail está correto ou cadastre-se.", "Usuário não encontrado.", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
