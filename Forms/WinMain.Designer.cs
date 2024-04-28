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
            buttonLogout = new Button();
            textBoxPass1 = new TextBox();
            textBoxHash2 = new TextBox();
            textBoxPass3 = new TextBox();
            buttonPassHash = new Button();
            buttonHashPass = new Button();
            SuspendLayout();
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelWelcome.Location = new Point(12, 11);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(274, 32);
            labelWelcome.TabIndex = 0;
            labelWelcome.Text = "Добро пожаловать!";
            // 
            // buttonLogout
            // 
            buttonLogout.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonLogout.Location = new Point(670, 490);
            buttonLogout.Margin = new Padding(3, 4, 3, 4);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(100, 50);
            buttonLogout.TabIndex = 1;
            buttonLogout.Text = "Выход";
            buttonLogout.UseVisualStyleBackColor = true;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // textBoxPass1
            // 
            textBoxPass1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxPass1.Location = new Point(12, 503);
            textBoxPass1.Name = "textBoxPass1";
            textBoxPass1.Size = new Size(180, 30);
            textBoxPass1.TabIndex = 2;
            // 
            // textBoxHash2
            // 
            textBoxHash2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxHash2.Location = new Point(234, 502);
            textBoxHash2.Name = "textBoxHash2";
            textBoxHash2.Size = new Size(208, 30);
            textBoxHash2.TabIndex = 3;
            // 
            // textBoxPass3
            // 
            textBoxPass3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxPass3.Location = new Point(484, 502);
            textBoxPass3.Name = "textBoxPass3";
            textBoxPass3.Size = new Size(180, 30);
            textBoxPass3.TabIndex = 4;
            // 
            // buttonPassHash
            // 
            buttonPassHash.Location = new Point(198, 503);
            buttonPassHash.Name = "buttonPassHash";
            buttonPassHash.Size = new Size(30, 30);
            buttonPassHash.TabIndex = 5;
            buttonPassHash.Text = ">";
            buttonPassHash.UseVisualStyleBackColor = true;
            buttonPassHash.Click += buttonPassHash_Click;
            // 
            // buttonHashPass
            // 
            buttonHashPass.Location = new Point(448, 502);
            buttonHashPass.Name = "buttonHashPass";
            buttonHashPass.Size = new Size(30, 30);
            buttonHashPass.TabIndex = 6;
            buttonHashPass.Text = ">";
            buttonHashPass.UseVisualStyleBackColor = true;
            buttonHashPass.Click += buttonHashPass_Click;
            // 
            // WinMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(buttonHashPass);
            Controls.Add(buttonPassHash);
            Controls.Add(textBoxPass3);
            Controls.Add(textBoxHash2);
            Controls.Add(textBoxPass1);
            Controls.Add(buttonLogout);
            Controls.Add(labelWelcome);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "WinMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Домашняя Книга";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button buttonLogout;
        private TextBox textBoxPass1;
        private TextBox textBoxHash2;
        private TextBox textBoxPass3;
        private Button buttonPassHash;
        private Button buttonHashPass;
    }
}

