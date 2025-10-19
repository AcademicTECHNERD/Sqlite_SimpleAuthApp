namespace Simulated_LoginRegi
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox_man = new System.Windows.Forms.CheckBox();
            this.checkBox_woman = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.register_account = new System.Windows.Forms.TextBox();
            this.register_password = new System.Windows.Forms.TextBox();
            this.register_email = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文新魏", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(347, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "注册";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "账户名称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "密码";
            // 
            // checkBox_man
            // 
            this.checkBox_man.AutoSize = true;
            this.checkBox_man.Location = new System.Drawing.Point(311, 239);
            this.checkBox_man.Name = "checkBox_man";
            this.checkBox_man.Size = new System.Drawing.Size(44, 19);
            this.checkBox_man.TabIndex = 2;
            this.checkBox_man.Text = "男";
            this.checkBox_man.UseVisualStyleBackColor = true;
            this.checkBox_man.CheckedChanged += new System.EventHandler(this.checkBox_man_CheckedChanged);
            // 
            // checkBox_woman
            // 
            this.checkBox_woman.AutoSize = true;
            this.checkBox_woman.Location = new System.Drawing.Point(378, 239);
            this.checkBox_woman.Name = "checkBox_woman";
            this.checkBox_woman.Size = new System.Drawing.Size(44, 19);
            this.checkBox_woman.TabIndex = 2;
            this.checkBox_woman.Text = "女";
            this.checkBox_woman.UseVisualStyleBackColor = true;
            this.checkBox_woman.CheckedChanged += new System.EventHandler(this.checkBox_woman_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "性别";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "邮箱";
            // 
            // register_account
            // 
            this.register_account.Location = new System.Drawing.Point(311, 122);
            this.register_account.Name = "register_account";
            this.register_account.Size = new System.Drawing.Size(243, 25);
            this.register_account.TabIndex = 3;
            // 
            // register_password
            // 
            this.register_password.Location = new System.Drawing.Point(311, 170);
            this.register_password.Name = "register_password";
            this.register_password.PasswordChar = '*';
            this.register_password.Size = new System.Drawing.Size(243, 25);
            this.register_password.TabIndex = 3;
            // 
            // register_email
            // 
            this.register_email.Location = new System.Drawing.Point(311, 286);
            this.register_email.Name = "register_email";
            this.register_email.Size = new System.Drawing.Size(243, 25);
            this.register_email.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(322, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 52);
            this.button1.TabIndex = 4;
            this.button1.Text = "注册";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Register_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.register_email);
            this.Controls.Add(this.register_password);
            this.Controls.Add(this.register_account);
            this.Controls.Add(this.checkBox_woman);
            this.Controls.Add(this.checkBox_man);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox_man;
        private System.Windows.Forms.CheckBox checkBox_woman;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox register_account;
        private System.Windows.Forms.TextBox register_password;
        private System.Windows.Forms.TextBox register_email;
        private System.Windows.Forms.Button button1;
    }
}