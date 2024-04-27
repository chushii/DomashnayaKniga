namespace DomashnayaKniga
{
    partial class WinSignup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinSignup));
            titlePanel = new Panel();
            titleText = new Label();
            titleIcon = new PictureBox();
            textBoxPassword = new TextBox();
            labelPassword = new Label();
            textBoxLogin = new TextBox();
            labelLogin = new Label();
            labelPassword2 = new Label();
            textBoxPassword2 = new TextBox();
            textBoxFirstName = new TextBox();
            labelFirstName = new Label();
            textBoxLastName = new TextBox();
            labelLastName = new Label();
            buttonSignup = new Button();
            gotoLogin = new Label();
            titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)titleIcon).BeginInit();
            SuspendLayout();
            // 
            // titlePanel
            // 
            titlePanel.BackColor = Color.LightGreen;
            titlePanel.Controls.Add(titleText);
            titlePanel.Controls.Add(titleIcon);
            titlePanel.Location = new Point(12, 15);
            titlePanel.Margin = new Padding(3, 4, 3, 4);
            titlePanel.Name = "titlePanel";
            titlePanel.Size = new Size(358, 86);
            titlePanel.TabIndex = 1;
            // 
            // titleText
            // 
            titleText.AutoSize = true;
            titleText.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            titleText.Location = new Point(80, 20);
            titleText.Name = "titleText";
            titleText.Size = new Size(259, 42);
            titleText.TabIndex = 1;
            titleText.Text = "Домашняя Книга";
            // 
            // titleIcon
            // 
            titleIcon.Image = (Image)resources.GetObject("titleIcon.Image");
            titleIcon.Location = new Point(11, 4);
            titleIcon.Margin = new Padding(3, 4, 3, 4);
            titleIcon.Name = "titleIcon";
            titleIcon.Size = new Size(63, 79);
            titleIcon.SizeMode = PictureBoxSizeMode.Zoom;
            titleIcon.TabIndex = 0;
            titleIcon.TabStop = false;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxPassword.Location = new Point(12, 208);
            textBoxPassword.Margin = new Padding(3, 4, 3, 4);
            textBoxPassword.MaxLength = 16;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(358, 30);
            textBoxPassword.TabIndex = 8;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelPassword.Location = new Point(18, 179);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(86, 25);
            labelPassword.TabIndex = 7;
            labelPassword.Text = "Пароль:";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxLogin.Location = new Point(12, 140);
            textBoxLogin.Margin = new Padding(3, 4, 3, 4);
            textBoxLogin.MaxLength = 32;
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(358, 30);
            textBoxLogin.TabIndex = 6;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelLogin.Location = new Point(18, 111);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(74, 25);
            labelLogin.TabIndex = 5;
            labelLogin.Text = "Логин:";
            // 
            // labelPassword2
            // 
            labelPassword2.AutoSize = true;
            labelPassword2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelPassword2.Location = new Point(18, 247);
            labelPassword2.Name = "labelPassword2";
            labelPassword2.Size = new Size(191, 25);
            labelPassword2.TabIndex = 9;
            labelPassword2.Text = "Повторите пароль:";
            // 
            // textBoxPassword2
            // 
            textBoxPassword2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxPassword2.Location = new Point(12, 276);
            textBoxPassword2.Margin = new Padding(3, 4, 3, 4);
            textBoxPassword2.MaxLength = 16;
            textBoxPassword2.Name = "textBoxPassword2";
            textBoxPassword2.Size = new Size(358, 30);
            textBoxPassword2.TabIndex = 10;
            textBoxPassword2.UseSystemPasswordChar = true;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxFirstName.Location = new Point(12, 344);
            textBoxFirstName.Margin = new Padding(3, 4, 3, 4);
            textBoxFirstName.MaxLength = 24;
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(358, 30);
            textBoxFirstName.TabIndex = 12;
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelFirstName.Location = new Point(18, 315);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(60, 25);
            labelFirstName.TabIndex = 11;
            labelFirstName.Text = "Имя:";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxLastName.Location = new Point(12, 412);
            textBoxLastName.Margin = new Padding(3, 4, 3, 4);
            textBoxLastName.MaxLength = 24;
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(358, 30);
            textBoxLastName.TabIndex = 14;
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelLastName.Location = new Point(18, 383);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(109, 25);
            labelLastName.TabIndex = 13;
            labelLastName.Text = "Фамилия:";
            // 
            // buttonSignup
            // 
            buttonSignup.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonSignup.Location = new Point(12, 464);
            buttonSignup.Margin = new Padding(3, 4, 3, 4);
            buttonSignup.Name = "buttonSignup";
            buttonSignup.Size = new Size(358, 68);
            buttonSignup.TabIndex = 15;
            buttonSignup.Text = "Зарегистрироваться";
            buttonSignup.UseVisualStyleBackColor = true;
            buttonSignup.Click += buttonSignup_Click;
            // 
            // gotoLogin
            // 
            gotoLogin.AutoSize = true;
            gotoLogin.Cursor = Cursors.Hand;
            gotoLogin.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Underline, GraphicsUnit.Point, 204);
            gotoLogin.ForeColor = SystemColors.Highlight;
            gotoLogin.Location = new Point(77, 549);
            gotoLogin.Name = "gotoLogin";
            gotoLogin.Size = new Size(223, 25);
            gotoLogin.TabIndex = 16;
            gotoLogin.Text = "Вход в учётную запись";
            gotoLogin.TextAlign = ContentAlignment.MiddleCenter;
            gotoLogin.Click += gotoLogin_Click;
            // 
            // WinSignup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 593);
            Controls.Add(gotoLogin);
            Controls.Add(buttonSignup);
            Controls.Add(textBoxLastName);
            Controls.Add(labelLastName);
            Controls.Add(textBoxFirstName);
            Controls.Add(labelFirstName);
            Controls.Add(textBoxPassword2);
            Controls.Add(labelPassword2);
            Controls.Add(textBoxPassword);
            Controls.Add(labelPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(labelLogin);
            Controls.Add(titlePanel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "WinSignup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Регистрация";
            titlePanel.ResumeLayout(false);
            titlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)titleIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label titleText;
        private System.Windows.Forms.PictureBox titleIcon;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword2;
        private System.Windows.Forms.TextBox textBoxPassword2;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Button buttonSignup;
        private System.Windows.Forms.Label gotoLogin;
    }
}