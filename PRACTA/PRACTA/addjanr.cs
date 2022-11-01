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
    public partial class addjanr : Form
    {
        public addjanr()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 main = this.Owner as Form3;
            if (main != null)
            {
                DataRow nRow = main.qwe1DataSet.Tables[1].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = textBox1.Text;
                main.qwe1DataSet.Tables[1].Rows.Add(nRow);
                main.жанрыTableAdapter.Update(main.qwe1DataSet.Жанры);
                main.qwe1DataSet.Tables[1].AcceptChanges();
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
