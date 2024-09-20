using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F1
{
    public partial class ChechProfileForm : Form
    {
        private string fio;
        private string phone;
        private string role;
        private string ID;
        public ChechProfileForm()
        {
            InitializeComponent();
            this.fio = ProfileData.Fio;
            this.phone = ProfileData.Phone;
            this.role = ProfileData.Role;
            this.ID = ProfileData.ID;
        }

        private void ChechProfileForm_Load(object sender, EventArgs e)
        {
            nameBox.Text = fio;
            surnameBox.Text = phone;
            roleBox.Text = role;
            IDBox.Text = ID;
        }
    }
}
