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
using DomashnayaKniga.Tables;
using Microsoft.EntityFrameworkCore;

namespace DomashnayaKniga
{
    public partial class WinMain : Form
    {
        private User logged;
        public WinMain(User user)
        {
            InitializeComponent();
            logged = user;
            labelWelcome.Text = $"Добро пожаловать, {logged}!";
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            WinSignIn signin = new WinSignIn();
            signin.Closed += (s, args) => Close();
            signin.Show();
        }
    }
}
