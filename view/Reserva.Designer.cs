namespace locadora.view
{
    partial class Reserva
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbModelo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.nDias = new System.Windows.Forms.NumericUpDown();
            this.lValores = new System.Windows.Forms.Label();
            this.lValorTotal = new System.Windows.Forms.Label();
            this.lb_VLdia = new System.Windows.Forms.Label();
            this.lbValorTotalN = new System.Windows.Forms.Label();
            this.lbValorDiaN = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDias)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 111);
            this.panel1.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(177, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 28);
            this.label10.TabIndex = 5;
            this.label10.Text = "RESERVA";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::locadora.Properties.Resources.logoFundoTransparente;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(158, 108);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // cbMarca
            // 
            this.cbMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Items.AddRange(new object[] {
            "Chevrolet",
            "Fiat"});
            this.cbMarca.Location = new System.Drawing.Point(36, 260);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(234, 32);
            this.cbMarca.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(33, 362);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(33, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Marca";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(33, 141);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(342, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Por quantos dias deseja alugar o veículo?";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // cbModelo
            // 
            this.cbModelo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbModelo.FormattingEnabled = true;
            this.cbModelo.Items.AddRange(new object[] {
            "Montana",
            "S10",
            "Onix",
            "",
            "Strada",
            "Cronos",
            "Mobi"});
            this.cbModelo.Location = new System.Drawing.Point(36, 382);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(234, 32);
            this.cbModelo.TabIndex = 33;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(690, 509);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 39);
            this.button1.TabIndex = 36;
            this.button1.Text = "Reservar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(516, 509);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 39);
            this.button2.TabIndex = 37;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // nDias
            // 
            this.nDias.Location = new System.Drawing.Point(36, 164);
            this.nDias.Name = "nDias";
            this.nDias.Size = new System.Drawing.Size(122, 26);
            this.nDias.TabIndex = 38;
            // 
            // lValores
            // 
            this.lValores.AutoSize = true;
            this.lValores.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lValores.Location = new System.Drawing.Point(544, 141);
            this.lValores.Name = "lValores";
            this.lValores.Size = new System.Drawing.Size(74, 18);
            this.lValores.TabIndex = 36;
            this.lValores.Text = "Valores:";
            // 
            // lValorTotal
            // 
            this.lValorTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lValorTotal.AutoSize = true;
            this.lValorTotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lValorTotal.ForeColor = System.Drawing.Color.Black;
            this.lValorTotal.Location = new System.Drawing.Point(896, 141);
            this.lValorTotal.Name = "lValorTotal";
            this.lValorTotal.Size = new System.Drawing.Size(95, 18);
            this.lValorTotal.TabIndex = 34;
            this.lValorTotal.Text = "Valor total:";
            this.lValorTotal.Click += new System.EventHandler(this.lValorTotal_Click);
            // 
            // lb_VLdia
            // 
            this.lb_VLdia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lb_VLdia.AutoSize = true;
            this.lb_VLdia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_VLdia.ForeColor = System.Drawing.Color.Black;
            this.lb_VLdia.Location = new System.Drawing.Point(504, 172);
            this.lb_VLdia.Name = "lb_VLdia";
            this.lb_VLdia.Size = new System.Drawing.Size(114, 18);
            this.lb_VLdia.TabIndex = 35;
            this.lb_VLdia.Text = "Valor por dia:";
            // 
            // lbValorTotalN
            // 
            this.lbValorTotalN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbValorTotalN.AutoSize = true;
            this.lbValorTotalN.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorTotalN.ForeColor = System.Drawing.Color.Black;
            this.lbValorTotalN.Location = new System.Drawing.Point(905, 192);
            this.lbValorTotalN.Name = "lbValorTotalN";
            this.lbValorTotalN.Size = new System.Drawing.Size(95, 18);
            this.lbValorTotalN.TabIndex = 37;
            this.lbValorTotalN.Text = "Valor total:";
            // 
            // lbValorDiaN
            // 
            this.lbValorDiaN.Location = new System.Drawing.Point(763, 237);
            this.lbValorDiaN.Name = "lbValorDiaN";
            this.lbValorDiaN.Size = new System.Drawing.Size(100, 26);
            this.lbValorDiaN.TabIndex = 39;
            // 
            // Reserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1012, 674);
            this.Controls.Add(this.lbValorDiaN);
            this.Controls.Add(this.lbValorTotalN);
            this.Controls.Add(this.lValorTotal);
            this.Controls.Add(this.lb_VLdia);
            this.Controls.Add(this.nDias);
            this.Controls.Add(this.lValores);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbModelo);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Reserva";
            this.Text = "Reservaa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Reserva_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbModelo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown nDias;
        private System.Windows.Forms.Label lValores;
        private System.Windows.Forms.Label lValorTotal;
        private System.Windows.Forms.Label lb_VLdia;
        private System.Windows.Forms.Label lbValorTotalN;
        private System.Windows.Forms.TextBox lbValorDiaN;
    }
}