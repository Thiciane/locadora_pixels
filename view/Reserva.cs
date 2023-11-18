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
    public partial class Reserva : Form
    {
        public Reserva()
        {
            InitializeComponent();
        }

        private void Reserva_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            model.Carro carro = new model.Carro(cbMarca.Text, cbModelo.Text);
            model.Reserva reserva = new model.Reserva(nDias.Value);
            double preco = carro.DefinirPreco();

            lbValorTotalN.Text = reserva.CalcularConta(preco).ToString("C");
            lbValorDiaN.Text = (preco/Convert.ToDouble(nDias.Value)).ToString("C");
            MessageBox.Show("Reservado", "Status da reserva", MessageBoxButtons.OK);

        }

        private void lValorTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
