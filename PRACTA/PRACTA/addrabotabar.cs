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
    public partial class addrabotabar : Form
    {
        public addrabotabar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 main = this.Owner as Form6;
            if (main != null)
            {
                DataRow nRow = main.qwe1DataSet.Tables[3].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[3] = textBox1.Text;
                nRow[4] = textBox2.Text;
                nRow[5] = dateTimePicker1.Text;
                main.qwe1DataSet.Tables[3].Rows.Add(nRow);
                main.работа_бараTableAdapter.Update(main.qwe1DataSet.Работа_бара);
                main.qwe1DataSet.Tables[3].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox1.Text = "";
                textBox2.Text = "";
                dateTimePicker1.Text = "";

            }
        }
    }
}
