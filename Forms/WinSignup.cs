using DomashnayaKniga.Tables;
using Microsoft.EntityFrameworkCore;
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

namespace DomashnayaKniga
{
    public partial class WinSignUp : Form
    {
        public WinSignUp()
        {
            InitializeComponent();
        }

        private void gotoLogin_Click(object sender, EventArgs e)
        {
            Hide();
            WinSignIn signin = new WinSignIn();
            signin.Closed += (s, args) => Close();
            signin.Show();
        }

        private void buttonSignup_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "" || textBoxPassword.Text == "" || textBoxPassword2.Text == "" || textBoxFirstName.Text == "" || textBoxLastName.Text == "")
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            else if (textBoxPassword.Text != textBoxPassword2.Text)
            {
                MessageBox.Show("Пароли не совпадают", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); textBoxPassword2.Text = ""; return;
            }
            var options = new DbContextOptionsBuilder<Context>().UseSqlite("Filename=../../../Database.db").Options;
            using var db = new Context(options);
            db.Database.EnsureCreated();
            if (db.Users.FromSql($"SELECT * FROM Users WHERE Login = {textBoxLogin.Text}").Any())
            {
                MessageBox.Show("Пользователь с таким логином уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var newUser = new User
                    { Login = textBoxLogin.Text, Password = textBoxPassword.Text, FirstName = textBoxFirstName.Text, LastName = textBoxLastName.Text };
                db.Users.Add(newUser); db.SaveChanges();
                MessageBox.Show("Новый пользователь добавлен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Hide(); WinSignIn signin = new WinSignIn();
                signin.Closed += (s, args) => Close(); signin.Show();
            }
            
        }
    }
}
