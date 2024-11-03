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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace DBTest1
{
    public partial class StudentTable : Form
    {
        private SqliteConnection connection;
        private int autoincrementId;
        public StudentTable()
        {
            InitializeComponent();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow Current = studentsGridView.CurrentRow;
            var id = Current.Cells[0].Value.ToString();
            studentsGridView.Rows.RemoveAt(Current.Index);
            SqliteCommand command = new SqliteCommand();
            command.Connection = connection;
            command.CommandText = "DELETE FROM STUDENT WHERE NSTUDENT="+id;
            int number = command.ExecuteNonQuery();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            fmEditSTUDENT fmEditSTUDENT = new fmEditSTUDENT();
            fmEditSTUDENT.Show();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            fmAddSTUDENT fmAddSTUDENT = new fmAddSTUDENT();
            var result = fmAddSTUDENT.ShowDialog();
            if (result == DialogResult.OK)
            {
                string FAMILIYA = fmAddSTUDENT.FAMILYA;            //values preserved after close
                string IMYA = fmAddSTUDENT.IMYA;
                string OTCHESTVO = fmAddSTUDENT.OTCHESTVO;
                //Do something here with these values
                SqliteCommand command = new SqliteCommand();
                command.Connection = connection;
                command.CommandText = $"INSERT INTO STUDENT(FAMILIYA,IMYA,OTCHESTVO) VALUES ('{FAMILIYA}', '{IMYA}', '{OTCHESTVO}')";
                MessageBox.Show(command.CommandText,"a");
                int number = command.ExecuteNonQuery();
                //for example
                autoincrementId++;
                studentsGridView.Rows.Add(autoincrementId, FAMILIYA, IMYA, OTCHESTVO);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            studentsGridView.Rows.Clear();
            SqliteCommand command = new SqliteCommand();
            command.Connection = connection;
            /*command.CommandText = "INSERT INTO STUDENT(FAMILIYA, IMYA, OTCHESTVO) VALUES ('Nagayev', 'Marat', 'Timurovich') ";
            int number = command.ExecuteNonQuery();*/
            command.CommandText = "SELECT * FROM STUDENT";
            using (SqliteDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read())   // построчно считываем данные
                    {
                        var id = reader.GetValue(0);
                        var fam = reader.GetValue(1);
                        var name = reader.GetValue(2);
                        var otch = reader.GetValue(3);

                        studentsGridView.Rows.Add(id, fam, name, otch);
                    }
                }
            }
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StudentTable_Load(object sender, EventArgs e)
        {
            connection = new SqliteConnection("Data Source=bd.db");
            connection.Open();
            updateButton_Click(sender, e);
            SqliteCommand command2 = new SqliteCommand();
            command2.Connection = connection;
            command2.CommandText = "SELECT seq FROM sqlite_sequence WHERE name='STUDENT'";
            using (SqliteDataReader reader = command2.ExecuteReader())
            {
                reader.Read();
                autoincrementId = int.Parse(reader.GetValue(0).ToString());
            }
        }
    }
}
