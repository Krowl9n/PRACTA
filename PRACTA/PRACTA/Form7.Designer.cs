
namespace PRACTA
{
    partial class Form7
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
            this.жанрыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qwe1DataSet = new PRACTA.qwe1DataSet();
            this.фильмыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.фильмыTableAdapter = new PRACTA.qwe1DataSetTableAdapters.ФильмыTableAdapter();
            this.жанрыTableAdapter = new PRACTA.qwe1DataSetTableAdapters.ЖанрыTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.иДФильмаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Жанр = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.длительностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.годВыпускаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.возврастноеОграниченияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.жанрыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qwe1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фильмыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.иДФильмаDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.Жанр,
            this.длительностьDataGridViewTextBoxColumn,
            this.годВыпускаDataGridViewTextBoxColumn,
            this.возврастноеОграниченияDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.фильмыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 348);
            this.dataGridView1.TabIndex = 0;
            // 
            // жанрыBindingSource
            // 
            this.жанрыBindingSource.DataMember = "Жанры";
            this.жанрыBindingSource.DataSource = this.qwe1DataSet;
            // 
            // qwe1DataSet
            // 
            this.qwe1DataSet.DataSetName = "qwe1DataSet";
            this.qwe1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // фильмыBindingSource
            // 
            this.фильмыBindingSource.DataMember = "Фильмы";
            this.фильмыBindingSource.DataSource = this.qwe1DataSet;
            // 
            // фильмыTableAdapter
            // 
            this.фильмыTableAdapter.ClearBeforeFill = true;
            // 
            // жанрыTableAdapter
            // 
            this.жанрыTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(516, 396);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // иДФильмаDataGridViewTextBoxColumn
            // 
            this.иДФильмаDataGridViewTextBoxColumn.DataPropertyName = "ИД_Фильма";
            this.иДФильмаDataGridViewTextBoxColumn.HeaderText = "ИД_Фильма";
            this.иДФильмаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.иДФильмаDataGridViewTextBoxColumn.Name = "иДФильмаDataGridViewTextBoxColumn";
            this.иДФильмаDataGridViewTextBoxColumn.Width = 125;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            this.названиеDataGridViewTextBoxColumn.Width = 125;
            // 
            // Жанр
            // 
            this.Жанр.DataPropertyName = "ИД_Жанра";
            this.Жанр.DataSource = this.жанрыBindingSource;
            this.Жанр.DisplayMember = "Наименование";
            this.Жанр.HeaderText = "Жанр";
            this.Жанр.MinimumWidth = 6;
            this.Жанр.Name = "Жанр";
            this.Жанр.ValueMember = "ИД_Жанра";
            this.Жанр.Width = 125;
            // 
            // длительностьDataGridViewTextBoxColumn
            // 
            this.длительностьDataGridViewTextBoxColumn.DataPropertyName = "Длительность";
            this.длительностьDataGridViewTextBoxColumn.HeaderText = "Длительность";
            this.длительностьDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.длительностьDataGridViewTextBoxColumn.Name = "длительностьDataGridViewTextBoxColumn";
            this.длительностьDataGridViewTextBoxColumn.Width = 125;
            // 
            // годВыпускаDataGridViewTextBoxColumn
            // 
            this.годВыпускаDataGridViewTextBoxColumn.DataPropertyName = "Год выпуска";
            this.годВыпускаDataGridViewTextBoxColumn.HeaderText = "Год выпуска";
            this.годВыпускаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.годВыпускаDataGridViewTextBoxColumn.Name = "годВыпускаDataGridViewTextBoxColumn";
            this.годВыпускаDataGridViewTextBoxColumn.Width = 125;
            // 
            // возврастноеОграниченияDataGridViewTextBoxColumn
            // 
            this.возврастноеОграниченияDataGridViewTextBoxColumn.DataPropertyName = "Возврастное ограничения";
            this.возврастноеОграниченияDataGridViewTextBoxColumn.HeaderText = "Возврастное ограничения";
            this.возврастноеОграниченияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.возврастноеОграниченияDataGridViewTextBoxColumn.Name = "возврастноеОграниченияDataGridViewTextBoxColumn";
            this.возврастноеОграниченияDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.жанрыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qwe1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фильмыBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public qwe1DataSet qwe1DataSet;
        public System.Windows.Forms.BindingSource фильмыBindingSource;
        public qwe1DataSetTableAdapters.ФильмыTableAdapter фильмыTableAdapter;
        private System.Windows.Forms.BindingSource жанрыBindingSource;
        public qwe1DataSetTableAdapters.ЖанрыTableAdapter жанрыTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn иДФильмаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Жанр;
        private System.Windows.Forms.DataGridViewTextBoxColumn длительностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn годВыпускаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn возврастноеОграниченияDataGridViewTextBoxColumn;
    }
}