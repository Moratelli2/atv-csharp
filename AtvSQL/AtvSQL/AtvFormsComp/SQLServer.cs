using System.Data.SqlClient;

namespace AtvFormsComp.db
{
    class SQLServer
    {
        private static string connectionString = @"Server=localhost;Database=MinhaDatabase;Trusted_Connection=True;AttachDbFileName=D:\bancoAula\MinhaDatabase.mdf;";

        private static SqlConnection conn = null;

        public static SqlConnection GetConnection()
        {
            if (conn == null)
                conn = new SqlConnection(connectionString);
            if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();
            return conn;
        }


    }
}
