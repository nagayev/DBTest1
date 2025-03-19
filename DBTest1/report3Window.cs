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
    public partial class report3Window : Form
    {
        private SqliteConnection connection;
        public report3Window()
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
            var nstudent_value = 0;
            SqliteCommand command = new SqliteCommand();
            command.Connection = connection;
            command.CommandText = $"SELECT NSTUDENT FROM STUDENT WHERE FAMILIYA='{student.Text}'";

            using (SqliteDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read())   // построчно считываем данные
                    {
                        nstudent_value = int.Parse(reader.GetValue(0).ToString());
                    }
                }
            }
            // end
            Report report = new Report();

            // Создаем макет отчета
            report.Load("report3.frx");
            //vidstip_param, not student!
            report.SetParameterValue("vidstip_param", nstudent_value);

            // Печатаем отчет
            report.Show();
            this.Close();
        }

        private void report3Window_Load(object sender, EventArgs e)
        {
            connection = new SqliteConnection("Data Source=bd.db");
            connection.Open();
            //Заполняем combobox
            SqliteCommand command = new SqliteCommand();
            command.Connection = connection;
            command.CommandText = "SELECT FAMILIYA FROM STUDENT";

            using (SqliteDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read())   // построчно считываем данные
                    {
                        var fam = reader.GetValue(0);

                        student.Items.Add(fam.ToString());
                    }
                }
            }
        }
    }
}
