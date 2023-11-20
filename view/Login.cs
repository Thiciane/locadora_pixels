using System;
using System.Windows.Forms;

namespace locadora.view
{
    public partial class Login : Form
    {
        model.ClienteMetodos clienteMet = new model.ClienteMetodos();
        model.Cliente cliente = new model.Cliente();


        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            clienteMet.ListarClientes();
        }
        private void lbCadastro_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.ShowDialog();
            Close();

        }

        private void bLogar_Click(object sender, EventArgs e)
        {
            try
            {
                if (clienteMet.VerificarCliente(tbEmail.Text))
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
    }
}
