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
    public partial class fmAddVIDSTIP3 : Form
    {
        public string? nstudentId, familiya, imiya, otchestvo;
        private SqliteConnection connection;

        public fmAddVIDSTIP3()
        {
            InitializeComponent();
        }
        public fmAddVIDSTIP3(string id, string f, string i, string o)
        {
            InitializeComponent();
            Text = "Редактировать запись";
            FAMILIYA.Text = f;
            IMYA.Text = i;
            OTCHESTVO.Text = o;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nstudentId = NSTUDENT.Text;
            familiya = FAMILIYA.Text;
            imiya = IMYA.Text;
            otchestvo = OTCHESTVO.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void fmAddVIDSTIP3_Load(object sender, EventArgs e)
        {
            connection = new SqliteConnection("Data Source=bd.db");
            connection.Open();
            //Заполняем combobox
            SqliteCommand command = new SqliteCommand();
            command.Connection = connection;
            command.CommandText = "SELECT NSTUDENT FROM STUDENT";

            using (SqliteDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read())   // построчно считываем данные
                    {
                        var nstudent = reader.GetValue(0);

                        NSTUDENT.Items.Add(nstudent.ToString());
                    }
                }
            }
        }

        private void vidstip_SelectedValueChanged(object sender, EventArgs e)
        {
            var tmp = NSTUDENT.SelectedItem.ToString();
            SqliteCommand command = new SqliteCommand();
            command.Connection = connection;
            command.CommandText = $"SELECT FAMILIYA,IMYA,OTCHESTVO FROM STUDENT WHERE NSTUDENT='{tmp}'";

            using (SqliteDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read())   // построчно считываем данные
                    {
                        var fam = reader.GetValue(0);
                        var im = reader.GetValue(1);
                        var otch = reader.GetValue(2);

                        FAMILIYA.Text = fam.ToString();
                        IMYA.Text = im.ToString();
                        OTCHESTVO.Text = otch.ToString();
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sumstip_Click(object sender, EventArgs e)
        {

        }

        private void NSTUDENT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
