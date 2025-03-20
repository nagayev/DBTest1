using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace DBTest1
{
    public partial class fmAddPAYOUT : Form
    {
        public string? data, sum;
        private SqliteConnection connection;
        public fmAddPAYOUT()
        {
            InitializeComponent();
        }

        public fmAddPAYOUT(string d, string s)
        {
            InitializeComponent();
            DateTime date = DateTime.ParseExact(d,"dd.MM.yy", System.Globalization.CultureInfo.InvariantCulture);
            dateTimePicker1.Value = date;
            sumvyplaty.Text = s;
            Text = "Изменить запись";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dateTime = dateTimePicker1.Value;
            //data = $"{dateTime.Day}.0{dateTime.Month}.{dateTime.Year}"; ;
            data = dateTime.ToString("dd.MM.yy");
            sum = sumvyplaty.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void fmAddPAYOUT_Load(object sender, EventArgs e)
        {
            /*connection = new SqliteConnection("Data Source=bd.db");
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

                        familiya.Items.Add(vidstip1.ToString());
                    }
                }
            }*/
        }

    }
}
