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
    public partial class VIDSTIPRequest : Form
    {
        private SqliteConnection connection;
        public VIDSTIPRequest()
        {
            InitializeComponent();
        }


        private void updateButton_Click(object sender, EventArgs e)
        {
            vidstipGridView.Rows.Clear();
            SqliteCommand command = new SqliteCommand();
            command.Connection = connection;
            int min, max;
            try
            {
                min = Int32.Parse(minTextbox.Text);
                max = Int32.Parse(maxTextBox.Text);
            }
            catch {
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

                        vidstipGridView.Rows.Add(vidstip, sumstip);
                    }
                }
            }
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VIDSTIPRequest_Load(object sender, EventArgs e)
        {
            connection = new SqliteConnection("Data Source=bd.db");
            connection.Open();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maxTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
