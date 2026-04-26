using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace PhoneDirectoryApp
{
    /// <summary>
    /// Представляет класс для управления подключением к базе данных.
    /// Реализует паттерн Singleton для обеспечения одного экземпляра подключения.
    /// </summary>
    public class DatabaseConnection
    {
        private static DatabaseConnection _instance;
        private SqlConnection _connection;

        /// <summary>
        /// Строка подключения, полученная из конфигурационного файла.
        /// </summary>
        private string _connectionString =
        ConfigurationManager.ConnectionStrings["DirectoryConnection"]
        .ConnectionString;

        /// <summary>
        /// Инициализирует подключение к базе данных.
        /// </summary>
        private DatabaseConnection()
        {
            _connection = new SqlConnection(_connectionString);
        }

        /// <summary>
        /// Возвращает единственный экземпляр класса DatabaseConnection. Если экземпляр ещё не создан, создаёт его.
        /// </summary>
        /// <returns>Экземпляр DatabaseConnection.</returns>
        public static DatabaseConnection GetInstance()
        {
            if (_instance == null)
            {
                _instance = new DatabaseConnection();
            }
            return _instance;
        }

        /// <summary>
        /// Возвращает активное подключение к базе данных. Если подключение закрыто, оно будет открыто.
        /// </summary>
        /// <returns></returns>
        public SqlConnection GetConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Closed)
            {
                _connection.Open();
            }
            return _connection;
        }

        /// <summary>
        /// Закрывает подключение к базе данных, если оно открыто.
        /// </summary>
        public void CloseConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Open)
            {
                _connection.Close();
            }
        }

        public bool TestConnection()
        {
            try
            {
                if (_connection.State != ConnectionState.Open)
                    _connection.Open();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка подключения: " + ex.Message);
                return false;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
        }
    }
}
