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
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Security.Policy;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Security;
using Microsoft.EntityFrameworkCore.Metadata;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

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
        private DataGridView dataGridViewTable = new DataGridView()
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

        private TextBox textBoxInput = new TextBox()
        {
            Location = new Point(12, 40),
            Multiline = true,
            ScrollBars = ScrollBars.Vertical,
            Size = new Size(758, 227)
        };

        private TextBox textBoxOutput = new TextBox()
        {
            Location = new Point(12, 314),
            Multiline = true,
            ScrollBars = ScrollBars.Both,
            Size = new Size(758, 227),
            WordWrap = false
        };

        private Button buttonClear = new Button()
        {
            Location = new Point(12, 273),
            Size = new Size(115, 35),
            Text = "Очистить",
            UseVisualStyleBackColor = true
        };

        private Button buttonExecute = new Button()
        {
            Location = new Point(655, 273),
            Size = new Size(115, 35),
            Text = "Выполнить",
            UseVisualStyleBackColor = true
        };

        private Label labelStatus = new Label()
        {
            Location = new Point(404, 280),
            Size = new Size(245, 25),
            TextAlign = ContentAlignment.TopRight
        };

        #endregion

        private Context dbase = new Context();
        private int logged;

        public WinMain(int id)
        {
            InitializeComponent();
            logged = id;
            labelWelcome.Text = $"Добро пожаловать, {dbase.Users.Find(logged)}!";
            tablesToolStripComboBox.Items.AddRange([
                "---", "Users", "Books", "Rooms", "Computers" ]);
            tablesToolStripComboBox.KeyPress += tablesToolStripComboBox_KeyPress;
            tablesToolStripComboBox.TextChanged += tablesToolStripComboBox_TextChanged;
            addToolStripMenuItem.Click += addToolStripMenuItem_Click;
            updateToolStripMenuItem.Click += updateToolStripMenuItem_Click;
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            buttonClear.Click += buttonClear_Click;
            buttonExecute.Click += buttonExecute_Click;
            textBoxOutput.KeyPress += textBoxOutput_KeyPress;
            ormMenuStrip.Items.AddRange(new ToolStripItem[]
            {
                tablesToolStripComboBox, addToolStripMenuItem,
                updateToolStripMenuItem, deleteToolStripMenuItem,
            });
            Controls.Add(labelWelcome);
        }

        #region Toolstrip

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            WinSignIn signin = new WinSignIn();
            signin.Closed += (s, args) => Close();
            signin.Show();
        }

        private void modelfillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Это действие обнулит базу данных и загрузит пресет. Вы уверены?",
                "Заполнение БД", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                dbase.ChangeTracker.Clear();
                dbase.Database.EnsureDeleted();
                dbase.Database.EnsureCreated();
                List<User> users = //debug: у всех пользователей одинаковый пароль - password
                [
                    new User { Id = 2, Login = "vasipup", Password = "Xgu4Yg9dPNfPmQr97g7bjU4M2irUJw8R",
                        FirstName = "Василий", LastName = "Пупкин" },
                    new User { Id = 3, Login = "veronika58", Password = "J/Nuq7VuZe+AE3y/aaWFc/6SIXSu3ExH",
                        FirstName = "Вероника", LastName = "Климцова" },
                    new User { Id = 4, Login = "flamin_go", Password = "wMNBjE3VgrNONe4nKSKiQAGaUvG4ZaWC",
                        FirstName = "Максим", LastName = "Фламин" },
                    new User { Id = 5, Login = "tugoseryy", Password = "s7+C+0h9HScvQDV2ntDC5WKSoqqMc3DK",
                        FirstName = "Кирилл", LastName = "Сизый" },
                    new User { Id = 6, Login = "pav9943", Password = "sD2dUg0JnDFf/Qgb0HaJCXQ2H7ThZP0a",
                        FirstName = "Павел", LastName = "Анасенко" },
                    new User { Id = 7, Login = "restinpeace", Password = "iTfX0jzXRukcKRAJQb/1y/YVxhojI5QG",
                        FirstName = "Семен", LastName = "Погребняк" },
                    new User { Id = 8, Login = "borzzz111", Password = "ts8P0RMSU3jVU1ryHvjlNbQFqvN7kfuu",
                        FirstName = "Евгения", LastName = "Щукина" },
                    new User { Id = 9, Login = "meowrzik", Password = "e4zezea47J3KEahZVPgdxWrTxwYKJKX9",
                        FirstName = "Котяра", LastName = "Крутой" },
                    new User { Id = 10, Login = "ksaibad_", Password = "iGNU8eRT5BP9hTdCAuxiM/GWAUHZ+2N4",
                        FirstName = "Оксана", LastName = "Алленова" }
                ];
                List<Book> books =
                [
                    new Book { Id = 1, Author = "Федор Достоевский", Title = "Преступление и наказание", Genre = "Русская Классика", User = users[0] },
                    new Book { Id = 2, Author = "Агата Кристи", Title = "Десять негритят", Genre = "Детектив", User = null },
                    new Book { Id = 3, Author = "Евгения Гинзбург", Title = "Крутой маршрут", Genre = "Биография", User = null },
                    new Book { Id = 4, Author = "Стивен Кинг", Title = "Как писать книги", Genre = "Наука и образование", User = null },
                    new Book { Id = 5, Author = "Арчибальд Кронин", Title = "Замок Броуди", Genre = "Зарубежная Классика", User = null },
                    new Book { Id = 6, Author = "Томас Харрис", Title = "Молчание ягнят", Genre = "Триллер", User = null },
                    new Book { Id = 7, Author = "Александр Дюма", Title = "Граф Монте-Кристо", Genre = "Приключения", User = null },
                    new Book { Id = 8, Author = "Александр Дюма", Title = "Королева Марго", Genre = "Любовный Роман", User = null },
                    new Book { Id = 9, Author = "Дэн Симмонс", Title = "Зимние призраки", Genre = "Ужасы", User = null },
                    new Book { Id = 10, Author = "Маргарет Митчелл", Title = "Унесенные ветром", Genre = "Зарубежная Классика", User = null },
                    new Book { Id = 11, Author = "Анджела Нанетти", Title = "Мой дедушка был вишней", Genre = "Сказки", User = null },
                    new Book { Id = 12, Author = "Владимир Маяковский", Title = "Во весь голос", Genre = "Поэзия", User = null },
                    new Book { Id = 13, Author = "Жюль Верн", Title = "Таинственный остров", Genre = "Научная Фантастика", User = null },
                    new Book { Id = 14, Author = "Ли Бардуго", Title = "Продажное королевство", Genre = "Фэнтези", User = null },
                    new Book { Id = 15, Author = "Александр Грибоедов", Title = "Горе от ума", Genre = "Русская Классика", User = null },
                    new Book { Id = 16, Author = "Элвин Тоффлер", Title = "Третья волна", Genre = "Бизнес-книги", User = null },
                    new Book { Id = 17, Author = "Адриана Трижиани", Title = "Жена башмачника", Genre = "Любовный Роман", User = null },
                    new Book { Id = 18, Author = "Анна Ахматова", Title = "Сероглазый король", Genre = "Поэзия", User = null },
                    new Book { Id = 19, Author = "Чак Вендиг", Title = "Книга белой смерти", Genre = "Ужасы", User = null },
                    new Book { Id = 20, Author = "Антуан де Сент-Экзюпери", Title = "Маленький принц", Genre = "Зарубежная Классика", User = null },
                    new Book { Id = 21, Author = "Маркус Зусак", Title = "Книжный вор", Genre = "Приключения", User = null },
                    new Book { Id = 22, Author = "Стивен Кинг", Title = "Побег из Шоушенка", Genre = "Триллер", User = null },
                    new Book { Id = 23, Author = "Александр Прохоров", Title = "Русская модель управления", Genre = "Бизнес-книги", User = null },
                    new Book { Id = 24, Author = "Ирвинг Стоун", Title = "Жажда жизни", Genre = "Биография", User = null },
                    new Book { Id = 25, Author = "Марио Пьюзо", Title = "Крестный отец", Genre = "Детектив", User = null },
                    new Book { Id = 26, Author = "Энди Вейер", Title = "Марсианин", Genre = "Научная Фантастика", User = null },
                    new Book { Id = 27, Author = "Михаил Булгаков", Title = "Мастер и Маргарита", Genre = "Русская Классика", User = null },
                    new Book { Id = 28, Author = "Туве Янссон", Title = "Шляпа Волшебника", Genre = "Сказки", User = null },
                    new Book { Id = 29, Author = "Фридрих Ницше", Title = "Так говорил Заратустра", Genre = "Наука и образование", User = null },
                    new Book { Id = 30, Author = "Джордж Мартин", Title = "Буря мечей", Genre = "Фэнтези", User = null }
                ];
                List<Room> rooms =
                [
                    new Room { Id = 1, Name = "Main Hall", User = users[0] },
                    new Room { Id = 2, Name = "Small Hall", User = null },
                    new Room { Id = 3, Name = "Break Room 1", User = null },
                    new Room { Id = 4, Name = "Break Room 2", User = null },
                    new Room { Id = 5, Name = "Computer Room", User = null }
                ];
                List<Computer> computers =
                [
                    new Computer { Id = 1, Room = rooms[0], Name = "Main 1" },
                    new Computer { Id = 2, Room = rooms[0], Name = "Main 2" },
                    new Computer { Id = 3, Room = rooms[0], Name = "Main 3" },
                    new Computer { Id = 4, Room = rooms[1], Name = "Hall 1" },
                    new Computer { Id = 5, Room = rooms[1], Name = "Hall 2" },
                    new Computer { Id = 6, Room = rooms[2], Name = "BR1-1" },
                    new Computer { Id = 7, Room = rooms[2], Name = "BR1-2" },
                    new Computer { Id = 8, Room = rooms[3], Name = "BR2-1" },
                    new Computer { Id = 9, Room = rooms[3], Name = "BR2-2" },
                    new Computer { Id = 10, Room = rooms[4], Name = "PC-1" },
                    new Computer { Id = 11, Room = rooms[4], Name = "PC-2" },
                    new Computer { Id = 12, Room = rooms[4], Name = "PC-3" },
                    new Computer { Id = 13, Room = rooms[4], Name = "PC-4" },
                    new Computer { Id = 14, Room = rooms[4], Name = "PC-5" },
                    new Computer { Id = 15, Room = rooms[4], Name = "PC-6" }
                ];
                foreach (User user in users) dbase.Users.Add(user);
                foreach (Book book in books) dbase.Books.Add(book);
                foreach (Room room in rooms) dbase.Rooms.Add(room);
                foreach (Computer computer in computers) dbase.Computers.Add(computer);
                dbase.SaveChanges();
            }
        }

        private void hashingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WinHashing hashtest = new WinHashing();
            hashtest.Show();
        }

        private void sqliteviewerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://inloop.github.io/sqlite-viewer/",
                UseShellExecute = true
            });
        }

        private void githubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/chushii/DomashnayaKniga/tree/development",
                UseShellExecute = true
            });
        }

        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainToolStripMenuItem.Enabled = false;
            sqlToolStripMenuItem.Enabled = true;
            ormToolStripMenuItem.Enabled = true;
            Controls.Add(labelWelcome);
            Controls.Remove(dataGridViewTable);
            Controls.Remove(ormMenuStrip);
            Controls.Remove(textBoxInput);
            Controls.Remove(textBoxOutput);
            Controls.Remove(buttonClear);
            Controls.Remove(buttonExecute);
            Controls.Remove(labelStatus);
            labelWelcome.Text = $"Добро пожаловать, {dbase.Users.Find(logged)}!";
        }

        private void sqlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainToolStripMenuItem.Enabled = true;
            sqlToolStripMenuItem.Enabled = false;
            ormToolStripMenuItem.Enabled = true;
            Controls.Remove(labelWelcome);
            Controls.Remove(dataGridViewTable);
            Controls.Remove(ormMenuStrip);
            Controls.Add(textBoxInput);
            Controls.Add(textBoxOutput);
            Controls.Add(buttonClear);
            Controls.Add(buttonExecute);
            Controls.Add(labelStatus);
        }

        private void ormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainToolStripMenuItem.Enabled = true;
            sqlToolStripMenuItem.Enabled = true;
            ormToolStripMenuItem.Enabled = false;
            Controls.Remove(labelWelcome);
            Controls.Add(dataGridViewTable);
            Controls.Add(ormMenuStrip);
            Controls.Remove(textBoxInput);
            Controls.Remove(textBoxOutput);
            Controls.Remove(buttonClear);
            Controls.Remove(buttonExecute);
            Controls.Remove(labelStatus);
        }

        #endregion

        #region ORM Page

        private void addToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            List<string> columns = new List<string>();
            for (int i = 1; i < dataGridViewTable.Columns.Count; i++)
            {
                string name = dataGridViewTable.Columns[i].Name;
                if (name != "User" && name != "Room") columns.Add(name);
            }
            List<string> values = new List<string>();
            for (int i = 0; i < columns.Count; i++)
            {
                values.Add("");
            }
            WinEditORM add = new WinEditORM(columns, values);
            DialogResult result = add.ShowDialog(this);
            if (result == DialogResult.Cancel) return;
            switch (tablesToolStripComboBox.Text)
            {
                case "Users":
                    if (add.vals.Contains(""))
                    {
                        MessageBox.Show("Необходимо заполнить все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    User user = new User();
                    user.Login = add.vals[0];
                    user.Password = Encryptor.Hasher(add.vals[1], null);
                    user.FirstName = add.vals[2];
                    user.LastName = add.vals[3];
                    dbase.Users.Add(user);
                    break;
                case "Books":
                    if (add.vals.SkipLast(1).Contains(""))
                    {
                        MessageBox.Show("Обязательные поля не заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    if (!int.TryParse(add.vals[3], out int bkey) && add.vals[3] != "")
                    {
                        MessageBox.Show("ID пользователя указан неверно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    if (dbase.Users.Find(bkey) == null && add.vals[3] != "")
                    {
                        MessageBox.Show("ID пользователя не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    Book book = new Book();
                    book.Author = add.vals[0];
                    book.Title = add.vals[1];
                    book.Genre = add.vals[2];
                    book.User = dbase.Users.Find(bkey);
                    dbase.Books.Add(book);
                    break;
                case "Rooms":
                    if (add.vals[0] == "")
                    {
                        MessageBox.Show("Введите название комнаты", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    if (!int.TryParse(add.vals[1], out int rkey) && add.vals[1] != "")
                    {
                        MessageBox.Show("ID пользователя указан неверно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    if (dbase.Users.Find(rkey) == null && add.vals[1] != "")
                    {
                        MessageBox.Show("ID пользователя не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    Room room = new Room();
                    room.Name = add.vals[0];
                    room.User = dbase.Users.Find(rkey);
                    dbase.Rooms.Add(room);
                    break;
                case "Computers":
                    if (add.vals.Contains(""))
                    {
                        MessageBox.Show("Необходимо заполнить все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    if (!int.TryParse(add.vals[1], out int ckey))
                    {
                        MessageBox.Show("ID комнаты указан неверно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    if (dbase.Rooms.Find(ckey) == null)
                    {
                        MessageBox.Show("ID комнаты не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    Computer computer = new Computer();
                    computer.Name = add.vals[0];
                    computer.Room = dbase.Rooms.Find(ckey);
                    dbase.Computers.Add(computer);
                    break;
                default:
                    break;
            }
            dbase.SaveChanges();
            dataGridViewTable.Refresh();
        }

        private void updateToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            if (dataGridViewTable.SelectedRows.Count != 1) return;
            List<string> columns = new List<string>();
            for (int i = 1; i < dataGridViewTable.Columns.Count; i++)
            {
                string name = dataGridViewTable.Columns[i].Name;
                if (name != "User" && name != "Room") columns.Add(name);
            }
            List<string> values = new List<string>();
            for (int i = 1; i < dataGridViewTable.Columns.Count; i++)
            {
                string name = dataGridViewTable.Columns[i].Name;
                if (name != "User" && name != "Room")
                {
                    string value = dataGridViewTable.SelectedRows[0].Cells[i].Value?.ToString() ?? "";
                    values.Add(value);
                }
            }
            WinEditORM upd = new WinEditORM(columns, values);
            DialogResult result = upd.ShowDialog(this);
            if (result == DialogResult.Cancel) return;
            int index = dataGridViewTable.SelectedRows[0].Index;
            int.TryParse(dataGridViewTable[0, index].Value.ToString(), out int id);
            switch (tablesToolStripComboBox.Text)
            {
                case "Users":
                    User? user = dbase.Users.Find(id);
                    if (user == null) return;
                    if (upd.vals[0] != "") user.Login = upd.vals[0];
                    if (user.Password != upd.vals[1] && upd.vals[1] != "")
                        user.Password = Encryptor.Hasher(upd.vals[1], null);
                    if (upd.vals[2] != "") user.FirstName = upd.vals[2];
                    if (upd.vals[3] != "") user.LastName = upd.vals[3];
                    break;
                case "Books":
                    Book? book = dbase.Books.Find(id);
                    if (book == null) return;
                    if (upd.vals[0] != "") book.Author = upd.vals[0];
                    if (upd.vals[1] != "") book.Title = upd.vals[1];
                    if (upd.vals[2] != "") book.Genre = upd.vals[2];
                    if (upd.vals[3] != "")
                    {
                        int.TryParse(upd.vals[3], out int bkey);
                        if (dbase.Users.Find(bkey) == null) return;
                        book.User = dbase.Users.Find(bkey);
                    }
                    else book.User = null;
                    break;
                case "Rooms":
                    Room? room = dbase.Rooms.Find(id);
                    if (room == null) return;
                    if (upd.vals[0] != "") room.Name = upd.vals[0];
                    if (upd.vals[1] != "")
                    {
                        int.TryParse(upd.vals[1], out int rkey);
                        if (dbase.Users.Find(rkey) == null) return;
                        room.User = dbase.Users.Find(rkey);
                    }
                    else room.User = null;
                    break;
                case "Computers":
                    Computer? computer = dbase.Computers.Find(id);
                    if (computer == null) return;
                    if (upd.vals[0] != "") computer.Name = upd.vals[0];
                    if (upd.vals[1] != "")
                    {
                        int.TryParse(upd.vals[1], out int ckey);
                        if (dbase.Rooms.Find(ckey) == null) return;
                        computer.Room = dbase.Rooms.Find(ckey);
                    }
                    break;
                default:
                    break;
            }
            dbase.SaveChanges();
            dataGridViewTable.Refresh();
        }

        private void deleteToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            if (MessageBox.Show(
                $"Удалить строку {dataGridViewTable.SelectedRows[0].Cells[0].Value}?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int index = dataGridViewTable.SelectedRows[0].Index;
                int.TryParse(dataGridViewTable[0, index].Value.ToString(), out int id);
                switch (tablesToolStripComboBox.Text)
                {
                    case "Users":
                        User? user = dbase.Users.Find(id);
                        if (user != null)
                        {
                            if (user.Id == 1)
                                MessageBox.Show("Вы не можете удалить администратора", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else dbase.Users.Remove(user);
                        }
                        break;
                    case "Books":
                        Book? book = dbase.Books.Find(id);
                        if (book != null)
                        {
                            dbase.Books.Remove(book);
                        }
                        break;
                    case "Rooms":
                        Room? room = dbase.Rooms.Find(id);
                        if (room != null)
                        {
                            dbase.Rooms.Remove(room);
                        }
                        break;
                    case "Computers":
                        Computer? computer = dbase.Computers.Find(id);
                        if (computer != null)
                        {
                            dbase.Computers.Remove(computer);
                        }
                        break;
                    default:
                        break;
                }
                dbase.SaveChanges();
                dataGridViewTable.Refresh();
            }
        }

        private void tablesToolStripComboBox_KeyPress(object? sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void tablesToolStripComboBox_TextChanged(object? sender, EventArgs e)
        {
            dataGridViewTable.DataSource = null;
            switch (tablesToolStripComboBox.Text)
            {
                case "Users":
                    dbase.Users.Load();
                    dataGridViewTable.DataSource = dbase.Users.Local.ToBindingList();
                    break;
                case "Books":
                    dbase.Books.Include(b => b.User).Load();
                    dataGridViewTable.DataSource = dbase.Books.Local.ToBindingList();
                    break;
                case "Rooms":
                    dbase.Rooms.Include(r => r.User).Load();
                    dataGridViewTable.DataSource = dbase.Rooms.Local.ToBindingList();
                    break;
                case "Computers":
                    dbase.Computers.Include(c => c.Room).Load();
                    dataGridViewTable.DataSource = dbase.Computers.Local.ToBindingList();
                    break;
                default:
                    break;
            }
            bool tableselected = dataGridViewTable.DataSource != null;
            addToolStripMenuItem.Enabled = tableselected;
            updateToolStripMenuItem.Enabled = tableselected;
            deleteToolStripMenuItem.Enabled = tableselected;
        }

        #endregion

        #region SQL Page

        private void buttonClear_Click(object? sender, EventArgs e)
        {
            textBoxInput.Text = "";
            textBoxOutput.Text = "";
            labelStatus.Text = "";
        }

        private void buttonExecute_Click(object? sender, EventArgs e)
        {
            string command = textBoxInput.Text;
            if (command.IndexOf(';') != -1) command = command.Substring(0, command.IndexOf(';'));
            string type = checkType(command), table = checkTable(command, type);
            switch (table)
            {
                case "users":
                    labelStatus.Text = "Выполнено";
                    labelStatus.ForeColor = Color.Green;
                    textBoxOutput.Text = table;
                    break;
                case "books":
                    labelStatus.Text = "Выполнено";
                    labelStatus.ForeColor = Color.Green;
                    textBoxOutput.Text = table;
                    break;
                case "rooms":
                    labelStatus.Text = "Выполнено";
                    labelStatus.ForeColor = Color.Green;
                    textBoxOutput.Text = table;
                    break;
                case "computers":
                    labelStatus.Text = "Выполнено";
                    labelStatus.ForeColor = Color.Green;
                    textBoxOutput.Text = table;
                    break;
                case "error_from":
                    labelStatus.Text = "Ошибка";
                    labelStatus.ForeColor = Color.Red;
                    textBoxOutput.Text = "Ошибка: ключевое слово FROM не найдено";
                    break;
                case "error_into":
                    labelStatus.Text = "Ошибка";
                    labelStatus.ForeColor = Color.Red;
                    textBoxOutput.Text = "Ошибка: ключевое слово INTO не найдено";
                    break;
                case "error_table":
                    labelStatus.Text = "Ошибка";
                    labelStatus.ForeColor = Color.Red;
                    textBoxOutput.Text = "Ошибка: ключевое слово TABLE не найдено";
                    break;
                case "error_none":
                    labelStatus.Text = "Ошибка";
                    labelStatus.ForeColor = Color.Red;
                    if (type == "error") textBoxOutput.Text = "Ошибка: пустой запрос";
                    else textBoxOutput.Text = "Ошибка: команда не поддерживается";
                    break;
                default:
                    labelStatus.Text = "Ошибка";
                    labelStatus.ForeColor = Color.Red;
                    textBoxOutput.Text = $"Ошибка: таблица {table} не найдена";
                    break;
            }
        }

        private string checkType(string quary)
        {
            if (quary == "") return "error";
            string result = quary.Split(" ")[0].TrimEnd().ToLower();
            quary = quary.Substring(result.Length);
            switch (result)
            {
                case "select": case "insert": case "delete": case "update":
                    break;
                default:
                    return "none";
            }
            return result;
        }

        private string checkTable(string quary, string type)
        {
            int i;
            if (type == "select" || type == "delete")
            {
                i = quary.ToLower().IndexOf("from ");
                if (i == -1) return "error_from";
                else i += 5;
            }
            else if (type == "insert")
            {
                i = quary.ToLower().IndexOf("into ");
                if (i == -1) return "error_into";
                else i += 5;
            }
            else if (type == "update")
            {
                i = quary.ToLower().IndexOf("table ");
                if (i == -1) return "error_table";
                else i += 6;
            }
            else return "error_none";
            return quary.Substring(i).Split(" ")[0].ToLower();
        }

        private void textBoxOutput_KeyPress(object? sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        #endregion
    }
}
