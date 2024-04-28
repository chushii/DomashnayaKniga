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
            if (InvalidTextBoxes(textBoxLogin.Text, textBoxPassword.Text, textBoxPassword2.Text, textBoxFirstName.Text, textBoxLastName.Text)) return;
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
                    { Login = textBoxLogin.Text, Password = Encryptor.Hasher(textBoxPassword.Text, null), FirstName = textBoxFirstName.Text, LastName = textBoxLastName.Text };
                db.Users.Add(newUser); db.SaveChanges();
                MessageBox.Show("Новый пользователь добавлен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Hide(); WinSignIn signin = new WinSignIn();
                signin.Closed += (s, args) => Close(); signin.Show();
            }
        }

        public static bool InvalidTextBoxes(string login, string pass1, string pass2, string fname, string lname)
        {
            if (login == "" || pass1 == "" || pass2 == "" || fname == "" || lname == "")
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); return true;
            }
            else if (pass1 != pass2)
            {
                MessageBox.Show("Пароли не совпадают", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); return true;
            }
            else return false;
        }
    }
}
