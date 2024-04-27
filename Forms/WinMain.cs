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
    public partial class WinMain : Form
    {
        public WinMain(string fName, string lName)
        {
            InitializeComponent();
            labelWelcome.Text = $"Добро пожаловать, {fName} {lName}!";
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Hide();
            WinLogin login = new WinLogin();
            login.Closed += (s, args) => Close();
            login.Show();
        }
    }
}
