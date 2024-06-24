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
    public partial class WinBuilder : Form
    {
        public WinBuilder()
        {
            InitializeComponent();
            comboBoxType.SelectedIndex = 0;
            comboBoxTable.SelectedIndex = 0;
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxType.SelectedIndex)
            {
                case 0:
                    panelSelect.Visible = true;
                    panelUpdate.Visible = false;
                    panelInsert.Visible = false;
                    panelDelete.Visible = false;
                    break;
                case 1:
                    panelSelect.Visible = false;
                    panelUpdate.Visible = true;
                    panelInsert.Visible = false;
                    panelDelete.Visible = false;
                    break;
                case 2:
                    panelSelect.Visible = false;
                    panelUpdate.Visible = false;
                    panelInsert.Visible = true;
                    panelDelete.Visible = false;
                    break;
                case 3:
                    panelSelect.Visible = false;
                    panelUpdate.Visible = false;
                    panelInsert.Visible = false;
                    panelDelete.Visible = true;
                    break;
            }
        }

        private void buttonASC_DESC_Click(object sender, EventArgs e)
        {
            if (selectASC_DESC.Text == "По возрастанию")
                selectASC_DESC.Text = "По убыванию";
            else
                selectASC_DESC.Text = "По возрастанию";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            selectColumns.Text = ""; selectWhere.Text = "";
            selectOrder.Text = ""; textBoxResult.Text = "";
            selectASC_DESC.Text = "По возрастанию";
        }

        private void buttonBuild_Click(object sender, EventArgs e)
        {
            QueryBuilder builder = new QueryBuilder();
            switch (comboBoxType.SelectedIndex)
            {
                case 0: //select
                    builder.Reset();
                    builder.SetType(comboBoxType.Text);
                    builder.SetColumns(selectColumns.Text);
                    builder.SetTable(comboBoxTable.Text);
                    builder.SetWhere(selectWhere.Text);
                    builder.SetOrder(selectOrder.Text, selectASC_DESC.Text);
                    break;
                case 1: //update
                    builder.Reset();
                    builder.SetType(comboBoxType.Text);
                    builder.SetTable(comboBoxTable.Text);
                    builder.SetValues(updateSet.Text);
                    builder.SetWhere(updateWhere.Text);
                    break;
                case 2: //insert
                    builder.Reset();
                    builder.SetType(comboBoxType.Text);
                    builder.SetTable(comboBoxTable.Text);
                    builder.SetColumns(insertColumns.Text);
                    builder.SetValues(insertValues.Text);
                    break;
                case 3: //delete
                    builder.Reset();
                    builder.SetType(comboBoxType.Text);
                    builder.SetTable(comboBoxTable.Text);
                    builder.SetWhere(deleteWhere.Text);
                    break;
            }
            textBoxResult.Text = builder.Result();
        }
    }
}
