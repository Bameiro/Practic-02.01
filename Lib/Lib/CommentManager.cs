using System;
using System.Data.SqlClient;

namespace Lib
{

    public class CommentManager
        {
            private string _connectionString;
            public static string Inmessage { get; set; }
            public static string RequestID { get; set; }
            public static string MasterID { get; set; }
            public CommentManager(string connectionString)
            {
                _connectionString = connectionString;
            }

            public int AddComment(string inmessage, string masterID, string requestID)
            {
            Inmessage = inmessage;
            RequestID = requestID;
            MasterID = masterID;
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    string query = "INSERT INTO comment (inmessage, staffID, requestID) VALUES (@inmessage, @masterID, @requestID)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@inmessage", inmessage);
                        command.Parameters.AddWithValue("@staffID", masterID);
                        command.Parameters.AddWithValue("@requestID", requestID);

                        connection.Open();

                        try
                        {
                            return command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            throw new Exception($"Ошибка при добавлении комментария: {ex.Message}");
                        }
                    }
                }
            }
        }

}
