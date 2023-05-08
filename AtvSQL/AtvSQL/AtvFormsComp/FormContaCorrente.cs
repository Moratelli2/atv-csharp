using AtvFormsComp.model;
using AtvFormsComp.services;
using System;
using System.Windows.Forms;

namespace AtvFormsComp
{
    public partial class FormContaCorrente : Form
    {
        public FormContaCorrente()
        {
            InitializeComponent();
        }

        private void btnSaveContaCorrente_Click(object sender, EventArgs e)
        {
            model.ContaCorrente contaCorrente = new model.ContaCorrente();

            contaCorrente.Id = Convert.ToInt32(txtId.Text);
            contaCorrente.Descricao = txtDescricao.Text;
            contaCorrente.Saldo = Convert.ToDecimal(txtSaldo.Text);
            contaCorrente.Limite = Convert.ToDecimal(txtLimite.Text);

            ContaCorrenteService.Insert(contaCorrente);

            LoadGrid();
        }

        private void LoadGrid()
        {
            dgvContaCorrente.DataSource = ContaCorrenteService.ListAll();
        }

        private void FormContaCorrente_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
    }
}
