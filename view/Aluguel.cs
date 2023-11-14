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
    public partial class Aluguel : Form
    {
        public Aluguel()
        {
            InitializeComponent();
        }

        private void aluguel_Load(object sender, EventArgs e)
        {

        }
        private void veiculosCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                model.Locacao locacao = new model.Locacao();
                locacao.dataR = tx_data_ret.Value;
                locacao.dataD = tx_data_dev.Value;
                locacao.seguro = tx_seguro.Text;
                double retorna = 0;
                switch (veiculosCombo.Text)
                {


                    case "Montana":
                        retorna = locacao.Carros(100, locacao.seguro, locacao.dataR, locacao.dataD);
                        tx_fatura.Text = Convert.ToString(retorna);
                        break;

                    case "Onix":
                        retorna = locacao.Carros(150, locacao.seguro, locacao.dataR, locacao.dataD);
                        tx_fatura.Text = Convert.ToString(retorna);
                        break;

                    case "S10":
                        retorna = locacao.Carros(120, locacao.seguro, locacao.dataR, locacao.dataD);
                        tx_fatura.Text = Convert.ToString(retorna);
                        break;

                    case "Mobi":
                        retorna = locacao.Carros(125, locacao.seguro, locacao.dataR, locacao.dataD);
                        tx_fatura.Text = Convert.ToString(retorna);
                        break;

                    case "Strada":
                        retorna = locacao.Carros(115, locacao.seguro, locacao.dataR, locacao.dataD);
                        tx_fatura.Text = Convert.ToString(retorna);
                        break;


                    case "Cronos":
                        retorna = locacao.Carros(95, locacao.seguro, locacao.dataR, locacao.dataD);
                        tx_fatura.Text = Convert.ToString(retorna);
                        break;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Preencha tudo corretamente" + ex.Message);
            }

        }

        private void tx_selecione_SelectedIndexChanged(object sender, EventArgs e)
        {



            int carro = tx_selecione.SelectedIndex;

            switch (carro)
            {


                //Chevrolet
                case 0:

                    // inserir no 2 combo os veiculos
                    veiculosCombo.Items.Clear();

                    veiculosCombo.Items.Add("Montana");
                    veiculosCombo.Items.Add("Onix");
                    veiculosCombo.Items.Add("S10");
                    break;

                //Fiat
                case 1:

                    veiculosCombo.Items.Clear();
                    veiculosCombo.Items.Add("Mobi");
                    veiculosCombo.Items.Add("Strada");
                    veiculosCombo.Items.Add("Cronos");
                    break;
            }





        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
