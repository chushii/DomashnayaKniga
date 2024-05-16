namespace DomashnayaKniga.Forms
{
    partial class WinEditORM
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
            listViewColumns = new ListView();
            headerColumns = new ColumnHeader();
            buttonSave = new Button();
            buttonCancel = new Button();
            listViewValues = new ListView();
            headerValues = new ColumnHeader();
            SuspendLayout();
            // 
            // listViewColumns
            // 
            listViewColumns.Columns.AddRange(new ColumnHeader[] { headerColumns });
            listViewColumns.GridLines = true;
            listViewColumns.Location = new Point(14, 12);
            listViewColumns.Name = "listViewColumns";
            listViewColumns.Size = new Size(175, 358);
            listViewColumns.TabIndex = 0;
            listViewColumns.UseCompatibleStateImageBehavior = false;
            listViewColumns.View = View.Details;
            // 
            // headerColumns
            // 
            headerColumns.Text = "Столбцы";
            headerColumns.Width = 170;
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonSave.Location = new Point(14, 376);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(175, 65);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Принять";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCancel.Location = new Point(195, 376);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(175, 65);
            buttonCancel.TabIndex = 4;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // listViewValues
            // 
            listViewValues.Columns.AddRange(new ColumnHeader[] { headerValues });
            listViewValues.GridLines = true;
            listViewValues.LabelEdit = true;
            listViewValues.Location = new Point(195, 12);
            listViewValues.Name = "listViewValues";
            listViewValues.Size = new Size(175, 358);
            listViewValues.TabIndex = 5;
            listViewValues.UseCompatibleStateImageBehavior = false;
            listViewValues.View = View.Details;
            // 
            // headerValues
            // 
            headerValues.Text = "Значения";
            headerValues.Width = 170;
            // 
            // WinEditORM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 453);
            Controls.Add(listViewValues);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(listViewColumns);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "WinEditORM";
            Text = "Редактирование таблицы";
            Load += WinEditORM_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewColumns;
        private ListView listViewValues;
        private Button buttonSave;
        private Button buttonCancel;
        private ColumnHeader headerColumns;
        private ColumnHeader headerValues;
    }
}