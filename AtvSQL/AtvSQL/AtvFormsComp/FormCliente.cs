using AtvFormsComp.db;
using AtvFormsComp.model;
using AtvFormsComp.services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace AtvFormsComp
{
    public partial class FormClient : Form
    {

        public FormClient()
        {
            InitializeComponent();
        }

        private void FormClient_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void btnSaveClient_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            cliente.Id = Convert.ToInt32(txtId.Text);
            cliente.Nome = txtNome.Text;
            cliente.Telefone = txtTelefone.Text;

            ClientService.Insert(cliente);

            dgvClients.DataSource = ClientService.ListAll();
        }

        private void LoadGrid()
        {
            dgvClients.DataSource = ClientService.ListAll();
        }

    }
}
