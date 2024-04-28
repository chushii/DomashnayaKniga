using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace DomashnayaKniga
{
    public partial class WinMain : Form
    {
        public WinMain(string name)
        {
            InitializeComponent();
            labelWelcome.Text = $"Добро пожаловать, {name}!";
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Hide();
            WinSignIn signin = new WinSignIn();
            signin.Closed += (s, args) => Close();
            signin.Show();
        }

        private void buttonPassHash_Click(object sender, EventArgs e)
        {
            if (textBoxPass1.Text == "") return;
            textBoxHash2.Text = Encryptor.Hasher(textBoxPass1.Text, null);
        }

        private void buttonHashPass_Click(object sender, EventArgs e)
        {
            if (textBoxPass1.Text == "" || textBoxHash2.Text == "") return;
            byte[] old_salt = Encryptor.Extract(textBoxHash2.Text);
            textBoxPass3.Text = Encryptor.Hasher(textBoxPass1.Text, old_salt);
        }
    }
}
