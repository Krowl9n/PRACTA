﻿using System;
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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "qwe1DataSet.Должности". При необходимости она может быть перемещена или удалена.
            this.должностиTableAdapter.Fill(this.qwe1DataSet.Должности);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "qwe1DataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.qwe1DataSet.Сотрудники);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addsotrudnik af = new addsotrudnik();
            af.Owner = this;
            af.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            сотрудникиBindingSource.EndEdit();
            сотрудникиTableAdapter.Update(qwe1DataSet);
        }
    }
}
