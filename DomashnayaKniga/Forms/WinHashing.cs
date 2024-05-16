using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DomashnayaKniga.Forms
{
    public partial class WinHashing : Form
    {
        public WinHashing()
        {
            InitializeComponent();
        }

        private void buttonHash_Click(object sender, EventArgs e)
        {
            if (textBoxPass.Text == "") return;
            textBoxHash1.Text = Encryptor.Hasher(textBoxPass.Text, null);
        }

        private void buttonSalt_Click(object sender, EventArgs e)
        {
            if (textBoxPass.Text == "" || textBoxHash1.Text == "") return;
            byte[] old_salt = Encryptor.Extract(textBoxHash1.Text);
            textBoxHash2.Text = Encryptor.Hasher(textBoxPass.Text, old_salt);
        }
    }
}
