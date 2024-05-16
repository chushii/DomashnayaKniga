namespace DomashnayaKniga.Forms
{
    partial class WinHashing
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
            textBoxPass = new TextBox();
            buttonHash = new Button();
            textBoxHash1 = new TextBox();
            buttonSalt = new Button();
            textBoxHash2 = new TextBox();
            SuspendLayout();
            // 
            // textBoxPass
            // 
            textBoxPass.Location = new Point(12, 12);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.PlaceholderText = "Текст";
            textBoxPass.Size = new Size(323, 27);
            textBoxPass.TabIndex = 0;
            textBoxPass.TabStop = false;
            // 
            // buttonHash
            // 
            buttonHash.Location = new Point(341, 11);
            buttonHash.Name = "buttonHash";
            buttonHash.Size = new Size(29, 29);
            buttonHash.TabIndex = 1;
            buttonHash.Text = ">";
            buttonHash.UseVisualStyleBackColor = true;
            buttonHash.Click += buttonHash_Click;
            // 
            // textBoxHash1
            // 
            textBoxHash1.Location = new Point(12, 45);
            textBoxHash1.Name = "textBoxHash1";
            textBoxHash1.PlaceholderText = "Хеш с случайной солью";
            textBoxHash1.Size = new Size(323, 27);
            textBoxHash1.TabIndex = 2;
            textBoxHash1.TabStop = false;
            // 
            // buttonSalt
            // 
            buttonSalt.Location = new Point(341, 44);
            buttonSalt.Name = "buttonSalt";
            buttonSalt.Size = new Size(29, 29);
            buttonSalt.TabIndex = 3;
            buttonSalt.Text = ">";
            buttonSalt.UseVisualStyleBackColor = true;
            buttonSalt.Click += buttonSalt_Click;
            // 
            // textBoxHash2
            // 
            textBoxHash2.Location = new Point(12, 78);
            textBoxHash2.Name = "textBoxHash2";
            textBoxHash2.PlaceholderText = "Хеш с солью из верхнего хеша";
            textBoxHash2.Size = new Size(358, 27);
            textBoxHash2.TabIndex = 4;
            textBoxHash2.TabStop = false;
            // 
            // WinHashing
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 118);
            Controls.Add(textBoxHash2);
            Controls.Add(buttonSalt);
            Controls.Add(textBoxHash1);
            Controls.Add(buttonHash);
            Controls.Add(textBoxPass);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "WinHashing";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Проверка хеширования";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPass;
        private Button buttonHash;
        private TextBox textBoxHash1;
        private Button buttonSalt;
        private TextBox textBoxHash2;
    }
}