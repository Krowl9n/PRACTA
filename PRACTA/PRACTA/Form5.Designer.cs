
namespace PRACTA
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.иДDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.деньDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Фильм = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.фильмыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qwe1DataSet = new PRACTA.qwe1DataSet();
            this.залDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Формат = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.форматBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Сотрудник = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.расписаниеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.расписаниеTableAdapter = new PRACTA.qwe1DataSetTableAdapters.РасписаниеTableAdapter();
            this.фильмыTableAdapter = new PRACTA.qwe1DataSetTableAdapters.ФильмыTableAdapter();
            this.форматTableAdapter = new PRACTA.qwe1DataSetTableAdapters.ФорматTableAdapter();
            this.сотрудникиTableAdapter = new PRACTA.qwe1DataSetTableAdapters.СотрудникиTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фильмыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qwe1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.форматBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.расписаниеBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.иДDataGridViewTextBoxColumn,
            this.деньDataGridViewTextBoxColumn,
            this.Фильм,
            this.залDataGridViewTextBoxColumn,
            this.времяDataGridViewTextBoxColumn,
            this.Формат,
            this.Сотрудник});
            this.dataGridView1.DataSource = this.расписаниеBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 344);
            this.dataGridView1.TabIndex = 0;
            // 
            // иДDataGridViewTextBoxColumn
            // 
            this.иДDataGridViewTextBoxColumn.DataPropertyName = "ИД";
            this.иДDataGridViewTextBoxColumn.HeaderText = "ИД";
            this.иДDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.иДDataGridViewTextBoxColumn.Name = "иДDataGridViewTextBoxColumn";
            this.иДDataGridViewTextBoxColumn.Width = 125;
            // 
            // деньDataGridViewTextBoxColumn
            // 
            this.деньDataGridViewTextBoxColumn.DataPropertyName = "День";
            this.деньDataGridViewTextBoxColumn.HeaderText = "День";
            this.деньDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.деньDataGridViewTextBoxColumn.Name = "деньDataGridViewTextBoxColumn";
            this.деньDataGridViewTextBoxColumn.Width = 125;
            // 
            // Фильм
            // 
            this.Фильм.DataPropertyName = "ИД_Фильма";
            this.Фильм.DataSource = this.фильмыBindingSource;
            this.Фильм.DisplayMember = "Название";
            this.Фильм.HeaderText = "Фильм";
            this.Фильм.MinimumWidth = 6;
            this.Фильм.Name = "Фильм";
            this.Фильм.ValueMember = "ИД_Фильма";
            this.Фильм.Width = 125;
            // 
            // фильмыBindingSource
            // 
            this.фильмыBindingSource.DataMember = "Фильмы";
            this.фильмыBindingSource.DataSource = this.qwe1DataSet;
            // 
            // qwe1DataSet
            // 
            this.qwe1DataSet.DataSetName = "qwe1DataSet";
            this.qwe1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // залDataGridViewTextBoxColumn
            // 
            this.залDataGridViewTextBoxColumn.DataPropertyName = "Зал";
            this.залDataGridViewTextBoxColumn.HeaderText = "Зал";
            this.залDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.залDataGridViewTextBoxColumn.Name = "залDataGridViewTextBoxColumn";
            this.залDataGridViewTextBoxColumn.Width = 125;
            // 
            // времяDataGridViewTextBoxColumn
            // 
            this.времяDataGridViewTextBoxColumn.DataPropertyName = "Время";
            this.времяDataGridViewTextBoxColumn.HeaderText = "Время";
            this.времяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.времяDataGridViewTextBoxColumn.Name = "времяDataGridViewTextBoxColumn";
            this.времяDataGridViewTextBoxColumn.Width = 125;
            // 
            // Формат
            // 
            this.Формат.DataPropertyName = "ИД_Формата";
            this.Формат.DataSource = this.форматBindingSource;
            this.Формат.DisplayMember = "Наименование";
            this.Формат.HeaderText = "Фортмат";
            this.Формат.MinimumWidth = 6;
            this.Формат.Name = "Формат";
            this.Формат.ValueMember = "ИД_Формата";
            this.Формат.Width = 125;
            // 
            // форматBindingSource
            // 
            this.форматBindingSource.DataMember = "Формат";
            this.форматBindingSource.DataSource = this.qwe1DataSet;
            // 
            // Сотрудник
            // 
            this.Сотрудник.DataPropertyName = "ИД_Сотрудника";
            this.Сотрудник.DataSource = this.сотрудникиBindingSource;
            this.Сотрудник.DisplayMember = "Фамилия";
            this.Сотрудник.HeaderText = "Сотрудник";
            this.Сотрудник.MinimumWidth = 6;
            this.Сотрудник.Name = "Сотрудник";
            this.Сотрудник.ValueMember = "ИД_Сотрудника";
            this.Сотрудник.Width = 125;
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this.qwe1DataSet;
            // 
            // расписаниеBindingSource
            // 
            this.расписаниеBindingSource.DataMember = "Расписание";
            this.расписаниеBindingSource.DataSource = this.qwe1DataSet;
            // 
            // расписаниеTableAdapter
            // 
            this.расписаниеTableAdapter.ClearBeforeFill = true;
            // 
            // фильмыTableAdapter
            // 
            this.фильмыTableAdapter.ClearBeforeFill = true;
            // 
            // форматTableAdapter
            // 
            this.форматTableAdapter.ClearBeforeFill = true;
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавление";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(354, 376);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(625, 376);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Поиск";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фильмыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qwe1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.форматBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.расписаниеBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public qwe1DataSet qwe1DataSet;
        public System.Windows.Forms.BindingSource расписаниеBindingSource;
        public qwe1DataSetTableAdapters.РасписаниеTableAdapter расписаниеTableAdapter;
        private System.Windows.Forms.BindingSource фильмыBindingSource;
        private qwe1DataSetTableAdapters.ФильмыTableAdapter фильмыTableAdapter;
        private System.Windows.Forms.BindingSource форматBindingSource;
        private qwe1DataSetTableAdapters.ФорматTableAdapter форматTableAdapter;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private qwe1DataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn иДDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn деньDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Фильм;
        private System.Windows.Forms.DataGridViewTextBoxColumn залDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Формат;
        private System.Windows.Forms.DataGridViewComboBoxColumn Сотрудник;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}