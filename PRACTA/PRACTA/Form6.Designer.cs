
namespace PRACTA
{
    partial class Form6
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
            this.работаБараBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qwe1DataSet = new PRACTA.qwe1DataSet();
            this.работа_бараTableAdapter = new PRACTA.qwe1DataSetTableAdapters.Работа_бараTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникиTableAdapter = new PRACTA.qwe1DataSetTableAdapters.СотрудникиTableAdapter();
            this.товарBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.товарTableAdapter = new PRACTA.qwe1DataSetTableAdapters.ТоварTableAdapter();
            this.иДDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Сотрудник = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Товар = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.количествоКупленногоТовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаТоваровDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаПокупкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.работаБараBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qwe1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.иДDataGridViewTextBoxColumn,
            this.Сотрудник,
            this.Товар,
            this.количествоКупленногоТовараDataGridViewTextBoxColumn,
            this.суммаТоваровDataGridViewTextBoxColumn,
            this.датаПокупкиDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.работаБараBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 349);
            this.dataGridView1.TabIndex = 0;
            // 
            // работаБараBindingSource
            // 
            this.работаБараBindingSource.DataMember = "Работа бара";
            this.работаБараBindingSource.DataSource = this.qwe1DataSet;
            // 
            // qwe1DataSet
            // 
            this.qwe1DataSet.DataSetName = "qwe1DataSet";
            this.qwe1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // работа_бараTableAdapter
            // 
            this.работа_бараTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавление";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(354, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Сохранение";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(645, 386);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Поиск";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this.qwe1DataSet;
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // товарBindingSource
            // 
            this.товарBindingSource.DataMember = "Товар";
            this.товарBindingSource.DataSource = this.qwe1DataSet;
            // 
            // товарTableAdapter
            // 
            this.товарTableAdapter.ClearBeforeFill = true;
            // 
            // иДDataGridViewTextBoxColumn
            // 
            this.иДDataGridViewTextBoxColumn.DataPropertyName = "ИД";
            this.иДDataGridViewTextBoxColumn.HeaderText = "ИД";
            this.иДDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.иДDataGridViewTextBoxColumn.Name = "иДDataGridViewTextBoxColumn";
            this.иДDataGridViewTextBoxColumn.Width = 125;
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
            // Товар
            // 
            this.Товар.DataPropertyName = "ИД_Товара";
            this.Товар.DataSource = this.товарBindingSource;
            this.Товар.DisplayMember = "Наименование";
            this.Товар.HeaderText = "Товар";
            this.Товар.MinimumWidth = 6;
            this.Товар.Name = "Товар";
            this.Товар.ValueMember = "ИД_Товара";
            this.Товар.Width = 125;
            // 
            // количествоКупленногоТовараDataGridViewTextBoxColumn
            // 
            this.количествоКупленногоТовараDataGridViewTextBoxColumn.DataPropertyName = "Количество купленного товара";
            this.количествоКупленногоТовараDataGridViewTextBoxColumn.HeaderText = "Количество купленного товара";
            this.количествоКупленногоТовараDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.количествоКупленногоТовараDataGridViewTextBoxColumn.Name = "количествоКупленногоТовараDataGridViewTextBoxColumn";
            this.количествоКупленногоТовараDataGridViewTextBoxColumn.Width = 125;
            // 
            // суммаТоваровDataGridViewTextBoxColumn
            // 
            this.суммаТоваровDataGridViewTextBoxColumn.DataPropertyName = "Сумма товаров";
            this.суммаТоваровDataGridViewTextBoxColumn.HeaderText = "Сумма товаров";
            this.суммаТоваровDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.суммаТоваровDataGridViewTextBoxColumn.Name = "суммаТоваровDataGridViewTextBoxColumn";
            this.суммаТоваровDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаПокупкиDataGridViewTextBoxColumn
            // 
            this.датаПокупкиDataGridViewTextBoxColumn.DataPropertyName = "Дата покупки";
            this.датаПокупкиDataGridViewTextBoxColumn.HeaderText = "Дата покупки";
            this.датаПокупкиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаПокупкиDataGridViewTextBoxColumn.Name = "датаПокупкиDataGridViewTextBoxColumn";
            this.датаПокупкиDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.работаБараBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qwe1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public qwe1DataSet qwe1DataSet;
        public System.Windows.Forms.BindingSource работаБараBindingSource;
        public qwe1DataSetTableAdapters.Работа_бараTableAdapter работа_бараTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private qwe1DataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private System.Windows.Forms.BindingSource товарBindingSource;
        private qwe1DataSetTableAdapters.ТоварTableAdapter товарTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn иДDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Сотрудник;
        private System.Windows.Forms.DataGridViewComboBoxColumn Товар;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоКупленногоТовараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаТоваровDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаПокупкиDataGridViewTextBoxColumn;
    }
}