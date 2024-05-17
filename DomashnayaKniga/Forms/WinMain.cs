﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore;

namespace DomashnayaKniga.Forms
{
    public partial class WinMain : Form
    {
        #region Dynamic Controls

        private Label labelWelcome = new Label()
        {
            AutoSize = true,
            Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204),
            Location = new Point(12, 38)
        };
        private DataGridView dataGridViewUsers = new DataGridView()
        {
            Location = new Point(0, 31),
            Size = new Size(782, 491),
            AllowUserToAddRows = false,
            AllowUserToDeleteRows = false,
            ColumnHeadersVisible = true,
            MultiSelect = false,
            EditMode = DataGridViewEditMode.EditProgrammatically,
            SelectionMode = DataGridViewSelectionMode.FullRowSelect
        };
        private MenuStrip ormMenuStrip = new MenuStrip()
        {
            Dock = DockStyle.Bottom,
            ImageScalingSize = new Size(20, 20),
            BackColor = SystemColors.ControlLight
    };
        private ToolStripComboBox tablesToolStripComboBox = new ToolStripComboBox()
        {
            Alignment = ToolStripItemAlignment.Right,
            Text = "---"
        };
        private ToolStripMenuItem addToolStripMenuItem = new ToolStripMenuItem()
        {
            Text = "Добавить",
            Enabled = false
        };
        private ToolStripMenuItem updateToolStripMenuItem = new ToolStripMenuItem()
        {
            Text = "Изменить",
            Enabled = false
        };
        private ToolStripMenuItem deleteToolStripMenuItem = new ToolStripMenuItem()
        {
            Text = "Удалить",
            Enabled = false
        };

        #endregion

        private Context dbase = new Context();
        private User logged;

        public WinMain(User user)
        {
            InitializeComponent();
            logged = user;
            labelWelcome.Text = $"Добро пожаловать, {logged}!";
            tablesToolStripComboBox.Items.AddRange(["---", "Users"]);
            tablesToolStripComboBox.KeyPress += tablesToolStripComboBox_KeyPress;
            tablesToolStripComboBox.TextChanged += tablesToolStripComboBox_TextChanged;
            addToolStripMenuItem.Click += addToolStripMenuItem_Click;
            updateToolStripMenuItem.Click += updateToolStripMenuItem_Click;
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            ormMenuStrip.Items.AddRange(new ToolStripItem[]
            {
                tablesToolStripComboBox, addToolStripMenuItem,
                updateToolStripMenuItem, deleteToolStripMenuItem,
            });
            Controls.Add(labelWelcome);
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            WinSignIn signin = new WinSignIn();
            signin.Closed += (s, args) => Close();
            signin.Show();
        }

        private void hashingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WinHashing hashtest = new WinHashing();
            hashtest.Show();
        }

        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainToolStripMenuItem.Enabled = false;
            sqlToolStripMenuItem.Enabled = true;
            ormToolStripMenuItem.Enabled = true;
            Controls.Add(labelWelcome);
            Controls.Remove(dataGridViewUsers);
            Controls.Remove(ormMenuStrip);
        }

        private void sqlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainToolStripMenuItem.Enabled = true;
            sqlToolStripMenuItem.Enabled = false;
            ormToolStripMenuItem.Enabled = true;
            Controls.Remove(labelWelcome);
            Controls.Remove(dataGridViewUsers);
            Controls.Remove(ormMenuStrip);
        }

        private void ormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainToolStripMenuItem.Enabled = true;
            sqlToolStripMenuItem.Enabled = true;
            ormToolStripMenuItem.Enabled = false;
            Controls.Remove(labelWelcome);
            Controls.Add(dataGridViewUsers);
            Controls.Add(ormMenuStrip);
        }

        #region ORM Page

        private void addToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            List<string> columns = new List<string>();
            for (int i = 0; i < dataGridViewUsers.Columns.Count; i++)
            {
                columns.Add(dataGridViewUsers.Columns[i].Name);
            }
            List<string> values = new List<string>();
            for (int i = 0; i < dataGridViewUsers.Columns.Count; i++)
            {
                values.Add("");
            }
            WinEditORM add = new WinEditORM(columns, values);
            DialogResult result = add.ShowDialog(this);
            if (result == DialogResult.Cancel) return;
            switch (tablesToolStripComboBox.Text)
            {
                case "Users":
                    User user = new User();
                    user.Login = add.vals[0];
                    user.Password = Encryptor.Hasher(add.vals[1], null);
                    user.FirstName = add.vals[2];
                    user.LastName = add.vals[3];
                    dbase.Users.Add(user);
                    break;
                default:
                    break;
            }
            dbase.SaveChanges();
            dataGridViewUsers.Refresh();
        }

        private void updateToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count != 1) return;
            List<string> columns = new List<string>();
            for (int i = 0; i < dataGridViewUsers.Columns.Count; i++)
            {
                columns.Add(dataGridViewUsers.Columns[i].Name);
            }
            List<string> values = new List<string>();
            for (int i = 0; i < dataGridViewUsers.Columns.Count; i++)
            {
                string? value = dataGridViewUsers.SelectedRows[0].Cells[i].Value.ToString() ?? "";
                values.Add(value);
            }
            WinEditORM upd = new WinEditORM(columns, values);
            DialogResult result = upd.ShowDialog(this);
            if (result == DialogResult.Cancel) return;
            int index = dataGridViewUsers.SelectedRows[0].Index;
            int.TryParse(dataGridViewUsers[0, index].Value.ToString(), out int id);
            switch (tablesToolStripComboBox.Text)
            {
                case "Users":
                    User? user = dbase.Users.Find(id);
                    if (user == null) return;
                    user.Login = upd.vals[0];
                    if (user.Password != upd.vals[1])
                        user.Password = Encryptor.Hasher(upd.vals[1], null);
                    user.FirstName = upd.vals[2];
                    user.LastName = upd.vals[3];
                    break;
                default:
                    break;
            }
            dbase.SaveChanges();
            dataGridViewUsers.Refresh();
        }

        private void deleteToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            if (MessageBox.Show(
                $"Удалить строку {dataGridViewUsers.SelectedRows[0].Cells[0].Value}?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int index = dataGridViewUsers.SelectedRows[0].Index; 
                int.TryParse(dataGridViewUsers[0, index].Value.ToString(), out int id);
                switch (tablesToolStripComboBox.Text)
                {
                    case "Users":
                        User? user = dbase.Users.Find(id);
                        if (user != null) dbase.Users.Remove(user);
                        break;
                    default:
                        break;
                }
                dbase.SaveChanges();
                dataGridViewUsers.Refresh();
            }
        }

        private void tablesToolStripComboBox_KeyPress(object? sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void tablesToolStripComboBox_TextChanged(object? sender, EventArgs e)
        {
            switch (tablesToolStripComboBox.Text)
            {
                case "---":
                    dataGridViewUsers.DataSource = null;
                    addToolStripMenuItem.Enabled = false;
                    updateToolStripMenuItem.Enabled = false;
                    deleteToolStripMenuItem.Enabled = false;
                    break;
                case "Users":
                    dbase.Users.Load();
                    dataGridViewUsers.DataSource = dbase.Users.Local.ToBindingList();
                    addToolStripMenuItem.Enabled = true;
                    updateToolStripMenuItem.Enabled = true;
                    deleteToolStripMenuItem.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        #endregion
    }
}
