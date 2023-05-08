using AtvFormsComp.db;
using AtvFormsComp.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace AtvFormsComp.repository
{
    class ContaCorrenteRepository
    {

        public static model.ContaCorrente Insert(model.ContaCorrente contaCorrente)
        {

            Conta conta = ContaRepository.Insert(contaCorrente);

            SqlConnection connection = SQLServer.GetConnection();

            string strInsert = "INSERT INTO ContaCorrente (Id, ContaId, Limite) VALUES (@Id, @ContaId, @Limite);";

            SqlCommand insert = new SqlCommand(strInsert, connection);

            insert.Parameters.Add(new SqlParameter("@Id", contaCorrente.Id));
            insert.Parameters.Add(new SqlParameter("@ContaId", conta.Id));
            insert.Parameters.Add(new SqlParameter("@Limite", contaCorrente.Limite));

            insert.ExecuteNonQuery();

            insert.Dispose();
            connection.Close();

            return contaCorrente;
        }

        public static List<model.ContaCorrente> ListAll()
        {

            SqlConnection connection = SQLServer.GetConnection();

            string strSelect = @"SELECT cc.Id,
                                        cc.Limite,
                                        c.Descricao,
                                        c.Saldo
                                 FROM ContaCorrente cc
                                 INNER JOIN Conta c ON c.Id = cc.ContaId;";

            SqlCommand select = new SqlCommand(strSelect, connection);
            SqlDataReader dr = select.ExecuteReader();

            List<model.ContaCorrente> contas = new List<model.ContaCorrente>();

            // faz  leitura de todas as contas e retorna
            while (dr.Read())
            {
                model.ContaCorrente contaCorrente = new model.ContaCorrente();

                contaCorrente.Id = Convert.ToInt32(dr["Id"]);
                contaCorrente.Descricao = dr["Descricao"].ToString().TrimEnd();
                contaCorrente.Saldo = Convert.ToDecimal(dr["Saldo"]);
                contaCorrente.Limite = Convert.ToDecimal(dr["Limite"]);

                contas.Add(contaCorrente);
            }

            select.Dispose();
            connection.Close();

            return contas;
        }

    }
}
