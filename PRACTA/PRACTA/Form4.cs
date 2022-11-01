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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "qwe1DataSet.Формат". При необходимости она может быть перемещена или удалена.
            this.форматTableAdapter.Fill(this.qwe1DataSet.Формат);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "qwe1DataSet.Фильмы". При необходимости она может быть перемещена или удалена.
            this.фильмыTableAdapter.Fill(this.qwe1DataSet.Фильмы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "qwe1DataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.qwe1DataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "qwe1DataSet.Покупка_билета". При необходимости она может быть перемещена или удалена.
            this.покупка_билетаTableAdapter.Fill(this.qwe1DataSet.Покупка_билета);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Addbilet af = new Addbilet();
            af.Owner = this;
            af.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            покупкаБилетаBindingSource.EndEdit();
            покупка_билетаTableAdapter.Update(qwe1DataSet);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Poiscbilet sf = new Poiscbilet();
            sf.Owner = this;
            sf.Show();
        }
    }
}
