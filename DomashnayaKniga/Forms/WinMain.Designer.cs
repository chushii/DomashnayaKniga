namespace DomashnayaKniga
{
    partial class WinMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinMain));
            labelWelcome = new Label();
            menuStrip1 = new MenuStrip();
            mainToolStripMenuItem = new ToolStripMenuItem();
            databaseToolStripMenuItem = new ToolStripMenuItem();
            sqlToolStripMenuItem = new ToolStripMenuItem();
            ormToolStripMenuItem = new ToolStripMenuItem();
            otherToolStripMenuItem = new ToolStripMenuItem();
            hashingToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelWelcome.Location = new Point(12, 44);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(274, 32);
            labelWelcome.TabIndex = 0;
            labelWelcome.Text = "Добро пожаловать!";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mainToolStripMenuItem, databaseToolStripMenuItem, otherToolStripMenuItem, logoutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(782, 28);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // mainToolStripMenuItem
            // 
            mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            mainToolStripMenuItem.Size = new Size(148, 24);
            mainToolStripMenuItem.Text = "Главная страница";
            // 
            // databaseToolStripMenuItem
            // 
            databaseToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sqlToolStripMenuItem, ormToolStripMenuItem });
            databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            databaseToolStripMenuItem.Size = new Size(111, 24);
            databaseToolStripMenuItem.Text = "База данных";
            // 
            // sqlToolStripMenuItem
            // 
            sqlToolStripMenuItem.Name = "sqlToolStripMenuItem";
            sqlToolStripMenuItem.Size = new Size(125, 26);
            sqlToolStripMenuItem.Text = "SQL";
            // 
            // ormToolStripMenuItem
            // 
            ormToolStripMenuItem.Name = "ormToolStripMenuItem";
            ormToolStripMenuItem.Size = new Size(125, 26);
            ormToolStripMenuItem.Text = "ORM";
            // 
            // otherToolStripMenuItem
            // 
            otherToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hashingToolStripMenuItem });
            otherToolStripMenuItem.Name = "otherToolStripMenuItem";
            otherToolStripMenuItem.Size = new Size(76, 24);
            otherToolStripMenuItem.Text = "Прочее";
            // 
            // hashingToolStripMenuItem
            // 
            hashingToolStripMenuItem.Name = "hashingToolStripMenuItem";
            hashingToolStripMenuItem.Size = new Size(190, 26);
            hashingToolStripMenuItem.Text = "Хеширование";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            logoutToolStripMenuItem.BackColor = Color.Bisque;
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(67, 24);
            logoutToolStripMenuItem.Text = "Выход";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // WinMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(labelWelcome);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "WinMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Домашняя Книга";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelWelcome;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mainToolStripMenuItem;
        private ToolStripMenuItem databaseToolStripMenuItem;
        private ToolStripMenuItem otherToolStripMenuItem;
        private ToolStripMenuItem sqlToolStripMenuItem;
        private ToolStripMenuItem ormToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem hashingToolStripMenuItem;
    }
}

