namespace finalKT
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fin2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fin2DataSet = new finalKT.fin2DataSet();
            this.fBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fin1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonCansel = new System.Windows.Forms.Button();
            this.fBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fTableAdapter1 = new finalKT.fin2DataSetTableAdapters.FTableAdapter();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.fBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.паспортDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.модельАвтомобиляDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.цветАвтомобиляDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.годВыпускаАвтомобиляDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.госНомерАвтомобиляDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоДнейПрокатаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.страховаяСтоимостьАвтомобиляDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаНачалаПрокатаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьДняDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fin2DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fin2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fin1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.фИОКлиентаDataGridViewTextBoxColumn,
            this.паспортDataGridViewTextBoxColumn,
            this.модельАвтомобиляDataGridViewTextBoxColumn,
            this.цветАвтомобиляDataGridViewTextBoxColumn,
            this.годВыпускаАвтомобиляDataGridViewTextBoxColumn,
            this.госНомерАвтомобиляDataGridViewTextBoxColumn,
            this.количествоДнейПрокатаDataGridViewTextBoxColumn,
            this.страховаяСтоимостьАвтомобиляDataGridViewTextBoxColumn,
            this.датаНачалаПрокатаDataGridViewTextBoxColumn,
            this.стоимостьДняDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fBindingSource3;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(1, 0);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(1146, 388);
            this.dataGridView1.TabIndex = 0;
            // 
            // fBindingSource2
            // 
            this.fBindingSource2.DataMember = "F";
            this.fBindingSource2.DataSource = this.fin2DataSetBindingSource;
            // 
            // fin2DataSetBindingSource
            // 
            this.fin2DataSetBindingSource.DataSource = this.fin2DataSet;
            this.fin2DataSetBindingSource.Position = 0;
            // 
            // fin2DataSet
            // 
            this.fin2DataSet.DataSetName = "fin2DataSet";
            this.fin2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fBindingSource
            // 
            this.fBindingSource.DataMember = "F";
            // 
            // fin1DataSetBindingSource
            // 
            this.fin1DataSetBindingSource.Position = 0;
            // 
            // fTableAdapter
            // 
            // buttonCansel
            // 
            this.buttonCansel.Location = new System.Drawing.Point(12, 415);
            this.buttonCansel.Name = "buttonCansel";
            this.buttonCansel.Size = new System.Drawing.Size(75, 23);
            this.buttonCansel.TabIndex = 1;
            this.buttonCansel.Text = "Удалить";
            this.buttonCansel.UseVisualStyleBackColor = true;
            this.buttonCansel.Click += new System.EventHandler(this.buttonCansel_Click);
            // 
            // fBindingSource1
            // 
            this.fBindingSource1.DataMember = "F";
            this.fBindingSource1.DataSource = this.fin2DataSet;
            // 
            // fTableAdapter1
            // 
            this.fTableAdapter1.ClearBeforeFill = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(110, 415);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(76, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // fBindingSource3
            // 
            this.fBindingSource3.DataMember = "F";
            this.fBindingSource3.DataSource = this.fin2DataSetBindingSource;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(212, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Редактировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            // 
            // фИОКлиентаDataGridViewTextBoxColumn
            // 
            this.фИОКлиентаDataGridViewTextBoxColumn.DataPropertyName = "ФИО Клиента";
            this.фИОКлиентаDataGridViewTextBoxColumn.HeaderText = "ФИО Клиента";
            this.фИОКлиентаDataGridViewTextBoxColumn.Name = "фИОКлиентаDataGridViewTextBoxColumn";
            // 
            // паспортDataGridViewTextBoxColumn
            // 
            this.паспортDataGridViewTextBoxColumn.DataPropertyName = "Паспорт";
            this.паспортDataGridViewTextBoxColumn.HeaderText = "Паспорт";
            this.паспортDataGridViewTextBoxColumn.Name = "паспортDataGridViewTextBoxColumn";
            // 
            // модельАвтомобиляDataGridViewTextBoxColumn
            // 
            this.модельАвтомобиляDataGridViewTextBoxColumn.DataPropertyName = "Модель автомобиля";
            this.модельАвтомобиляDataGridViewTextBoxColumn.HeaderText = "Модель автомобиля";
            this.модельАвтомобиляDataGridViewTextBoxColumn.Name = "модельАвтомобиляDataGridViewTextBoxColumn";
            // 
            // цветАвтомобиляDataGridViewTextBoxColumn
            // 
            this.цветАвтомобиляDataGridViewTextBoxColumn.DataPropertyName = "Цвет автомобиля";
            this.цветАвтомобиляDataGridViewTextBoxColumn.HeaderText = "Цвет автомобиля";
            this.цветАвтомобиляDataGridViewTextBoxColumn.Name = "цветАвтомобиляDataGridViewTextBoxColumn";
            // 
            // годВыпускаАвтомобиляDataGridViewTextBoxColumn
            // 
            this.годВыпускаАвтомобиляDataGridViewTextBoxColumn.DataPropertyName = "Год выпуска автомобиля";
            this.годВыпускаАвтомобиляDataGridViewTextBoxColumn.HeaderText = "Год выпуска автомобиля";
            this.годВыпускаАвтомобиляDataGridViewTextBoxColumn.Name = "годВыпускаАвтомобиляDataGridViewTextBoxColumn";
            // 
            // госНомерАвтомобиляDataGridViewTextBoxColumn
            // 
            this.госНомерАвтомобиляDataGridViewTextBoxColumn.DataPropertyName = "Гос номер автомобиля";
            this.госНомерАвтомобиляDataGridViewTextBoxColumn.HeaderText = "Гос номер автомобиля";
            this.госНомерАвтомобиляDataGridViewTextBoxColumn.Name = "госНомерАвтомобиляDataGridViewTextBoxColumn";
            // 
            // количествоДнейПрокатаDataGridViewTextBoxColumn
            // 
            this.количествоДнейПрокатаDataGridViewTextBoxColumn.DataPropertyName = "Количество дней проката";
            this.количествоДнейПрокатаDataGridViewTextBoxColumn.HeaderText = "Количество дней проката";
            this.количествоДнейПрокатаDataGridViewTextBoxColumn.Name = "количествоДнейПрокатаDataGridViewTextBoxColumn";
            // 
            // страховаяСтоимостьАвтомобиляDataGridViewTextBoxColumn
            // 
            this.страховаяСтоимостьАвтомобиляDataGridViewTextBoxColumn.DataPropertyName = "Страховая стоимость автомобиля";
            this.страховаяСтоимостьАвтомобиляDataGridViewTextBoxColumn.HeaderText = "Страховая стоимость автомобиля";
            this.страховаяСтоимостьАвтомобиляDataGridViewTextBoxColumn.Name = "страховаяСтоимостьАвтомобиляDataGridViewTextBoxColumn";
            // 
            // датаНачалаПрокатаDataGridViewTextBoxColumn
            // 
            this.датаНачалаПрокатаDataGridViewTextBoxColumn.DataPropertyName = "Дата начала проката";
            this.датаНачалаПрокатаDataGridViewTextBoxColumn.HeaderText = "Дата начала проката";
            this.датаНачалаПрокатаDataGridViewTextBoxColumn.Name = "датаНачалаПрокатаDataGridViewTextBoxColumn";
            // 
            // стоимостьДняDataGridViewTextBoxColumn
            // 
            this.стоимостьДняDataGridViewTextBoxColumn.DataPropertyName = "Стоимость дня";
            this.стоимостьДняDataGridViewTextBoxColumn.HeaderText = "Стоимость дня";
            this.стоимостьДняDataGridViewTextBoxColumn.Name = "стоимостьДняDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonCansel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fin2DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fin2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fin1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource fin1DataSetBindingSource;
        private System.Windows.Forms.BindingSource fBindingSource;
        private System.Windows.Forms.Button buttonCansel;
        private fin2DataSet fin2DataSet;
        private System.Windows.Forms.BindingSource fBindingSource1;
        private fin2DataSetTableAdapters.FTableAdapter fTableAdapter1;
        private System.Windows.Forms.BindingSource fBindingSource2;
        private System.Windows.Forms.BindingSource fin2DataSetBindingSource;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.BindingSource fBindingSource3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОКлиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn паспортDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn модельАвтомобиляDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn цветАвтомобиляDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn годВыпускаАвтомобиляDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn госНомерАвтомобиляDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоДнейПрокатаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn страховаяСтоимостьАвтомобиляDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаНачалаПрокатаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьДняDataGridViewTextBoxColumn;
    }
}

