using MySql.Data.MySqlClient;

namespace Lexems
{
    class DB
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=123;database=Lexems");

        public void ConnectDB()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void DisconnectDB()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public MySqlConnection getDBConnection()
        {
            return connection;
        }
    }
}
