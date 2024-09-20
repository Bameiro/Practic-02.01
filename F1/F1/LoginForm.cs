using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using Lib;

namespace F1
{
    public partial class LoginForm : Form
    {
        private Lib.AuthenticationManager authManager;
        private string captchaText;
        private int bruh = 0;
        private bool captchaVerified = true;
        private int cooldownTime = 180;

        public LoginForm()
        {
            InitializeComponent();
            string connectionString = @"Data Source=CLG;Initial Catalog=AutoServMGY;Integrated Security=True";
            //string connectionString = @"Data Source=ADCLG1;Initial Catalog=AutoServMGY;Integrated Security=True";

            authManager = new Lib.AuthenticationManager(connectionString);

            timer1.Interval = 1000;
            timer1.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (bruh >= 2)
            {
                cooldownTime--;
                label5.Text = $"Wait: {cooldownTime / 60} : {cooldownTime % 60}";
                if (cooldownTime <= 0)
                {
                    timer1.Stop();
                    ResetLoginControls();
                }
            }
        }

        private void ResetLoginControls()
        {
            loginBox.Enabled = true;
            passBox.Enabled = true;
            pictureBox1.Visible = true;
            textBox1.Enabled = true;
            loginBtn.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
            label5.Text = " ";
        }

        private Bitmap CreateCaptchaImage(int width, int height)
        {
            Random rnd = new Random();
            Bitmap result = new Bitmap(width, height);
            int xPos = rnd.Next(0, width - 50);
            int yPos = rnd.Next(15, height - 15);
            Brush[] colors = { Brushes.Black, Brushes.Red, Brushes.RoyalBlue, Brushes.Green };
            Graphics g = Graphics.FromImage(result);
            g.Clear(Color.Gray);

            captchaText = string.Empty;
            string characters = "1234567890QWERTYUIOPASDFGHJKLZXCVBNM";
            for (int i = 0; i < 4; ++i)
                captchaText += characters[rnd.Next(characters.Length)];

            g.DrawString(captchaText, new Font("Arial", 15), colors[rnd.Next(colors.Length)], new PointF(xPos, yPos));
            g.DrawLine(Pens.Black, new Point(0, 0), new Point(width - 1, height - 1));
            g.DrawLine(Pens.Black, new Point(0, height - 1), new Point(width - 1, 0));
            for (int i = 0; i < width; ++i)
                for (int j = 0; j < height; ++j)
                    if (rnd.Next() % 20 == 0)
                        result.SetPixel(i, j, Color.White);

            return result;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string login = loginBox.Text;
            string password = passBox.Text;

            if (string.IsNullOrEmpty(login))
            {
                MessageBox.Show("Заполните поле Логин");
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Заполните поле Пароль");
                return;
            }

            Lib.User user = authManager.AuthenticateUser(login, password);

            if (user != null && captchaVerified)
            {
                ProfileData.Fio = user.Fio;
                ProfileData.Phone = user.Phone;
                ProfileData.Role = user.Type;
                ProfileData.ID = user.Id;

                try
                {
                    ProfileForm profileForm = new ProfileForm();
                    profileForm.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при открытии формы профиля: {ex.Message}");
                }
            }
            else
            {
                bruh++;
                HandleFailedLogin();
            }

            LogLoginAttempt(login, password);
        }

        private void HandleFailedLogin()
        {
            if (bruh > 0)
            {
                pictureBox1.Visible = true;
                textBox1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                captchaVerified = false;
                label4.Text = "Вы Робот?";
                pictureBox1.Image = CreateCaptchaImage(pictureBox1.Width, pictureBox1.Height);

                if (bruh >= 2)
                {
                    loginBox.Enabled = false;
                    passBox.Enabled = false;
                    loginBtn.Enabled = false;
                    pictureBox1.Visible = false;
                    textBox1.Enabled = false;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                }

                if (bruh >= 3)
                {
                    this.Close();
                }
            }
        }

        private void LogLoginAttempt(string login, string password)
        {
            using (SqlConnection connection = new SqlConnection(authManager.ConnectionString))
            {
                DateTime dateTime = DateTime.Now;
                string query = "INSERT INTO History (Date, login, password, autorisation) VALUES (@Date, @login, @password, @autorisation)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {   
                    command.Parameters.AddWithValue("@Date", dateTime);
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@password", password);                    
                    command.Parameters.AddWithValue("@autorisation", captchaVerified);

                    connection.Open();
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при добавлении записи: {ex.Message}");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            passBox.PasswordChar = passBox.PasswordChar == '*' ? '\0' : '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = CreateCaptchaImage(pictureBox1.Width, pictureBox1.Height);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == captchaText)
            {
                textBox1.BackColor = Color.OliveDrab;
                captchaVerified = true;
                label4.Text = " ";
            }
            else
            {
                textBox1.BackColor = Color.RosyBrown;
                captchaVerified = false;
                pictureBox1.Image = CreateCaptchaImage(pictureBox1.Width, pictureBox1.Height);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
