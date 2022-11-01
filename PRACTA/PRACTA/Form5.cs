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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "qwe1DataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.qwe1DataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "qwe1DataSet.Формат". При необходимости она может быть перемещена или удалена.
            this.форматTableAdapter.Fill(this.qwe1DataSet.Формат);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "qwe1DataSet.Фильмы". При необходимости она может быть перемещена или удалена.
            this.фильмыTableAdapter.Fill(this.qwe1DataSet.Фильмы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "qwe1DataSet.Расписание". При необходимости она может быть перемещена или удалена.
            this.расписаниеTableAdapter.Fill(this.qwe1DataSet.Расписание);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            расписаниеBindingSource.EndEdit();
            расписаниеTableAdapter.Update(qwe1DataSet);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            poiscraspisanie sf = new poiscraspisanie();
            sf.Owner = this;
            sf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addraspisanie af = new addraspisanie();
            af.Owner = this;
            af.Show();
        }
    }
}
