using AtvFormsComp.db;
using AtvFormsComp.model;
using System.Data.SqlClient;

namespace AtvFormsComp.repository
{
    class ContaRepository
    {

        public static Conta Insert(Conta conta)
        {

            SqlConnection connection = SQLServer.GetConnection();

            string strInsert = "INSERT INTO Conta (Id, Descricao, Saldo) VALUES (@Id, @Descricao, @Saldo);";

            SqlCommand insert = new SqlCommand(strInsert, connection);

            insert.Parameters.Add(new SqlParameter("@Id", conta.Id));
            insert.Parameters.Add(new SqlParameter("@Descricao", conta.Descricao));
            insert.Parameters.Add(new SqlParameter("@Saldo", conta.Saldo));

            insert.ExecuteNonQuery();

            insert.Dispose();
            connection.Close();

            return conta;
        }

    }
}
