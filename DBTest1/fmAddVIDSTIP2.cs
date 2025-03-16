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
    public partial class fmAddVIDSTIP2 : Form
    {
        public string? VIDSTIP, SUMSTIP;
        private SqliteConnection connection;
        public fmAddVIDSTIP2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VIDSTIP = vidstip.Text;
            SUMSTIP = sumstip.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void fmAddVIDSTIP2_Load(object sender, EventArgs e)
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

        private void vidstip_SelectedValueChanged(object sender, EventArgs e)
        {
            var tmp = vidstip.SelectedItem.ToString();
            SqliteCommand command = new SqliteCommand();
            command.Connection = connection;
            command.CommandText = $"SELECT SUMSTIP FROM VIDSTIP WHERE VIDSTIP='{tmp}'";

            using (SqliteDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read())   // построчно считываем данные
                    {
                        var sumstip1 = reader.GetValue(0);

                        sumstip.Text = sumstip1.ToString();
                    }
                }
            }
        }
    }
}
