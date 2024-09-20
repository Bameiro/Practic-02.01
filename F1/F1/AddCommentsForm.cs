using System;
using System.Windows.Forms;
using Lib; 

namespace F1
{
    public partial class AddCommentsForm : Form
    {
        private string id;
        private CommentManager commentManager;
        
        public AddCommentsForm()
        {
            InitializeComponent();
            this.id = ProfileData.ID;

            // Инициализация CommentManager с connectionString
            string connectionString = @"Data Source=CLG;Initial Catalog=AutoServMGY;Integrated Security=True";
            //string connectionString = @"Data Source=ADCLG1;Initial Catalog=AutoServMGY;Integrated Security=True";
            commentManager = new CommentManager(connectionString);
        }

        // Кнопка добавления комментария
        public void button1_Click(object sender, EventArgs e)
        {
            while (string.IsNullOrEmpty(commentBox.Text))
            {
                MessageBox.Show("Заполните поле комментарий", "Внимание", MessageBoxButtons.OK);
                return;
            }
            while (string.IsNullOrEmpty(requestIDBox.Text))
            {
                MessageBox.Show("Заполните поле requestID");
                return;
            }

            try
            {
                int rowsAffected = commentManager.AddComment(commentBox.Text, id, requestIDBox.Text);
                MessageBox.Show($"Добавлено {rowsAffected} строк.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении записи: {ex.Message}");
            }
        }

        private void AddCommentsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
