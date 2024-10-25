using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace FazendaUrbana.Entities.Objetos
{
    internal class ConnectionDB
    {

        private const string connectionString = "Server=localhost;Database=dbFazendaPIM;Trusted_Connection=True;";

        // Método para abrir e retornar a conexão
        public static SqlConnection OpenConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                Console.WriteLine("Conexão com o banco de dados estabelecida com sucesso.");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erro ao conectar-se ao banco de dados: " + ex.Message);
            }
            return connection;
        }

        // Método para fechar a conexão
        public static void CloseConnection(SqlConnection connection)
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                Console.WriteLine("Conexão com o banco de dados fechada.");
            }
        }

    }
}
