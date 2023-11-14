﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace locadora
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        view.Login login = new view.Login();
        private int imageNumber = 0;
        private void LoadNextImage()
        {
            if (imageNumber == 6)
            {
                imageNumber = 1;
            }
            slidePic.ImageLocation = string.Format(@"Images\carrosselCarros\{0}.png", imageNumber);
            imageNumber++;
        }

        private void timer2_Tick(object sender, EventArgs e)
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
