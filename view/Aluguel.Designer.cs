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
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tx_data_dev = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_fatura = new System.Windows.Forms.TextBox();
            this.tx_condutor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tx_selecione = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.veiculosCombo = new System.Windows.Forms.ComboBox();
            this.tx_seguro = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tx_data_ret
            // 
            this.tx_data_ret.Location = new System.Drawing.Point(32, 180);
            this.tx_data_ret.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tx_data_ret.Name = "tx_data_ret";
            this.tx_data_ret.Size = new System.Drawing.Size(323, 26);
            this.tx_data_ret.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(31, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data da retirada";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(31, 217);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Data da devolução";
            // 
            // tx_data_dev
            // 
            this.tx_data_dev.Location = new System.Drawing.Point(32, 256);
            this.tx_data_dev.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tx_data_dev.Name = "tx_data_dev";
            this.tx_data_dev.Size = new System.Drawing.Size(323, 26);
            this.tx_data_dev.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(731, 511);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 38);
            this.button1.TabIndex = 12;
            this.button1.Text = "Alugar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 316);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Seguro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(562, 325);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Fatura";
            // 
            // tx_fatura
            // 
            this.tx_fatura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tx_fatura.Location = new System.Drawing.Point(563, 368);
            this.tx_fatura.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tx_fatura.Name = "tx_fatura";
            this.tx_fatura.Size = new System.Drawing.Size(114, 26);
            this.tx_fatura.TabIndex = 19;
            // 
            // tx_condutor
            // 
            this.tx_condutor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tx_condutor.FormattingEnabled = true;
            this.tx_condutor.Items.AddRange(new object[] {
            "CNH provisória",
            "CNH definitiva"});
            this.tx_condutor.Location = new System.Drawing.Point(32, 467);
            this.tx_condutor.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tx_condutor.Name = "tx_condutor";
            this.tx_condutor.Size = new System.Drawing.Size(180, 26);
            this.tx_condutor.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(31, 439);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Condutor";
            // 
            // tx_selecione
            // 
            this.tx_selecione.FormattingEnabled = true;
            this.tx_selecione.Items.AddRange(new object[] {
            "Chevrolet",
            "Fiat "});
            this.tx_selecione.Location = new System.Drawing.Point(563, 182);
            this.tx_selecione.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tx_selecione.Name = "tx_selecione";
            this.tx_selecione.Size = new System.Drawing.Size(261, 26);
            this.tx_selecione.TabIndex = 22;
            this.tx_selecione.SelectedIndexChanged += new System.EventHandler(this.tx_selecione_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(562, 137);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Selecione a Marca";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 110);
            this.panel1.TabIndex = 24;
            // 
            // veiculosCombo
            // 
            this.veiculosCombo.FormattingEnabled = true;
            this.veiculosCombo.Location = new System.Drawing.Point(563, 271);
            this.veiculosCombo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.veiculosCombo.Name = "veiculosCombo";
            this.veiculosCombo.Size = new System.Drawing.Size(261, 26);
            this.veiculosCombo.TabIndex = 25;
            this.veiculosCombo.SelectedIndexChanged += new System.EventHandler(this.veiculosCombo_SelectedIndexChanged);
            // 
            // tx_seguro
            // 
            this.tx_seguro.FormattingEnabled = true;
            this.tx_seguro.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.tx_seguro.Location = new System.Drawing.Point(34, 366);
            this.tx_seguro.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tx_seguro.Name = "tx_seguro";
            this.tx_seguro.Size = new System.Drawing.Size(132, 26);
            this.tx_seguro.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(562, 232);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Selecione o veículo\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::locadora.Properties.Resources.logoFundoTransparente;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Aluguel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(878, 564);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tx_seguro);
            this.Controls.Add(this.veiculosCombo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tx_selecione);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tx_condutor);
            this.Controls.Add(this.tx_fatura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tx_data_dev);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tx_data_ret);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "Aluguel";
            this.Text = "aluguel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.aluguel_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker tx_data_ret;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker tx_data_dev;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_fatura;
        private System.Windows.Forms.ComboBox tx_condutor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox tx_selecione;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox veiculosCombo;
        private System.Windows.Forms.ComboBox tx_seguro;
        private System.Windows.Forms.Label label6;
    }
}