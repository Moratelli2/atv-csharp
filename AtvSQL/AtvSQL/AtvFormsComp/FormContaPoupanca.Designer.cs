namespace AtvFormsComp
{
    partial class FormContaPoupanca
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
            this.btnSaveContaPoupanca = new System.Windows.Forms.Button();
            this.dgvContaPoupanca = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTaxaJuros = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQtdTempo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContaPoupanca)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveContaPoupanca
            // 
            this.btnSaveContaPoupanca.Location = new System.Drawing.Point(13, 249);
            this.btnSaveContaPoupanca.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveContaPoupanca.Name = "btnSaveContaPoupanca";
            this.btnSaveContaPoupanca.Size = new System.Drawing.Size(113, 34);
            this.btnSaveContaPoupanca.TabIndex = 23;
            this.btnSaveContaPoupanca.Text = "Salvar";
            this.btnSaveContaPoupanca.UseVisualStyleBackColor = true;
            this.btnSaveContaPoupanca.Click += new System.EventHandler(this.btnSaveContaPoupanca_Click);
            // 
            // dgvContaPoupanca
            // 
            this.dgvContaPoupanca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContaPoupanca.Location = new System.Drawing.Point(13, 291);
            this.dgvContaPoupanca.Margin = new System.Windows.Forms.Padding(4);
            this.dgvContaPoupanca.Name = "dgvContaPoupanca";
            this.dgvContaPoupanca.RowHeadersWidth = 51;
            this.dgvContaPoupanca.Size = new System.Drawing.Size(651, 261);
            this.dgvContaPoupanca.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Taxa Juros";
            // 
            // txtTaxaJuros
            // 
            this.txtTaxaJuros.Location = new System.Drawing.Point(152, 180);
            this.txtTaxaJuros.Margin = new System.Windows.Forms.Padding(4);
            this.txtTaxaJuros.Name = "txtTaxaJuros";
            this.txtTaxaJuros.Size = new System.Drawing.Size(132, 22);
            this.txtTaxaJuros.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Qtd Tempo";
            // 
            // txtQtdTempo
            // 
            this.txtQtdTempo.Location = new System.Drawing.Point(152, 147);
            this.txtQtdTempo.Margin = new System.Windows.Forms.Padding(4);
            this.txtQtdTempo.Name = "txtQtdTempo";
            this.txtQtdTempo.Size = new System.Drawing.Size(132, 22);
            this.txtQtdTempo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(152, 81);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(132, 22);
            this.txtDescricao.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Saldo";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(152, 113);
            this.txtSaldo.Margin = new System.Windows.Forms.Padding(4);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(132, 22);
            this.txtSaldo.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 43);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(152, 47);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(132, 22);
            this.txtId.TabIndex = 24;
            // 
            // FormContaPoupanca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 565);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSaveContaPoupanca);
            this.Controls.Add(this.txtTaxaJuros);
            this.Controls.Add(this.dgvContaPoupanca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQtdTempo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label2);
            this.Name = "FormContaPoupanca";
            this.Text = "ContaPoupança";
            this.Load += new System.EventHandler(this.FormContaPoupanca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContaPoupanca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSaveContaPoupanca;
        private System.Windows.Forms.DataGridView dgvContaPoupanca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTaxaJuros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQtdTempo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtId;
    }
}