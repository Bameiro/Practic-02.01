using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib;

namespace F1
{
    public partial class ProfileForm : Form
    {
        private Profile _profile;

        public ProfileForm()
        {
            InitializeComponent();
            _profile = ProfileDataManager.LoadProfile();
        }

        // Загрузка формы
        public void ProfileForm_Load(object sender, EventArgs e)
        {
            nameBox.Text = ProfileData.Fio;
            roleBox.Text = ProfileData.Role;
        }

        // Кнопка продолжения
        public void continueBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
        }
    }
}
