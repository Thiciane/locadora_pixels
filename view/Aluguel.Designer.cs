namespace locadora.view
{
    partial class Aluguel
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
            this.tx_data_ret = new System.Windows.Forms.DateTimePicker();
            this.tx_data_dev = new System.Windows.Forms.DateTimePicker();
            this.bt_alugar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_condutor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_marca = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_modelo = new System.Windows.Forms.ComboBox();
            this.tb_seguro = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tx_fatura = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tx_data_ret
            // 
            this.tx_data_ret.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_data_ret.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_data_ret.Location = new System.Drawing.Point(158, 381);
            this.tx_data_ret.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tx_data_ret.MaxDate = new System.DateTime(2024, 11, 19, 0, 0, 0, 0);
            this.tx_data_ret.MinDate = new System.DateTime(2023, 11, 19, 0, 0, 0, 0);
            this.tx_data_ret.Name = "tx_data_ret";
            this.tx_data_ret.Size = new System.Drawing.Size(367, 27);
            this.tx_data_ret.TabIndex = 1;
            this.tx_data_ret.Value = new System.DateTime(2023, 11, 19, 0, 0, 0, 0);
            // 
            // tx_data_dev
            // 
            this.tx_data_dev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tx_data_dev.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_data_dev.Location = new System.Drawing.Point(580, 381);
            this.tx_data_dev.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tx_data_dev.MaxDate = new System.DateTime(2024, 11, 19, 0, 0, 0, 0);
            this.tx_data_dev.MinDate = new System.DateTime(2023, 11, 19, 0, 0, 0, 0);
            this.tx_data_dev.Name = "tx_data_dev";
            this.tx_data_dev.Size = new System.Drawing.Size(367, 27);
            this.tx_data_dev.TabIndex = 9;
            this.tx_data_dev.Value = new System.DateTime(2023, 11, 19, 0, 0, 0, 0);
            this.tx_data_dev.ValueChanged += new System.EventHandler(this.tx_data_dev_ValueChanged);
            // 
            // bt_alugar
            // 
            this.bt_alugar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_alugar.BackColor = System.Drawing.Color.White;
            this.bt_alugar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_alugar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.bt_alugar.Location = new System.Drawing.Point(958, 465);
            this.bt_alugar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.bt_alugar.MaximumSize = new System.Drawing.Size(140, 50);
            this.bt_alugar.Name = "bt_alugar";
            this.bt_alugar.Size = new System.Drawing.Size(140, 50);
            this.bt_alugar.TabIndex = 12;
            this.bt_alugar.Text = "Alugar";
            this.bt_alugar.UseVisualStyleBackColor = false;
            this.bt_alugar.Click += new System.EventHandler(this.bt_alugar_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(576, 463);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Fatura:";
            // 
            // tb_condutor
            // 
            this.tb_condutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tb_condutor.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.tb_condutor.FormattingEnabled = true;
            this.tb_condutor.Items.AddRange(new object[] {
            "CNH provisória",
            "CNH definitiva"});
            this.tb_condutor.Location = new System.Drawing.Point(345, 463);
            this.tb_condutor.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tb_condutor.MaximumSize = new System.Drawing.Size(200, 0);
            this.tb_condutor.Name = "tb_condutor";
            this.tb_condutor.Size = new System.Drawing.Size(200, 29);
            this.tb_condutor.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(341, 442);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Condutor";
            // 
            // tb_marca
            // 
            this.tb_marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tb_marca.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.tb_marca.FormattingEnabled = true;
            this.tb_marca.Items.AddRange(new object[] {
            "Chevrolet",
            "Fiat"});
            this.tb_marca.Location = new System.Drawing.Point(158, 284);
            this.tb_marca.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tb_marca.MaximumSize = new System.Drawing.Size(290, 0);
            this.tb_marca.Name = "tb_marca";
            this.tb_marca.Size = new System.Drawing.Size(290, 29);
            this.tb_marca.TabIndex = 22;
            this.tb_marca.SelectedIndexChanged += new System.EventHandler(this.tb_marca_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(154, 263);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 19);
            this.label7.TabIndex = 23;
            this.label7.Text = "Marca";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1144, 129);
            this.panel1.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 18.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(197, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 29);
            this.label8.TabIndex = 1;
            this.label8.Text = "ALUGUEL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::locadora.Properties.Resources.logoFundoTransparente;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tb_modelo
            // 
            this.tb_modelo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_modelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tb_modelo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.tb_modelo.FormattingEnabled = true;
            this.tb_modelo.Location = new System.Drawing.Point(580, 284);
            this.tb_modelo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tb_modelo.MaximumSize = new System.Drawing.Size(290, 0);
            this.tb_modelo.Name = "tb_modelo";
            this.tb_modelo.Size = new System.Drawing.Size(290, 29);
            this.tb_modelo.TabIndex = 25;
            // 
            // tb_seguro
            // 
            this.tb_seguro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tb_seguro.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.tb_seguro.FormattingEnabled = true;
            this.tb_seguro.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.tb_seguro.Location = new System.Drawing.Point(158, 462);
            this.tb_seguro.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tb_seguro.Name = "tb_seguro";
            this.tb_seguro.Size = new System.Drawing.Size(146, 29);
            this.tb_seguro.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(576, 263);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 19);
            this.label6.TabIndex = 27;
            this.label6.Text = "Modelo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(154, 360);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 19);
            this.label9.TabIndex = 4;
            this.label9.Text = "Data da retirada";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(576, 360);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 19);
            this.label10.TabIndex = 8;
            this.label10.Text = "Data da devolução";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(154, 441);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 19);
            this.label11.TabIndex = 15;
            this.label11.Text = "Seguro";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(811, 465);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 50);
            this.button2.TabIndex = 38;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tx_fatura
            // 
            this.tx_fatura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tx_fatura.AutoSize = true;
            this.tx_fatura.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_fatura.ForeColor = System.Drawing.Color.Red;
            this.tx_fatura.Location = new System.Drawing.Point(656, 463);
            this.tx_fatura.Name = "tx_fatura";
            this.tx_fatura.Size = new System.Drawing.Size(69, 23);
            this.tx_fatura.TabIndex = 39;
            this.tx_fatura.Text = "label1";
            // 
            // Aluguel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1144, 569);
            this.Controls.Add(this.tx_fatura);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_seguro);
            this.Controls.Add(this.tb_modelo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_marca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_condutor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.bt_alugar);
            this.Controls.Add(this.tx_data_dev);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tx_data_ret);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "Aluguel";
            this.ShowIcon = false;
            this.Text = "aluguel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.aluguel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker tx_data_ret;
        private System.Windows.Forms.DateTimePicker tx_data_dev;
        private System.Windows.Forms.Button bt_alugar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox tb_condutor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox tb_marca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox tb_modelo;
        private System.Windows.Forms.ComboBox tb_seguro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label tx_fatura;
    }
}