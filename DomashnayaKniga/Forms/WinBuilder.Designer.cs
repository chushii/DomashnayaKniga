namespace DomashnayaKniga.Forms
{
    partial class WinBuilder
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
            labelType = new Label();
            panelSelect = new Panel();
            selectASC_DESC = new Button();
            selectOrder = new TextBox();
            selectOrderLabel = new Label();
            selectWhere = new TextBox();
            selectWhereLabel = new Label();
            selectColumns = new TextBox();
            selectColumnsLabel = new Label();
            comboBoxType = new ComboBox();
            labelTable = new Label();
            comboBoxTable = new ComboBox();
            textBoxResult = new TextBox();
            buttonClear = new Button();
            buttonBuild = new Button();
            panelUpdate = new Panel();
            updateWhere = new TextBox();
            updateSet = new TextBox();
            updateSetLabel = new Label();
            panelInsert = new Panel();
            insertValues = new TextBox();
            insertValuesLabel = new Label();
            insertColumns = new TextBox();
            insertColumnsLabel = new Label();
            updateWhereLabel = new Label();
            panelDelete = new Panel();
            deleteWhere = new TextBox();
            deleteWhereLabel = new Label();
            panelSelect.SuspendLayout();
            panelUpdate.SuspendLayout();
            panelInsert.SuspendLayout();
            panelDelete.SuspendLayout();
            SuspendLayout();
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Location = new Point(12, 12);
            labelType.Name = "labelType";
            labelType.Size = new Size(96, 20);
            labelType.TabIndex = 0;
            labelType.Text = "Тип запроса";
            // 
            // panelSelect
            // 
            panelSelect.Controls.Add(selectASC_DESC);
            panelSelect.Controls.Add(selectOrder);
            panelSelect.Controls.Add(selectOrderLabel);
            panelSelect.Controls.Add(selectWhere);
            panelSelect.Controls.Add(selectWhereLabel);
            panelSelect.Controls.Add(selectColumns);
            panelSelect.Controls.Add(selectColumnsLabel);
            panelSelect.Location = new Point(12, 43);
            panelSelect.Name = "panelSelect";
            panelSelect.Size = new Size(558, 119);
            panelSelect.TabIndex = 1;
            // 
            // selectASC_DESC
            // 
            selectASC_DESC.Location = new Point(425, 81);
            selectASC_DESC.Name = "selectASC_DESC";
            selectASC_DESC.Size = new Size(133, 29);
            selectASC_DESC.TabIndex = 9;
            selectASC_DESC.Text = "По возрастанию";
            selectASC_DESC.UseVisualStyleBackColor = true;
            selectASC_DESC.Click += buttonASC_DESC_Click;
            // 
            // selectOrder
            // 
            selectOrder.Location = new Point(76, 82);
            selectOrder.Name = "selectOrder";
            selectOrder.Size = new Size(343, 27);
            selectOrder.TabIndex = 8;
            // 
            // selectOrderLabel
            // 
            selectOrderLabel.AutoSize = true;
            selectOrderLabel.Location = new Point(3, 85);
            selectOrderLabel.Name = "selectOrderLabel";
            selectOrderLabel.Size = new Size(70, 20);
            selectOrderLabel.TabIndex = 7;
            selectOrderLabel.Text = "Порядок";
            // 
            // selectWhere
            // 
            selectWhere.Location = new Point(76, 45);
            selectWhere.Name = "selectWhere";
            selectWhere.Size = new Size(482, 27);
            selectWhere.TabIndex = 6;
            // 
            // selectWhereLabel
            // 
            selectWhereLabel.AutoSize = true;
            selectWhereLabel.Location = new Point(3, 48);
            selectWhereLabel.Name = "selectWhereLabel";
            selectWhereLabel.Size = new Size(67, 20);
            selectWhereLabel.TabIndex = 5;
            selectWhereLabel.Text = "Условие";
            // 
            // selectColumns
            // 
            selectColumns.Location = new Point(76, 9);
            selectColumns.Name = "selectColumns";
            selectColumns.Size = new Size(482, 27);
            selectColumns.TabIndex = 4;
            // 
            // selectColumnsLabel
            // 
            selectColumnsLabel.AutoSize = true;
            selectColumnsLabel.Location = new Point(3, 12);
            selectColumnsLabel.Name = "selectColumnsLabel";
            selectColumnsLabel.Size = new Size(70, 20);
            selectColumnsLabel.TabIndex = 3;
            selectColumnsLabel.Text = "Столбцы";
            // 
            // comboBoxType
            // 
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "Выборка", "Изменение", "Вставка", "Удаление" });
            comboBoxType.Location = new Point(114, 9);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(173, 28);
            comboBoxType.TabIndex = 2;
            comboBoxType.SelectedIndexChanged += comboBoxType_SelectedIndexChanged;
            // 
            // labelTable
            // 
            labelTable.AutoSize = true;
            labelTable.Location = new Point(323, 12);
            labelTable.Name = "labelTable";
            labelTable.Size = new Size(68, 20);
            labelTable.TabIndex = 3;
            labelTable.Text = "Таблица";
            // 
            // comboBoxTable
            // 
            comboBoxTable.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTable.FormattingEnabled = true;
            comboBoxTable.Items.AddRange(new object[] { "Пользователи", "Книги", "Комнаты", "Компьютеры" });
            comboBoxTable.Location = new Point(397, 9);
            comboBoxTable.Name = "comboBoxTable";
            comboBoxTable.Size = new Size(173, 28);
            comboBoxTable.TabIndex = 4;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(12, 204);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(558, 119);
            textBoxResult.TabIndex = 5;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(12, 168);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(275, 29);
            buttonClear.TabIndex = 11;
            buttonClear.Text = "Очистить";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonBuild
            // 
            buttonBuild.Location = new Point(295, 168);
            buttonBuild.Name = "buttonBuild";
            buttonBuild.Size = new Size(275, 29);
            buttonBuild.TabIndex = 12;
            buttonBuild.Text = "Создать запрос";
            buttonBuild.UseVisualStyleBackColor = true;
            buttonBuild.Click += buttonBuild_Click;
            // 
            // panelUpdate
            // 
            panelUpdate.Controls.Add(updateWhere);
            panelUpdate.Controls.Add(updateWhereLabel);
            panelUpdate.Controls.Add(updateSet);
            panelUpdate.Controls.Add(updateSetLabel);
            panelUpdate.Location = new Point(12, 43);
            panelUpdate.Name = "panelUpdate";
            panelUpdate.Size = new Size(558, 119);
            panelUpdate.TabIndex = 13;
            panelUpdate.Visible = false;
            // 
            // updateWhere
            // 
            updateWhere.Location = new Point(76, 45);
            updateWhere.Name = "updateWhere";
            updateWhere.ScrollBars = ScrollBars.Vertical;
            updateWhere.Size = new Size(482, 27);
            updateWhere.TabIndex = 6;
            // 
            // updateSet
            // 
            updateSet.Location = new Point(76, 9);
            updateSet.Name = "updateSet";
            updateSet.Size = new Size(482, 27);
            updateSet.TabIndex = 4;
            // 
            // updateSetLabel
            // 
            updateSetLabel.AutoSize = true;
            updateSetLabel.Location = new Point(3, 12);
            updateSetLabel.Name = "updateSetLabel";
            updateSetLabel.Size = new Size(76, 20);
            updateSetLabel.TabIndex = 3;
            updateSetLabel.Text = "Значения";
            // 
            // panelInsert
            // 
            panelInsert.Controls.Add(insertValues);
            panelInsert.Controls.Add(insertValuesLabel);
            panelInsert.Controls.Add(insertColumns);
            panelInsert.Controls.Add(insertColumnsLabel);
            panelInsert.Location = new Point(12, 43);
            panelInsert.Name = "panelInsert";
            panelInsert.Size = new Size(558, 119);
            panelInsert.TabIndex = 14;
            panelInsert.Visible = false;
            // 
            // insertValues
            // 
            insertValues.Location = new Point(76, 45);
            insertValues.Multiline = true;
            insertValues.Name = "insertValues";
            insertValues.ScrollBars = ScrollBars.Vertical;
            insertValues.Size = new Size(482, 65);
            insertValues.TabIndex = 6;
            // 
            // insertValuesLabel
            // 
            insertValuesLabel.AutoSize = true;
            insertValuesLabel.Location = new Point(3, 48);
            insertValuesLabel.Name = "insertValuesLabel";
            insertValuesLabel.Size = new Size(76, 20);
            insertValuesLabel.TabIndex = 5;
            insertValuesLabel.Text = "Значения";
            // 
            // insertColumns
            // 
            insertColumns.Location = new Point(76, 9);
            insertColumns.Name = "insertColumns";
            insertColumns.Size = new Size(482, 27);
            insertColumns.TabIndex = 4;
            // 
            // insertColumnsLabel
            // 
            insertColumnsLabel.AutoSize = true;
            insertColumnsLabel.Location = new Point(3, 12);
            insertColumnsLabel.Name = "insertColumnsLabel";
            insertColumnsLabel.Size = new Size(70, 20);
            insertColumnsLabel.TabIndex = 3;
            insertColumnsLabel.Text = "Столбцы";
            // 
            // updateWhereLabel
            // 
            updateWhereLabel.AutoSize = true;
            updateWhereLabel.Location = new Point(3, 48);
            updateWhereLabel.Name = "updateWhereLabel";
            updateWhereLabel.Size = new Size(67, 20);
            updateWhereLabel.TabIndex = 5;
            updateWhereLabel.Text = "Условие";
            // 
            // panelDelete
            // 
            panelDelete.Controls.Add(deleteWhere);
            panelDelete.Controls.Add(deleteWhereLabel);
            panelDelete.Location = new Point(12, 43);
            panelDelete.Name = "panelDelete";
            panelDelete.Size = new Size(558, 119);
            panelDelete.TabIndex = 15;
            panelDelete.Visible = false;
            // 
            // deleteWhere
            // 
            deleteWhere.Location = new Point(76, 9);
            deleteWhere.Name = "deleteWhere";
            deleteWhere.Size = new Size(482, 27);
            deleteWhere.TabIndex = 4;
            // 
            // deleteWhereLabel
            // 
            deleteWhereLabel.AutoSize = true;
            deleteWhereLabel.Location = new Point(3, 12);
            deleteWhereLabel.Name = "deleteWhereLabel";
            deleteWhereLabel.Size = new Size(67, 20);
            deleteWhereLabel.TabIndex = 3;
            deleteWhereLabel.Text = "Условие";
            // 
            // WinBuilder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 333);
            Controls.Add(panelSelect);
            Controls.Add(panelInsert);
            Controls.Add(panelUpdate);
            Controls.Add(panelDelete);
            Controls.Add(buttonBuild);
            Controls.Add(buttonClear);
            Controls.Add(textBoxResult);
            Controls.Add(comboBoxTable);
            Controls.Add(labelTable);
            Controls.Add(comboBoxType);
            Controls.Add(labelType);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "WinBuilder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Конструктор запросов";
            panelSelect.ResumeLayout(false);
            panelSelect.PerformLayout();
            panelUpdate.ResumeLayout(false);
            panelUpdate.PerformLayout();
            panelInsert.ResumeLayout(false);
            panelInsert.PerformLayout();
            panelDelete.ResumeLayout(false);
            panelDelete.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelType;
        private Panel panelSelect;
        private ComboBox comboBoxType;
        private Label selectColumnsLabel;
        private TextBox selectColumns;
        private Label labelTable;
        private ComboBox comboBoxTable;
        private Label selectWhereLabel;
        private TextBox selectOrder;
        private Label selectOrderLabel;
        private TextBox selectWhere;
        private Button selectASC_DESC;
        private TextBox textBoxResult;
        private Button buttonClear;
        private Button buttonBuild;
        private Panel panelUpdate;
        private TextBox updateWhere;
        private TextBox updateSet;
        private Label updateSetLabel;
        private Panel panelInsert;
        private TextBox insertValues;
        private Label insertValuesLabel;
        private TextBox insertColumns;
        private Label insertColumnsLabel;
        private Label updateWhereLabel;
        private Panel panelDelete;
        private TextBox deleteWhere;
        private Label deleteWhereLabel;
    }
}