using System;
using Microsoft.Data.SqlClient; 

namespace GestorAlumnosForm
{
    public class DatabaseManager
    {
        private readonly string _connectionString;

        public DatabaseManager()
        {
            
            _connectionString = @"Data Source=BENY-LAPTOP\SQLEXPRESS;Initial Catalog=UMG;Integrated Security=True;TrustServerCertificate=True";
        }

        public SqlConnection GetConnection()
        {
            var connection = new SqlConnection(_connectionString);
            return connection;
        }

        public void AbrirConexion()
        {
            SqlConnection connection = GetConnection();
            if (connection.State != System.Data.ConnectionState.Open)
            {
                try
                {
                    connection.Open();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al abrir la conexión: {ex.Message}");
                    throw; 
                }
            }
        }

        public void CerrarConexion()
        {
            SqlConnection connection = GetConnection();
            if (connection.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    connection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al cerrar la conexión: {ex.Message}");
                    throw; 
                }
            }
        }

        public SqlConnection ObtenerConexion()
        {
            return GetConnection();
        }

        public bool TestConnection()
        {
            try
            {
                using var connection = GetConnection();
                connection.Open();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error de conexión: {ex.Message}");
                return false;
            }
        }
    }

}