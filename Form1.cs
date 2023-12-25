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
            

        }

        private void buttonCansel_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Вы уверены, что хотите выполнить это действие?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Обрабатываем результат диалогового окна
            if (result != DialogResult.Yes)
            {
                return;
            }

            DataRowView currentRow = fBindingSource3.Current as DataRowView;

            int kod = int.Parse(currentRow.Row["Код"].ToString());

            string query = "DELETE FROM F WHERE Код = " + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Элемент удален!");
            Updated();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Owner = this;
            f.currentRow = null;
            f.Text = "Добавление";

            string query = "SELECT MAX(Код) FROM F";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            object result = command.ExecuteScalar();

            int lastCode = result == DBNull.Value ? 0 : Convert.ToInt32(result);

            f.code = lastCode + 1;

            f.ShowDialog();
            Updated();
        }

        void Updated()
        {
            this.fTableAdapter1.Fill(this.fin2DataSet.F);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Owner = this;
            f.currentRow = fBindingSource3.Current as DataRowView;
            f.Text = "Редактирование";
            f.ShowDialog();
            Updated();
        }
    }
}
