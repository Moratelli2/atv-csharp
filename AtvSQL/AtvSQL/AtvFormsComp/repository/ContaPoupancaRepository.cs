using AtvFormsComp.db;
using AtvFormsComp.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace AtvFormsComp.repository
{
    class ContaPoupancaRepository
    {
        public static ContaPoupanca Insert(ContaPoupanca contaPoupanca)
        {

            Conta c = ContaRepository.Insert(contaPoupanca);

            SqlConnection connection = SQLServer.GetConnection();

            string strInsert = "INSERT INTO ContaPoupanca (Id, ContaId, QtdTempo, TaxaJuros) VALUES (@Id, @ContaId, @QtdTempo, @TaxaJuros);";

            SqlCommand insert = new SqlCommand(strInsert, connection);

            insert.Parameters.Add(new SqlParameter("@Id", contaPoupanca.Id));
            insert.Parameters.Add(new SqlParameter("@ContaId", c.Id));
            insert.Parameters.Add(new SqlParameter("@QtdTempo", contaPoupanca.QtdTempo));
            insert.Parameters.Add(new SqlParameter("@TaxaJuros", contaPoupanca.TaxaJuros));

            insert.ExecuteNonQuery();

            insert.Dispose();
            connection.Close();

            return contaPoupanca;
        }

        public static List<ContaPoupanca> ListAll()
        {

            SqlConnection connection = SQLServer.GetConnection();

            string strSelect = @"SELECT cp.Id,
                                        cp.QtdTempo,
                                        cp.TaxaJuros,
                                        c.Descricao,
                                        c.Saldo
                                 FROM ContaPoupanca cp
                                 INNER JOIN Conta c ON c.Id = cp.ContaId;";

            SqlCommand select = new SqlCommand(strSelect, connection);
            SqlDataReader dr = select.ExecuteReader();

            List<ContaPoupanca> contaList = new List<ContaPoupanca>();

            while (dr.Read())
            {
                ContaPoupanca cp = new ContaPoupanca();

                cp.Id = Convert.ToInt32(dr["Id"]);
                cp.Descricao = dr["Descricao"].ToString().TrimEnd();
                cp.Saldo = Convert.ToDecimal(dr["Saldo"]);
                cp.QtdTempo = Convert.ToInt32(dr["QtdTempo"]);
                cp.TaxaJuros = Convert.ToDouble(dr["TaxaJuros"]);

                contaList.Add(cp);
            }

            select.Dispose();
            connection.Close();

            return contaList;
        }
    }
}
