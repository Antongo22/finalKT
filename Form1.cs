using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalKT
{
    public partial class Form1 : Form
    {
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\anton\\Desktop\\Полезные файлы\\Учёба\\ITHub\\csharp\\finalKT\\finalKT\\fin2.mdb\"";
        private OleDbConnection myConnection;

        public Form1()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fin2DataSet.F". При необходимости она может быть перемещена или удалена.
            this.fTableAdapter1.Fill(this.fin2DataSet.F);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fin1DataSet.F". При необходимости она может быть перемещена или удалена.
            this.fTableAdapter.Fill(this.fin1DataSet.F);

        }

        private void buttonCansel_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Вы уверены, что хотите выполнить это действие?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Обрабатываем результат диалогового окна
            if (result != DialogResult.Yes)
            {
                return;
            }

            DataRowView currentRow = fBindingSource.Current as DataRowView;

            int kod = int.Parse(currentRow.Row["Код"].ToString());

            string query = "DELETE FROM Студенты WHERE Код = " + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Элемент удален!");
            Update();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }

        void Update()
        {
            this.fTableAdapter1.Fill(this.fin2DataSet.F);
        }
    }
}
