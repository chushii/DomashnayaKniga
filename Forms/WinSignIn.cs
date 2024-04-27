using DomashnayaKniga.Tables;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DomashnayaKniga
{
    public partial class WinSignIn : Form
    {
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
            var options = new DbContextOptionsBuilder<Context>().UseSqlite("Filename=../../../Database.db").Options;
            using var db = new Context(options);
            db.Database.EnsureCreated();
            User[] match = db.Users.FromSql($"SELECT * FROM Users WHERE Login = {textBoxLogin.Text} AND Password = {textBoxPassword.Text}").ToArray();
            if (match.Count() == 0)
            {
                MessageBox.Show("Неправильный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxLogin.Text = ""; textBoxPassword.Text = "";
            }
            else
            {
                Hide(); WinMain main = new WinMain(match[0].ToString());
                main.Closed += (s, args) => Close(); main.Show();
            }
        }
    }
}
