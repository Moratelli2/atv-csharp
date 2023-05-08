using AtvFormsComp.db;
using AtvFormsComp.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace AtvFormsComp.repository
{
    class ClientRepository
    {

        public static Cliente Insert(Cliente cliente)
        {
            SqlConnection connection = SQLServer.GetConnection();

            string strInsert = "INSERT INTO Cliente (Id, Nome, Telefone) VALUES (@Id, @Nome, @Telefone);";
            SqlCommand insert = new SqlCommand(strInsert, connection);

            insert.Parameters.Add(new SqlParameter("@Id", cliente.Id));
            insert.Parameters.Add(new SqlParameter("@Nome", cliente.Nome));
            insert.Parameters.Add(new SqlParameter("@Telefone", cliente.Telefone));

            insert.ExecuteNonQuery();

            connection.Close();

            return cliente;
        }

        public static List<Cliente> ListAll()
        {

            SqlConnection connection = SQLServer.GetConnection();

            string strSelect = @"SELECT * FROM Cliente;";

            SqlCommand select = new SqlCommand(strSelect, connection);
            SqlDataReader dr = select.ExecuteReader();

            List<Cliente> clientes = new List<Cliente>();

            while (dr.Read())
            {
                Cliente cliente = new Cliente();

                cliente.Id = Convert.ToInt32(dr["Id"]);
                cliente.Nome = dr["Nome"].ToString().TrimEnd();
                cliente.Telefone = dr["Telefone"].ToString().TrimEnd();

                clientes.Add(cliente);
            }

            select.Dispose();
            connection.Close();

            return clientes;
        }

    }
}
