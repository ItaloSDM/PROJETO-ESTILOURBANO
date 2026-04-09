using System;
using System.Data;
using System.Data.SqlClient;

namespace EstiloUrbano.Infrastructure.Data
{
    public class DbConnection
    {
        // Endereço atualizado conforme seu último print (LocalDB)
        private static string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=EstiloUrbanoDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                // Abre a conexão antes de retornar para o Repository
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                // Caso dê erro de conexão (ex: SQL parado), avisa no console
                Console.WriteLine("Erro ao conectar ao banco: " + ex.Message);
            }

            return connection;
        }
    }
}