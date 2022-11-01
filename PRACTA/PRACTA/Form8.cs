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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "qwe1DataSet.Формат". При необходимости она может быть перемещена или удалена.
            this.форматTableAdapter.Fill(this.qwe1DataSet.Формат);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            форматBindingSource.EndEdit();
            форматTableAdapter.Update(qwe1DataSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addformat af = new addformat();
            af.Owner = this;
            af.Show();
        }
    }
}
