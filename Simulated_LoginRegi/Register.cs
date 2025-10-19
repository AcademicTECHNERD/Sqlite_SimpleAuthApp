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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            // 1️⃣ 获取用户输入
            string username = register_account.Text.Trim();
            string password = register_password.Text.Trim();
            string email = register_email.Text.Trim();
            string sex = "";
            if (checkBox_man.Checked)
                sex = "男";
            else if (checkBox_woman.Checked)
                sex = "女";
            else
                sex = "保密";  // 或提示必须选择

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("用户名和密码不能为空！");
                return;
            }

            if (DatabaseHelper.IsUsernameExist(username))
            {
                MessageBox.Show("用户名已存在！");
                return;
            }

            DatabaseHelper.AddUser(username, password, sex, email);
            MessageBox.Show("注册成功！");
            login.Show();
            this.Hide();
        }

        private void checkBox_man_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_man.Checked)
            {
                checkBox_woman.Checked = false;
            }
        }

        private void checkBox_woman_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_woman.Checked)
            {
                checkBox_man.Checked = false;
            }
        }
    }
}
