using System.Data;
using System.Data.SqlClient;

namespace Lib
{

    public class RequestManager
    {
        public string RequestText { get; set; }
        public int RequestID { get; set; }
        public int SaffID { get; set; }

        public void CreateRequest(string requestText, int staffID)
        {
            RequestText = requestText;
            SaffID = staffID;
        }
    }
    public class DatabaseManager
    {

        private string connectionString;

        public DatabaseManager(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void ExecuteNonQuery(string query, SqlParameter[] parameters)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddRange(parameters);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public SqlDataReader ExecuteReader(string query, SqlParameter[] parameters)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddRange(parameters);
            connection.Open();
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }
    }

}
