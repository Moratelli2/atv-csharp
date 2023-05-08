namespace AtvFormsComp
{
    partial class fmrPrincipal
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
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnPoupanca = new System.Windows.Forms.Button();
            this.btnCorrente = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(196, 109);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(4);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(203, 28);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // btnPoupanca
            // 
            this.btnPoupanca.Location = new System.Drawing.Point(196, 208);
            this.btnPoupanca.Margin = new System.Windows.Forms.Padding(4);
            this.btnPoupanca.Name = "btnPoupanca";
            this.btnPoupanca.Size = new System.Drawing.Size(203, 28);
            this.btnPoupanca.TabIndex = 3;
            this.btnPoupanca.Text = "Conta Poupanca";
            this.btnPoupanca.UseVisualStyleBackColor = true;
            this.btnPoupanca.Click += new System.EventHandler(this.btnPoupanca_Click);
            // 
            // btnCorrente
            // 
            this.btnCorrente.Location = new System.Drawing.Point(196, 157);
            this.btnCorrente.Margin = new System.Windows.Forms.Padding(4);
            this.btnCorrente.Name = "btnCorrente";
            this.btnCorrente.Size = new System.Drawing.Size(203, 28);
            this.btnCorrente.TabIndex = 4;
            this.btnCorrente.Text = "Conta Corrente";
            this.btnCorrente.UseVisualStyleBackColor = true;
            this.btnCorrente.Click += new System.EventHandler(this.btnCorrente_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(133, 38);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(319, 36);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Sistema de Cadastro";
            // 
            // fmrPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 298);
            this.Controls.Add(this.btnPoupanca);
            this.Controls.Add(this.btnCorrente);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnClientes);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fmrPrincipal";
            this.Text = "Tela Inicial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnPoupanca;
        private System.Windows.Forms.Button btnCorrente;
        private System.Windows.Forms.Label lblTitulo;
    }
}

