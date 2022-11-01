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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "qwe1DataSet.Должности". При необходимости она может быть перемещена или удалена.
            this.должностиTableAdapter.Fill(this.qwe1DataSet.Должности);

        }

        private void button1_Click(object sender, EventArgs e)
        {
                Form11 af = new Form11();
                af.Owner = this;
                af.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            должностиBindingSource.EndEdit();
            должностиTableAdapter.Update(qwe1DataSet);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Poisc_doljnostei sf = new Poisc_doljnostei();
            sf.Owner = this;
            sf.Show();
        }
    }
}
