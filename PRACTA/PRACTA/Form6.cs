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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "qwe1DataSet.Товар". При необходимости она может быть перемещена или удалена.
            this.товарTableAdapter.Fill(this.qwe1DataSet.Товар);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "qwe1DataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.qwe1DataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "qwe1DataSet.Работа_бара". При необходимости она может быть перемещена или удалена.
            this.работа_бараTableAdapter.Fill(this.qwe1DataSet.Работа_бара);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            работаБараBindingSource.EndEdit();
            работа_бараTableAdapter.Update(qwe1DataSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addrabotabar af = new addrabotabar();
            af.Owner = this;
            af.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            poiscbar sf = new poiscbar();
            sf.Owner = this;
            sf.Show();
        }
    }
}
