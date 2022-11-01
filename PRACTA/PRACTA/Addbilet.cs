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
    public partial class Addbilet : Form
    {
        public Addbilet()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 main = this.Owner as Form4;
            if (main != null)
            {
                DataRow nRow = main.qwe1DataSet.Tables[2].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[4] = textBox1.Text;
                //nRow[2] = textBox2.Text;
                nRow[7] = dt.Text;
                nRow[5] = textBox4.Text;
                nRow[6] = textBox5.Text;
               
                main.qwe1DataSet.Tables[2].Rows.Add(nRow);
                main.покупка_билетаTableAdapter.Update(main.qwe1DataSet.Покупка_билета);
                main.qwe1DataSet.Tables[2].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox1.Text = "";  
                textBox4.Text = "";
                textBox5.Text = "";
                dt.Text = "";
            }
        }
    }
}
