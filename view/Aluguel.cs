using System;
using System.Windows.Forms;

namespace locadora.view
{
    public partial class Aluguel : Form
    {
        model.Locacao locacao = new model.Locacao();
        public Aluguel()
        {
            InitializeComponent();
            tx_fatura.Text = string.Empty;
            tx_data_ret.MinDate = DateTime.Today;
            tx_data_dev.MinDate = DateTime.Today.AddDays(1);

        }

        private void aluguel_Load(object sender, EventArgs e)
        {

        }

        private void tb_marca_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (tb_marca.SelectedIndex)
            {
                //Chevrolet
                case 0:
                    // inserir no 2 combo os veiculos
                    tb_modelo.Items.Clear();
                    tb_modelo.Items.Add("Montana");
                    tb_modelo.Items.Add("Onix");
                    tb_modelo.Items.Add("S10");
                    break;

                //Fiat
                case 1:
                    tb_modelo.Items.Clear();
                    tb_modelo.Items.Add("Mobi");
                    tb_modelo.Items.Add("Strada");
                    tb_modelo.Items.Add("Cronos");
                    break;
            }
        }

        private void bt_alugar_Click(object sender, EventArgs e)
        {
            locacao.DataRet = tx_data_ret.Value;
            locacao.DataDev = tx_data_dev.Value;
            if (locacao.Verifica(locacao.DataRet, locacao.DataDev) == false)
            {
                MessageBox.Show("Datas incorretas", "Erro");

            }
            else
            {
                model.Carro carro = new model.Carro();
                carro.Marca = tb_marca.Text;
                carro.Modelo = tb_modelo.Text;
                double preco = carro.DefinirPreco();

                locacao.Seguro = tb_seguro.Text;
                tx_fatura.Text = locacao.ValorAluguel(preco).ToString("C");
                MessageBox.Show("Alugado", "Status do aluguel", MessageBoxButtons.OK);

            }
            if (tb_marca.Text == "" || tb_modelo.Text == "")
            {
                MessageBox.Show("Marca ou modelo não selecionado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tb_seguro.Text = String.Empty;
            tb_condutor.Text = String.Empty;
            tb_marca.Text = String.Empty;
            tb_modelo.Text = String.Empty;
            tx_fatura.Text = String.Empty;



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

        private void tx_data_dev_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
