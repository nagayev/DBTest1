using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastReport;
using Microsoft.Data.Sqlite;

namespace DBTest1
{
    public partial class report2Window : Form
    {
        private SqliteConnection connection;
        public report2Window()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //start
            var vidstip_value = 0;
            SqliteCommand command = new SqliteCommand();
            command.Connection = connection;
            command.CommandText = $"SELECT NVID FROM VIDSTIP WHERE VIDSTIP='{vidstip.Text}'";

            using (SqliteDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read())   // построчно считываем данные
                    {
                        vidstip_value = int.Parse(reader.GetValue(0).ToString());
                    }
                }
            }
            // end
            //список студентов, получающих указанных вид стипендии
            //SELECT FAMILIYA,IMYA,OTCHESTVO FROM STUDENT WHERE NSTUDENT IN (SELECT NSTUDENT FROM STIPENDIYA WHERE NVID={vidstip_param})
            Report report = new Report();

            // Создаем макет отчета
            report.Load("report2.frx"); // Замените на путь к вашему файлу отчета
            report.SetParameterValue("vidstip_param", vidstip_value);

            // Печатаем отчет
            report.Show();
            this.Close();
        }

        private void report2Window_Load(object sender, EventArgs e)
        {
            connection = new SqliteConnection("Data Source=bd.db");
            connection.Open();
            //Заполняем combobox
            SqliteCommand command = new SqliteCommand();
            command.Connection = connection;
            command.CommandText = "SELECT VIDSTIP FROM VIDSTIP";

            using (SqliteDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read())   // построчно считываем данные
                    {
                        var vidstip1 = reader.GetValue(0);

                        vidstip.Items.Add(vidstip1.ToString());
                    }
                }
            }
        }
    }
}
