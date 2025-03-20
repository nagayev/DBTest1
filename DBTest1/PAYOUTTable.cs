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
using System.Data.SqlClient;

namespace DBTest1
{
    public partial class PAYOUTTable : Form
    {
        private SqliteConnection connection;
        private int autoincrementId;
        public PAYOUTTable()
        {
            InitializeComponent();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (vyplatyGridView.Rows.Count == 0)
            {
                MessageBox.Show("Невозможно удалить запись!", "Ошибка");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Удаление", "Удалить текущую запись", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DataGridViewRow Current = vyplatyGridView.CurrentRow;
                var studentId = studentGridView.CurrentRow.Cells[0].Value.ToString();
                var data = Current.Cells[1].Value.ToString();
                var sum = Current.Cells[2].Value.ToString();
                vyplatyGridView.Rows.RemoveAt(Current.Index);
                SqliteCommand command = new SqliteCommand();
                command.Connection = connection;
                command.CommandText = $"DELETE FROM VYPLATY WHERE NSTUDENT={studentId} AND DATAVYPLATY='{data}' AND SUMVYPLATY={sum}";
                int number = command.ExecuteNonQuery();
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (vyplatyGridView.Rows.Count == 0)
            {
                MessageBox.Show("Невозможно отредактировать запись!", "Ошибка");
                return;
            }
            //Вид стипендии, сумма
            string date = vyplatyGridView.SelectedRows[0].Cells[1].Value.ToString();
            string sum = vyplatyGridView.SelectedRows[0].Cells[2].Value.ToString();
            fmAddPAYOUT fmEditPAYOUT = new fmAddPAYOUT(date, sum);
            var result = fmEditPAYOUT.ShowDialog();
            if (result == DialogResult.OK)
            {
                date = fmEditPAYOUT.data;
                sum = fmEditPAYOUT.sum;
                var selectedRows = studentGridView.SelectedRows;
                if (selectedRows.Count == 0)
                {
                    MessageBox.Show("Ошибка", "Не выбран!");
                    return;
                }
                string number = vyplatyGridView.SelectedRows[0].Cells[0].Value.ToString();
                
                SqliteCommand command = new SqliteCommand();
                command.Connection = connection;
                command.CommandText = $"UPDATE VYPLATY SET DATAVYPLATY = '{date}', SUMVYPLATY = {sum} WHERE NVYPLATY = {number}";
                int number1 = command.ExecuteNonQuery();
                vyplatyGridView.SelectedRows[0].Cells[1].Value = date;
                vyplatyGridView.SelectedRows[0].Cells[2].Value = sum;

                //studentsGridView.Rows.Add(autoincrementId, FAMILIYA, IMYA, OTCHESTVO);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            fmAddPAYOUT payout = new fmAddPAYOUT();
            var result = payout.ShowDialog();
            if (result == DialogResult.OK)
            {
                string data = payout.data;            //values preserved after close
                string sum = payout.sum;
                var nstudent = studentGridView.SelectedRows[0].Cells[0].Value.ToString();
                //Do something here with these values
                SqliteCommand command = new SqliteCommand();
                command.Connection = connection;
                command.CommandText = $"INSERT INTO VYPLATY(DATAVYPLATY,SUMVYPLATY, NSTUDENT) VALUES ('{data}', {sum}, {nstudent})";
                int number = command.ExecuteNonQuery();
                //for example
                autoincrementId++;
                vyplatyGridView.Rows.Add(autoincrementId, data, sum);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            studentGridView.Rows.Clear();
            SqliteCommand command = new SqliteCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM STUDENT";

            using (SqliteDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read())   // построчно считываем данные
                    {
                        var id = reader.GetValue(0);
                        var fam = reader.GetValue(1);
                        var imya = reader.GetValue(2);
                        var otchestvo = reader.GetValue(3);

                        studentGridView.Rows.Add(id, fam, imya, otchestvo);
                    }
                }
            }
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PAYOUTTable_Load(object sender, EventArgs e)
        {
            connection = new SqliteConnection("Data Source=bd.db");
            connection.Open();
            updateButton_Click(sender, e);
            SqliteCommand command2 = new SqliteCommand();
            command2.Connection = connection;
            command2.CommandText = "SELECT seq FROM sqlite_sequence WHERE name='VIDSTIP'";
            using (SqliteDataReader reader = command2.ExecuteReader())
            {
                reader.Read();
                autoincrementId = int.Parse(reader.GetValue(0).ToString());
            }
        }

        private void studentGridView_SelectionChanged(object sender, EventArgs e)
        {
            var NSTUDENT = studentGridView.SelectedRows[0].Cells[0].Value;
            vyplatyGridView.Rows.Clear();
            SqliteCommand command = new SqliteCommand();
            command.Connection = connection;
            command.CommandText = $"SELECT NVYPLATY,DATAVYPLATY,SUMVYPLATY FROM VYPLATY WHERE NSTUDENT={NSTUDENT}";

            using (SqliteDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read())   // построчно считываем данные
                    {
                        var nvyplaty = reader.GetValue(0);
                        //var datavayplaty = Int32.Parse(reader.GetValue(1).ToString());
                        var date = reader.GetValue(1);
                        var sumvyplaty = reader.GetValue(2);
                        //Linux seconds to 19.03.25
                        //DateTime dateTime = DateTimeOffset.FromUnixTimeSeconds(datavayplaty).UtcDateTime;
                        //string date = $"{dateTime.Day}.0{dateTime.Month}.{dateTime.Year}";
                        vyplatyGridView.Rows.Add(nvyplaty, date, sumvyplaty);
                    }
                }
            }
        }
    }
}
