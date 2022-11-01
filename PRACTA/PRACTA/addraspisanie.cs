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
    public partial class addraspisanie : Form
    {
        public addraspisanie()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 main = this.Owner as Form5;
            if (main != null)
            {
                DataRow nRow = main.qwe1DataSet.Tables[4].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[2] = dateTimePicker1.Text;
                nRow[3] = textBox1.Text;
                nRow[4] = textBox2.Text;
                main.qwe1DataSet.Tables[4].Rows.Add(nRow);
                main.расписаниеTableAdapter.Update(main.qwe1DataSet.Расписание);
                main.qwe1DataSet.Tables[4].AcceptChanges();
                main.dataGridView1.Refresh();
                dateTimePicker1.Text = "";
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }
    }
}   
