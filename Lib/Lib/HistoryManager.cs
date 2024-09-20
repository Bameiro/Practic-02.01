using System;
using System.Data;
using System.Data.SqlClient;

namespace Lib
{
        public class HistoryLogManager
        {
            private readonly string _connectionString;

            public HistoryLogManager(string connectionString)
            {
                _connectionString = connectionString;
            }

            // Заполнение DataSet данными из таблицы ИсторияВхода
            public DataTable GetAllLoginHistory()
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "SELECT * FROM History";
                        SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet, "History");
                        return dataSet.Tables["History"];
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Ошибка при загрузке данных: " + ex.Message);
                    }
                }
            }

        // Поиск данных в таблице ИсторияВхода по указанному тексту
        public DataTable SearchLoginHistory(string searchText)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    string searchTextLogin;
                    switch (searchText.ToLower())
                    {
                        case "true":
                            searchTextLogin = "1";
                            break;
                        case "false":
                            searchTextLogin = "0";
                            break;
                        default:
                            searchTextLogin = searchText;
                            break;
                    }

                    string query = @"
                        SELECT * FROM History
                        WHERE Date LIKE '%' + @SearchText + '%' OR
                              login LIKE '%' + @SearchText + '%' OR
                              password LIKE '%' + @SearchText + '%' OR
                              autorisation LIKE '%' + @SearchTextLogin + '%'";
                              

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@SearchText", searchText);
                    command.Parameters.AddWithValue("@SearchTextLogin", searchTextLogin);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet, "History");
                    return dataSet.Tables["History"];
                }
                catch (Exception ex)
                {
                    throw new Exception("Ошибка при поиске данных: " + ex.Message);
                }
            }
        }
    }
    

}
