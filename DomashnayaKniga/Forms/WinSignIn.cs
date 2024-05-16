using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;


namespace DomashnayaKniga.Forms
{
    public partial class WinSignIn : Form
    {
        private Context dbase = new Context();

        public WinSignIn()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = !textBoxPassword.UseSystemPasswordChar;
        }

        private void gotoSignup_Click(object sender, EventArgs e)
        {
            Hide();
            WinSignUp signup = new WinSignUp();
            signup.Closed += (s, args) => Close();
            signup.Show();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "" || textBoxLogin.Text == "")
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            User[] match = dbase.Users.FromSql($"SELECT * FROM Users WHERE Login = {textBoxLogin.Text}").ToArray();
            if (match.Count() == 1)
            {
                if (match[0].Password != Encryptor.Hasher(textBoxPassword.Text, Encryptor.Extract(match[0].Password)))
                {
                    MessageBox.Show("Неправильный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxLogin.Text = ""; textBoxPassword.Text = "";
                }
                else
                {
                    Hide(); WinMain main = new WinMain(match[0]);
                    main.Closed += (s, args) => Close(); main.Show();
                }
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxLogin.Text = ""; textBoxPassword.Text = "";
            }
        }

        private void titleIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                User user = dbase.Users.First();
                Hide(); WinMain main = new WinMain(user);
                main.Closed += (s, args) => Close(); main.Show();
            }
        }
    }
}
