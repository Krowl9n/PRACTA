using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRACTA
{
    public partial class addformat : Form
    {
        public addformat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 main = this.Owner as Form8;
            if (main != null)
            {
                DataRow nRow = main.qwe1DataSet.Tables[8].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = textBox1.Text;
                main.qwe1DataSet.Tables[8].Rows.Add(nRow);
                main.форматTableAdapter.Update(main.qwe1DataSet.Формат);
                main.qwe1DataSet.Tables[8].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox1.Text = "";
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
