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
    public partial class WinSignup : Form
    {
        public WinSignup()
        {
            InitializeComponent();
        }

        private void gotoLogin_Click(object sender, EventArgs e)
        {
            Hide();
            WinLogin login = new WinLogin();
            login.Closed += (s, args) => Close();
            login.Show();
        }

        private void buttonSignup_Click(object sender, EventArgs e)
        {
            
        }
    }
}
