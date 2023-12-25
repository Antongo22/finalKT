using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace finalKT
{
    public partial class Form2 : Form
    {
        public DataRowView currentRow;
        private OleDbConnection myConnection;

        public int code;


        public Form2()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(Form1.connectString);
            myConnection.Open();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = code.ToString();

            if (currentRow != null)
            {
                textBox1.Text = currentRow.Row["Код"].ToString();
                textBox2.Text = currentRow.Row["ФИО Клиента"].ToString();
                textBox3.Text = currentRow.Row["Паспорт"].ToString();
                textBox4.Text = currentRow.Row["Модель автомобиля"].ToString();
                textBox5.Text = currentRow.Row["Цвет автомобиля"].ToString();
                dateTimePicker1.Text = currentRow.Row["Год выпуска автомобиля"].ToString();
                textBox6.Text = currentRow.Row["Гос номер автомобиля"].ToString();
                textBox7.Text = currentRow.Row["Страховая стоимость автомобиля"].ToString();
                textBox8.Text = currentRow.Row["Стоимость дня"].ToString();
                dateTimePicker2.Text = currentRow.Row["Дата начала проката"].ToString();
                textBox9.Text = currentRow.Row["Количество дней проката"].ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string FIO = textBox2.Text.Trim();
            string pasport = textBox3.Text.Trim();
            string model = textBox4.Text.Trim();
            string color = textBox5.Text.Trim();
            string dateO = dateTimePicker1.Value.ToString();
            string gosNum = textBox6.Text.Trim();
            int sSum = int.Parse(textBox7.Text);
            int dSum = int.Parse(textBox8.Text);
            string dateG = dateTimePicker2.Value.ToString();
            int days = int.Parse(textBox9.Text);

            string query = null;
            if (currentRow == null)
            {

                query = "INSERT INTO F (Код, [ФИО Клиента], Паспорт, [Модель автомобиля], [Цвет автомобиля], [Год выпуска автомобиля]," +
               "[Гос номер автомобиля], [Страховая стоимость автомобиля], [Стоимость дня], [Дата начала проката], [Количество дней проката]) VALUES (" + code + ", '" + FIO + "', '" + pasport + "', '" +
               model + "', " + color + ", '" + dateO + "', " + gosNum + ", " + sSum + ", '" + dSum + "', '" + days + "')";

            }
            else
            {
                query = "UPDATE F SET " +
                "[ФИО Клиента] = '" + FIO + "', " +
                "Паспорт = '" + pasport + "', " +
                "[Модель автомобиля] = '" + model + "', " +
                "[Цвет автомобиля] = '" + color + "', " +
                "[Год выпуска автомобиля] = '" + dateO + "', " +
                "[Гос номер автомобиля] = '" + gosNum + "', " +
                "[Страховая стоимость автомобиля] = " + sSum + ", " +
                "[Стоимость дня] = '" + dSum + "', " +
                "[Дата начала проката] = '" + dateG + "', " +
                "[Количество дней проката] = " + days +
                " WHERE Код = " + code;

            }
            OleDbCommand comand = new OleDbCommand(query, myConnection);
            comand.ExecuteNonQuery();
            Close();
        }
    }
}
