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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "qwe1DataSet.Жанры". При необходимости она может быть перемещена или удалена.
            this.жанрыTableAdapter.Fill(this.qwe1DataSet.Жанры);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "qwe1DataSet.Фильмы". При необходимости она может быть перемещена или удалена.
            this.фильмыTableAdapter.Fill(this.qwe1DataSet.Фильмы);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            фильмыBindingSource.EndEdit();
            фильмыTableAdapter.Update(qwe1DataSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addfilm af = new addfilm();
            af.Owner = this;
            af.Show();
        }
    }
}
