using AtvFormsComp.model;
using AtvFormsComp.services;
using System;
using System.Windows.Forms;

namespace AtvFormsComp
{
    public partial class FormContaPoupanca : Form
    {
        public FormContaPoupanca()
        {
            InitializeComponent();
        }

        private void FormContaPoupanca_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void btnSaveContaPoupanca_Click(object sender, EventArgs e)
        {
            ContaPoupanca contaPoupanca = new ContaPoupanca();

            contaPoupanca.Id = Convert.ToInt32(txtId.Text);
            contaPoupanca.Descricao = txtDescricao.Text;
            contaPoupanca.Saldo = Convert.ToDecimal(txtSaldo.Text);
            contaPoupanca.QtdTempo = Convert.ToInt32(txtQtdTempo.Text);
            contaPoupanca.TaxaJuros = Convert.ToDouble(txtTaxaJuros.Text);

            ContaPoupancaService.AddContaPoupanca(contaPoupanca);

            LoadGrid();
        }

        private void LoadGrid()
        {
            dgvContaPoupanca.DataSource = ContaPoupancaService.GetContasPoupanca();
        }

    }
}
