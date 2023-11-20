using System;
using System.Drawing;
using System.Windows.Forms;

namespace locadora
{
    public partial class Home : Form
    {
        view.Login login = new view.Login();

        public Home()
        {
            InitializeComponent();
            lbAlugar.Text = String.Empty;
            lbReservar.Text = String.Empty;
            lbLoginCadastro.Location = new Point(700, 43);
        }

        private int numeroImagem = 1;
        private void LoadNextImage()
        {
            if (numeroImagem == 7)
            {
                numeroImagem = 1;
            }
            pictureBox3.ImageLocation = string.Format($@"carrosselCarros\{numeroImagem}.png");
            numeroImagem++;
        }
        private void timer2_Tick_1(object sender, EventArgs e)
        {
            LoadNextImage();

        }
        private void lbLoginCadastro_Click(object sender, EventArgs e)
        {
            login.ShowDialog();
            Close();

        }

        private void lbAlugar_Click(object sender, EventArgs e)
        {
            view.Aluguel alugar = new view.Aluguel();
            alugar.ShowDialog();
            Close();
        }

        private void lbReservar_Click(object sender, EventArgs e)
        {
            view.Reserva reserva = new view.Reserva();
            reserva.ShowDialog();
            Close();
        }

        private void bt_irLogin_Click(object sender, EventArgs e)
        {
            login.ShowDialog();
        }
    }
}
