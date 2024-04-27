using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DomashnayaKniga
{
    public partial class WinLogin : Form
    {
        public WinLogin()
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
            WinSignup signup = new WinSignup();
            signup.Closed += (s, args) => Close();
            signup.Show();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Hide();
            string fName = "неизвестный";
            string lName = "пользователь";
            WinMain main = new WinMain(fName, lName);
            main.Closed += (s, args) => Close();
            main.Show();
        }
    }
}
