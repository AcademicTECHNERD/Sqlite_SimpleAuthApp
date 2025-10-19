using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulated_LoginRegi
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
            DatabaseHelper.Initialize();
            // 如果数据库中还没有 sa 用户，就添加一个
            if (!DatabaseHelper.IsUsernameExist("sa"))
            {
                DatabaseHelper.AddUser("sa", "123", "男", "2327676879@gmail.com");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
