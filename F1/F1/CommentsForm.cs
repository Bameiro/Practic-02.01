using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F1
{
    public partial class CommentsForm : Form
    {
        private SqlConnection connection;
        private string connectionString;

        public CommentsForm()
        {
            InitializeComponent();

            connectionString = @"Data Source=CLG;Initial Catalog=AutoServMGY;Integrated Security=True";
            //connectionString = @"Data Source=ADCLG1;Initial Catalog=AutoServMGY;Integrated Security=True";

            connection = new SqlConnection(connectionString);

            dataGridView1.CellBeginEdit += DataGridView1_CellBeginEdit;//Событие начала редактирования строк через datagridview
            dataGridView1.CellEndEdit += DataGridView1_CellEndEdit;//Событие окончания редактирования строк через datagridview

            searchBox.TextChanged += SearchAllColumns;
        }
        //метод который динамично обновляет количество выведенных записей
        private void update_label()
        {
            int count = dataGridView1.RowCount;
            label1.Text = $"Requests: {count}";
        }

        // Обработчик события при начале редактирования ячейки
        private void DataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
        }

        // Обработчик события при окончании редактирования ячейки
        private void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Проверка, изменилось ли значение
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag)
                {
                    // Получить ID_запроса из текущей строки
                    int requestId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["commentID"].Value);

                    // Получить имя столбца, который был изменен
                    string columnName = dataGridView1.Columns[e.ColumnIndex].Name;

                    // Получить новое значение из ячейки
                    object newValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                    // Обновить значение в базе данных
                    UpdateRequest(requestId, columnName, newValue);

                    FillDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        // Метод для обновления данных в базе данных
        private void UpdateRequest(int requestId, string columnName, object newValue)
        {
            try
            {
                connection.Open();

                string query = $"UPDATE comments SET {columnName} = @NewValue WHERE commentID = @RequestId";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@RequestId", requestId);
                command.Parameters.AddWithValue("@NewValue", newValue);

                command.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        //Кнопка которая возвращает на Главную форму
        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
        }
        //Загрузка формы
        private void CommentsForm_Load(object sender, EventArgs e)
        {
            FillDataGridView();
            update_label();
        }
        //Заполнение элемента datagridview записями
        private void FillDataGridView()
        {
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand("select * from comment", connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataSet dataSet = new DataSet();

                adapter.Fill(dataSet, "comment");

                dataGridView1.DataSource = dataSet.Tables["comment"];

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddCommentsForm addForm = new AddCommentsForm();
            addForm.ShowDialog();
        }
        //Кнопка для удаления нового комментария
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены?", "Подтверждение", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Выберите строку для удаления", "Ошибка");
                    return;
                }

                int commentID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["commentID"].Value);

                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("DELETE FROM comment WHERE commentID = @id", connection);
                    command.Parameters.AddWithValue("@id", commentID);
                    command.ExecuteNonQuery();
                    connection.Close();

                    FillDataGridView();
                    dataGridView1.Refresh();
                    update_label();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка удаления: {ex.Message}", "Ошибка");
                }
            }
            else
            {
                MessageBox.Show("Ок");
            }
        }

        //функция поиска по всем столбцам таблицы
        private void SearchAllColumns(object sender, EventArgs e)
        {
            string searchText = searchBox.Text;

                try
                {
                    connection.Open();

                    string query = @"Select c.commentID, c.inmessage, s.sfio AS ФИО, c.requestID From comment c JOIN staffID s ON c.staffID = s.staffID Where
                                  commentID LIKE '%' + @SearchText + '%' OR
                                  inmessage LIKE '%' + SearchText + '%' OR
                                  sfio LIKE '%' + SearchText + '%' OR
                                  requestID LIKE '%' + SearchText + '%'";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@SearchText", searchText);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    DataSet dataSet = new DataSet();

                    adapter.Fill(dataSet, "comment");

                    dataGridView1.DataSource = dataSet.Tables["comment"];

                    connection.Close();
                    update_label();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка");
                }

        }
        //кнопка обновляющая таблицу и количество записей
        private void updateBtn_Click(object sender, EventArgs e)
        {
            FillDataGridView();
            update_label();
        }
    }
}
