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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string account = login_account.Text.Trim();
            string password = login_password.Text.Trim();

            // 检查空值
            if (string.IsNullOrEmpty(account) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("用户名或密码不能为空！");
                return;
            }

            // 1️⃣ 检查用户名是否存在
            if (!DatabaseHelper.IsUsernameExist(account))
            {
                MessageBox.Show("您输入的账户不存在！");
                return;
            }

            // 2️⃣ 验证用户名和密码是否匹配
            if (DatabaseHelper.CheckUser(account, password))
            {
                MessageBox.Show("登录成功！");

                // 打开主界面
                Main main = new Main();
                main.Show();
                this.Hide(); // 隐藏当前登录窗体
            }
            else
            {
                MessageBox.Show("账号或密码错误，请重新输入！");
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }
    }
}
