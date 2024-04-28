namespace DomashnayaKniga
{
    partial class WinSignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinSignIn));
            titlePanel = new Panel();
            titleText = new Label();
            titleIcon = new PictureBox();
            labelLogin = new Label();
            textBoxLogin = new TextBox();
            labelPassword = new Label();
            textBoxPassword = new TextBox();
            checkBoxPassword = new CheckBox();
            buttonLogin = new Button();
            gotoSignup = new Label();
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
            titlePanel.TabIndex = 0;
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
            titleIcon.MouseClick += titleIcon_MouseClick;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelLogin.Location = new Point(18, 111);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(74, 25);
            labelLogin.TabIndex = 1;
            labelLogin.Text = "Логин:";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxLogin.Location = new Point(12, 140);
            textBoxLogin.Margin = new Padding(3, 4, 3, 4);
            textBoxLogin.MaxLength = 32;
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(358, 30);
            textBoxLogin.TabIndex = 2;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelPassword.Location = new Point(18, 179);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(86, 25);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Пароль:";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxPassword.Location = new Point(12, 208);
            textBoxPassword.Margin = new Padding(3, 4, 3, 4);
            textBoxPassword.MaxLength = 16;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(358, 30);
            textBoxPassword.TabIndex = 4;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // checkBoxPassword
            // 
            checkBoxPassword.AutoSize = true;
            checkBoxPassword.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkBoxPassword.Location = new Point(258, 180);
            checkBoxPassword.Margin = new Padding(3, 4, 3, 4);
            checkBoxPassword.Name = "checkBoxPassword";
            checkBoxPassword.Size = new Size(112, 24);
            checkBoxPassword.TabIndex = 6;
            checkBoxPassword.Text = "Показать";
            checkBoxPassword.UseVisualStyleBackColor = true;
            checkBoxPassword.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // buttonLogin
            // 
            buttonLogin.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonLogin.Location = new Point(12, 260);
            buttonLogin.Margin = new Padding(3, 4, 3, 4);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(358, 68);
            buttonLogin.TabIndex = 7;
            buttonLogin.Text = "Войти";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // gotoSignup
            // 
            gotoSignup.AutoSize = true;
            gotoSignup.Cursor = Cursors.Hand;
            gotoSignup.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Underline, GraphicsUnit.Point, 204);
            gotoSignup.ForeColor = SystemColors.Highlight;
            gotoSignup.Location = new Point(124, 347);
            gotoSignup.Name = "gotoSignup";
            gotoSignup.Size = new Size(131, 25);
            gotoSignup.TabIndex = 8;
            gotoSignup.Text = "Регистрация";
            gotoSignup.TextAlign = ContentAlignment.MiddleCenter;
            gotoSignup.Click += gotoSignup_Click;
            // 
            // WinSignIn
            // 
            AcceptButton = buttonLogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 393);
            Controls.Add(gotoSignup);
            Controls.Add(buttonLogin);
            Controls.Add(checkBoxPassword);
            Controls.Add(textBoxPassword);
            Controls.Add(labelPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(labelLogin);
            Controls.Add(titlePanel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "WinSignIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вход в учётную запись";
            titlePanel.ResumeLayout(false);
            titlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)titleIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.PictureBox titleIcon;
        private System.Windows.Forms.Label titleText;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.CheckBox checkBoxPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label gotoSignup;
    }
}