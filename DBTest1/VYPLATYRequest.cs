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
    public partial class VYPLATYRequest : Form
    {
        private SqliteConnection connection;
        public VYPLATYRequest()
        {
            InitializeComponent();
        }


        private void updateButton_Click(object sender, EventArgs e)
        {
            DateTime fromDate = fromDatePicker.Value;
            DateTime toDate = toDatePicker.Value;
            string fam = famCombo.Text;
            vyplatyGridView.Rows.Clear();
            SqliteCommand command = new SqliteCommand();
            command.Connection = connection;
            //Костыль: фильтрация данных на клиенте
            command.CommandText = $"SELECT DATAVYPLATY,SUMVYPLATY FROM VYPLATY WHERE NSTUDENT=(SELECT NSTUDENT FROM STUDENT WHERE FAMILIYA='{fam}')";
            using (SqliteDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read())   // построчно считываем данные
                    {
                        var data = reader.GetValue(0).ToString();
                        var sum = reader.GetValue(1);
                        //Check data in period
                        DateTime d = DateTime.ParseExact(data, "dd.MM.yy", System.Globalization.CultureInfo.InvariantCulture);
                        if (d >= fromDate && d <= toDate) {
                            vyplatyGridView.Rows.Add(data, sum);
                        }
                    }
                }
            }
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VYPLATYRequest_Load(object sender, EventArgs e)
        {
            connection = new SqliteConnection("Data Source=bd.db");
            connection.Open();
            SqliteCommand command = new SqliteCommand();
            command.Connection = connection;
            command.CommandText = "SELECT FAMILIYA FROM STUDENT";
            using (SqliteDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    famCombo.Items.Add(reader.GetValue(0).ToString());
                }
                //autoincrementId = int.Parse(reader.GetValue(0).ToString());
            }

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
