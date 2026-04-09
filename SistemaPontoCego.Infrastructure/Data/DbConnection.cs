using System;
using System.Data;
using System.Data.SqlClient;

namespace EstiloUrbano.Infrastructure.Data
{
    public class DbConnection
    {
        // Esse é o "endereço" do seu banco que vimos nas fotos anteriores
        private static string connectionString = @"Server=.\SQLEXPRESS;Database=EstiloUrbanoDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            // Se a conexão estiver fechada, ele abre automaticamente
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            return connection;
        }
    }
}