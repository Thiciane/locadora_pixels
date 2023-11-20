using System;
using System.Windows.Forms;

namespace locadora.view
{
    public partial class Reserva : Form
    {
        public Reserva()
        {
            InitializeComponent();
        }
        
        private void Reserva_Load(object sender, EventArgs e)
        {
            lbValorDiaN.Text = string.Empty;
            lbValorTotalN.Text = string.Empty;
        }
        
        private void cbMarca_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch (cbMarca.SelectedIndex)
            {
                //Chevrolet
                case 0:
                    cbModelo.Items.Clear();
                    cbModelo.Items.Add("Montana");
                    cbModelo.Items.Add("Onix");
                    cbModelo.Items.Add("S10");
                    break;

                //Fiat
                case 1:
                    cbModelo.Items.Clear();
                    cbModelo.Items.Add("Mobi");
                    cbModelo.Items.Add("Strada");
                    cbModelo.Items.Add("Cronos");
                    break;
            }
        }

        private void btReserva_Click(object sender, EventArgs e)
        {
            if(nDias.Value <= 0)
            {
                MessageBox.Show("Número de dias não selecionado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                model.Carro carro = new model.Carro(cbMarca.Text, cbModelo.Text);
                model.Reserva reserva = new model.Reserva(nDias.Value);
                double preco = carro.DefinirPreco();

                lbValorTotalN.Text = reserva.CalcularConta(preco).ToString("C");
                lbValorDiaN.Text = preco.ToString("C");
                MessageBox.Show("Reservado", "Status da reserva", MessageBoxButtons.OK);
            }
            
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            cbMarca.Text = String.Empty;
            cbModelo.Text = String.Empty;
            lbValorDiaN.Text = String.Empty;
            lbValorTotalN.Text = String.Empty;



            if (MessageBox.Show("Deseja mesmo cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Home home = new Home();
                home.lbLoginCadastro.Text = String.Empty;
                home.lbAlugar.Text = "Alugar";
                home.lbReservar.Text = "Reservar";
                home.ShowDialog();
                Close();
            }
        }
        private void cbModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbMarca.SelectedIndex)
            {
                //Chevrolet
                case 0:
                    switch (cbModelo.SelectedIndex) 
                    {
                        //Montana
                        case 0:
                            slidePic.ImageLocation = string.Format(@"carrosselCarros\1.png");
                            break;
                        //Onix
                        case 1:
                            slidePic.ImageLocation = string.Format(@"carrosselCarros\6.png");
                            break;
                        //S10
                        case 2:
                            slidePic.ImageLocation = string.Format(@"carrosselCarros\2.png");
                            break;
                    }

                    break;

                //Fiat
                case 1:
                    switch (cbModelo.SelectedIndex)
                    {
                        //Mobi
                        case 0:
                            slidePic.ImageLocation = string.Format(@"carrosselCarros\4.png");
                            break;
                        //Strada
                        case 1:
                            slidePic.ImageLocation = string.Format(@"carrosselCarros\5.png");
                            break;
                        //Cronos
                        case 2:
                            slidePic.ImageLocation = string.Format(@"carrosselCarros\3.png");
                            break;
                    }

                    break;
            }
        }
    }
}
