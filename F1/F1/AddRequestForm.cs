using Lib;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace F1
{
    public partial class AddRequestForm : Form
    {
        private DatabaseManager databaseManager;
        private int modelID;
        int reqestID = 5;

        public AddRequestForm()
        {
            InitializeComponent();
            string connectionString = @"Data Source=CLG;Initial Catalog=AutoServMGY;Integrated Security=True";
            //string connectionString = @"Data Source=ADCLG1;Initial Catalog=AutoServMGY;Integrated Security=True";

            databaseManager = new DatabaseManager(connectionString);
            modelList.SelectedIndexChanged += ModelID_changed;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(problemBox.Text))
            {
                MessageBox.Show("Запоните поле описание проблемы!");
                return;
            }
            if (string.IsNullOrEmpty(modelList.Text))
            {
                MessageBox.Show("Выберите модель");
                return;
            }

            string query = "INSERT INTO inputDataRequests (requestID, startDate,carModelID, problemDescryption, clientID, requestStatus) VALUES (@requestID, @startDate, @carModelID, @problemDescryption, @clientID, @requestStatus)";
            SqlParameter[] parameters = {
                new SqlParameter("@requestID", reqestID++),
                new SqlParameter("@startDate", DateTime.Now),
                new SqlParameter("@carModelID", modelID),
                new SqlParameter("@problemDescryption", problemBox.Text),
                new SqlParameter("@clientID", int.Parse(ProfileData.ID)),
                new SqlParameter("@requestStatus", "New Request")
            };

            try
            {
                databaseManager.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Запись добавлена.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении записи: {ex.Message}");
            }
        }

        private void AddRequestForm_Load(object sender, EventArgs e)
        {
            string query = "SELECT carModel FROM carModelTypes";
            try
            {
                using (SqlDataReader reader = databaseManager.ExecuteReader(query, new SqlParameter[0]))
                {
                    while (reader.Read())
                    {
                        modelList.Items.Add(reader["carModel"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void ModelID_changed(object sender, EventArgs e)
        {
            string modelName = modelList.SelectedItem.ToString();
            string query = "SELECT carModelID FROM carModelTypes WHERE carModel = @carModel";
            SqlParameter[] parameters = {
                new SqlParameter("@carModel", modelName)                
            };

            try
            {
                using (SqlDataReader reader = databaseManager.ExecuteReader(query, parameters))
                {
                    if (reader.Read())
                    {
                        modelID = Convert.ToInt32(reader["carModelID"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }
    }
}
