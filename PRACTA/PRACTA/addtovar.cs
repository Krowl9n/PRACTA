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
    public partial class addtovar : Form
    {
        public addtovar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form10 main = this.Owner as Form10;
            if (main != null)
            {
                DataRow nRow = main.qwe1DataSet.Tables[6].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = textBox1.Text;
                nRow[2] = textBox2.Text;
                main.qwe1DataSet.Tables[6].Rows.Add(nRow);
                main.товарTableAdapter.Update(main.qwe1DataSet.Товар);
                main.qwe1DataSet.Tables[6].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
