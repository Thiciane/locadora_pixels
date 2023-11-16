namespace locadora
{
    partial class Home
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Timer timer2;
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbLoginCadastro = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbReservar = new System.Windows.Forms.Label();
            this.lbAlugar = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer2
            // 
            timer2.Interval = 3000;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 592);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.SystemColors.Window;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(947, 186);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.lbUsuario);
            this.panel3.Controls.Add(this.lbReservar);
            this.panel3.Controls.Add(this.lbAlugar);
            this.panel3.Controls.Add(this.lbLoginCadastro);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(947, 100);
            this.panel3.TabIndex = 3;
            // 
            // lbLoginCadastro
            // 
            this.lbLoginCadastro.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbLoginCadastro.AutoSize = true;
            this.lbLoginCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbLoginCadastro.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoginCadastro.Location = new System.Drawing.Point(497, 32);
            this.lbLoginCadastro.Name = "lbLoginCadastro";
            this.lbLoginCadastro.Size = new System.Drawing.Size(207, 28);
            this.lbLoginCadastro.TabIndex = 1;
            this.lbLoginCadastro.Text = "Login / Cadastro";
            this.lbLoginCadastro.Click += new System.EventHandler(this.lbLoginCadastro_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::locadora.Properties.Resources.logoFundoTransparente;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(127, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(529, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Alugar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login / Cadastro";
            // 
            // lbReservar
            // 
            this.lbReservar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbReservar.AutoSize = true;
            this.lbReservar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbReservar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReservar.ForeColor = System.Drawing.Color.White;
            this.lbReservar.Location = new System.Drawing.Point(806, 32);
            this.lbReservar.Name = "lbReservar";
            this.lbReservar.Size = new System.Drawing.Size(112, 28);
            this.lbReservar.TabIndex = 3;
            this.lbReservar.Text = "Reservar";
            this.lbReservar.Click += new System.EventHandler(this.lbReservar_Click);
            // 
            // lbAlugar
            // 
            this.lbAlugar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbAlugar.AutoSize = true;
            this.lbAlugar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbAlugar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAlugar.ForeColor = System.Drawing.Color.Red;
            this.lbAlugar.Location = new System.Drawing.Point(710, 32);
            this.lbAlugar.Name = "lbAlugar";
            this.lbAlugar.Size = new System.Drawing.Size(90, 28);
            this.lbAlugar.TabIndex = 2;
            this.lbAlugar.Text = "Alugar";
            this.lbAlugar.Click += new System.EventHandler(this.lbAlugar_Click);
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.lbUsuario.Location = new System.Drawing.Point(135, 32);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(84, 28);
            this.lbUsuario.TabIndex = 4;
            this.lbUsuario.Text = "label3";
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(947, 592);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox slidePic;
        private System.Windows.Forms.Timer timer1;
       //private System.Windows.Forms.PictureBox slidePic;
        //private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbLoginCadastro;
        public System.Windows.Forms.Label lbAlugar;
        public System.Windows.Forms.Label lbReservar;
        public System.Windows.Forms.Label lbUsuario;
    }
}

