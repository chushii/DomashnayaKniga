using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DomashnayaKniga.Forms
{
    public partial class WinEditORM : Form
    {
        private List<string> cols;
        private List<string?>? vals;
        public WinEditORM(List<string> columns, List<string?>? values)
        {
            InitializeComponent();
            cols = columns; vals = values;
        }

        private void WinEditORM_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < cols.Count; i++)
            {
                listViewColumns.Items.Add(new ListViewItem(cols[i]));
                if (vals == null) listViewValues.Items.Add(new ListViewItem(""));
                else listViewValues.Items.Add(new ListViewItem(vals[i]));
            }
        }
    }
}
