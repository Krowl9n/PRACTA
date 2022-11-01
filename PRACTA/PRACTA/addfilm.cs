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
    public partial class addfilm : Form
    {
        public addfilm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 main = this.Owner as Form7;
            if (main != null)
            {
                DataRow nRow = main.qwe1DataSet.Tables[7].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = textBox1.Text;
                nRow[3] = textBox2.Text;
                nRow[4] = textBox3.Text;
                nRow[5] = textBox4.Text;

                main.qwe1DataSet.Tables[7].Rows.Add(nRow);
                main.фильмыTableAdapter.Update(main.qwe1DataSet.Фильмы);
                main.qwe1DataSet.Tables[7].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
        }
    }
}
