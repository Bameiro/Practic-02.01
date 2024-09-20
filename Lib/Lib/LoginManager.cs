namespace Lib
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data.SqlClient;

    public class AuthenticationManager
    {
        public string ConnectionString { get; private set; }
        public static string Pass { get; set; }
        public static bool UserFound { get; set; }

        public AuthenticationManager(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public User AuthenticateUser(string login, string password)
        {
            string[] IDs = new string[0];
            string[] fios = new string[0];
            string[] phones = new string[0];
            string[] logins = new string[0];
            string[] passs = new string[0];            
            string[] types = new string[0];

            string[] IDc = new string[0];
            string[] fioc = new string[0];
            string[] phonec = new string[0];
            string[] loginc = new string[0];
            string[] passc = new string[0];                        

            // Проверка по таблице Сотрудники
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string sql = "select * from staffID";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<string> IDlist = new List<string>();
                        List<string> fioList = new List<string>();
                        List<string> phoneList = new List<string>();
                        List<string> loginList = new List<string>();
                        List<string> passwordList = new List<string>();                                                
                        List<string> typeList = new List<string>();

                        while (reader.Read())
                        {
                            IDlist.Add(reader["staffID"].ToString());
                            fioList.Add(reader["sfio"].ToString());
                            phoneList.Add(reader["sphone"].ToString());
                            loginList.Add(reader["slogin"].ToString());
                            passwordList.Add(reader["spass"].ToString());                                                        
                            typeList.Add(reader["stype"].ToString());
                        }

                        IDs = IDlist.ToArray();
                        fios = fioList.ToArray();
                        phones = phoneList.ToArray();
                        logins = loginList.ToArray();
                        passs = passwordList.ToArray();
                        types = typeList.ToArray();
                    }
                }
            }

            // Проверка по таблице Клиенты
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM clientID";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<string> IDlist = new List<string>();
                        List<string> fioList = new List<string>();
                        List<string> phoneList = new List<string>();
                        List<string> loginList = new List<string>();
                        List<string> passwordList = new List<string>();

                        while (reader.Read())
                        {
                            IDlist.Add(reader["clientID"].ToString());
                            fioList.Add(reader["cfio"].ToString());
                            phoneList.Add(reader["cphone"].ToString());
                            loginList.Add(reader["clogin"].ToString());
                            passwordList.Add(reader["cpass"].ToString());
                        }

                        IDc = IDlist.ToArray();
                        fioc = fioList.ToArray();
                        phonec = phoneList.ToArray();
                        loginc = loginList.ToArray();
                        passc = passwordList.ToArray();
                    }
                }
            }

            // Проверка сотрудников
            for (int i = 0; i < logins.Length; i++)
            {
                if (logins[i] == login && passs[i] == password)
                {

                    return new User
                    {
                        Id = IDs[i],
                        Login = login,
                        Fio = fios[i],
                        Phone = phones[i],
                        Type = types[i],
                    };
                    Pass = passs[i].ToString();
                }
            }
            
            // Проверка клиентов
            for (int i = 0; i < loginc.Length; i++)
            {
                if (loginc[i] == login && passc[i] == password)
                {
                    return new User
                    {
                        Id = IDc[i],
                        Login = login,
                        Fio = fioc[i],
                        Phone = phonec[i],
                        Type = "Клиент"
                    };
                }
            }

            return null;
        }
    }

    public class User
    {
        public string Id { get; set; }
        public string Login { get; set; }
        public string Fio { get; set; }
        public string Phone { get; set; }
        public string Type { get;set; }
    }


}
