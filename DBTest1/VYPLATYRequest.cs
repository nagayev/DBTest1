﻿using System;
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
            //seconds, not js ms
            long p = ((DateTimeOffset)fromDate).ToUnixTimeSeconds();
            MessageBox.Show(p.ToString(),"a");
            var selected = famCombo.SelectedValue;
            long unixTime = ((DateTimeOffset)fromDate).ToUnixTimeSeconds();
            if (selected == null)
            {
                MessageBox.Show("Некорректно введены данные", "Ошибка");
                return;
            }
            vyplatyGridView.Rows.Clear();
            string fam = selected.ToString();
            SqliteCommand command = new SqliteCommand();
            command.Connection = connection;
            int min, max;
            try
            {
                min = 2000;
                max = 5000;
                /*min = Int32.Parse(minTextbox.Text);
                max = Int32.Parse(maxTextBox.Text);*/
            }
            catch
            {
                MessageBox.Show("Ошибка", "Некорректно введены данные");
                return;
            }
            command.CommandText = $"SELECT VIDSTIP,SUMSTIP FROM VIDSTIP WHERE SUMSTIP BETWEEN {min} AND {max}";
            using (SqliteDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read())   // построчно считываем данные
                    {
                        var vidstip = reader.GetValue(0);
                        var sumstip = reader.GetValue(1);

                        vyplatyGridView.Rows.Add(vidstip, sumstip);
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
