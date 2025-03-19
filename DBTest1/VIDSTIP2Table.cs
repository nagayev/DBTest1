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
    public partial class VIDSTIP2Table : Form
    {
        private SqliteConnection connection;
        private int autoincrementId;
        public VIDSTIP2Table()
        {
            InitializeComponent();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Удаление", "Удалить текущую запись", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DataGridViewRow Current = vidstipGridView.CurrentRow;
                var studentId = studentGridView.CurrentRow.Cells[0].Value.ToString();
                var nvidStr = Current.Cells[0].Value.ToString();
                vidstipGridView.Rows.RemoveAt(Current.Index);
                SqliteCommand command = new SqliteCommand();
                command.Connection = connection;
                command.CommandText = $"DELETE FROM STIPENDIYA WHERE NSTUDENT={studentId} AND NVID=(SELECT NVID FROM VIDSTIP WHERE VIDSTIP='{nvidStr}')";
                int number = command.ExecuteNonQuery();
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            //Вид стипендии, сумма
            string vid = vidstipGridView.SelectedRows[0].Cells[0].Value.ToString();
            string sum = vidstipGridView.SelectedRows[0].Cells[1].Value.ToString();
            fmEditVIDSTIP2 fmEditVIDSTIP2 = new fmEditVIDSTIP2(vid, sum);
            var result = fmEditVIDSTIP2.ShowDialog();
            if (result == DialogResult.OK)
            {
                var selectedRows = studentGridView.SelectedRows;
                if (selectedRows.Count == 0)
                {
                    MessageBox.Show("Ошибка", "Не выбран!");
                    return;
                }
                string NVID_s = selectedRows[0].Cells[0].Value.ToString();
                int NVID = Int32.Parse(NVID_s);
                string VIDSTIP = fmEditVIDSTIP2.VIDSTIP;            //values preserved after close
                string nstudent = selectedRows[0].Cells[0].Value.ToString(); //FIXME
                string oldVIDSTIP = vid;
                SqliteCommand command = new SqliteCommand();
                command.Connection = connection;
                command.CommandText = $"UPDATE STIPENDIYA SET NSTUDENT = {nstudent}, NVID = (SELECT NVID FROM VIDSTIP WHERE VIDSTIP='{VIDSTIP}') WHERE NVID=(SELECT NVID FROM VIDSTIP WHERE VIDSTIP='{oldVIDSTIP}')";
                int number = command.ExecuteNonQuery();
                vidstipGridView.SelectedRows[0].Cells[0].Value = VIDSTIP;
                vidstipGridView.SelectedRows[0].Cells[1].Value = SUMSTIP;

                //studentsGridView.Rows.Add(autoincrementId, FAMILIYA, IMYA, OTCHESTVO);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            fmAddVIDSTIP2 fmVidStip2 = new fmAddVIDSTIP2();
            var result = fmVidStip2.ShowDialog();
            if (result == DialogResult.OK)
            {
                string VIDSTIP = fmVidStip2.VIDSTIP;            //values preserved after close
                string SUMSTIP = fmVidStip2.SUMSTIP;
                var nstudent = studentGridView.SelectedRows[0].Cells[0].Value.ToString();
                //Do something here with these values
                SqliteCommand command = new SqliteCommand();
                command.Connection = connection;
                command.CommandText = $"INSERT INTO STIPENDIYA(NSTUDENT,NVID) VALUES ({nstudent}, (SELECT NVID FROM VIDSTIP WHERE VIDSTIP='{VIDSTIP}'))";
                int number = command.ExecuteNonQuery();
                //for example
                autoincrementId++;
                vidstipGridView.Rows.Add(VIDSTIP, SUMSTIP);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            studentGridView.Rows.Clear();
            SqliteCommand command = new SqliteCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM VIDSTIP";

            using (SqliteDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read())   // построчно считываем данные
                    {
                        var nvid = reader.GetValue(0);
                        var vidstip = reader.GetValue(1);
                        var sumstip = reader.GetValue(2);

                        vidstipGridView.Rows.Add(nvid, vidstip, sumstip);
                    }
                }
            }
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VIDSTIP2Table_Load(object sender, EventArgs e)
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

        private void vidstipGridView_SelectionChanged(object sender, EventArgs e)
        {
            studentGridView.Rows.Clear();
            SqliteCommand command = new SqliteCommand();
            command.Connection = connection;
            var nvid = vidstipGridView.SelectedRows[0].Cells[0].Value;
            //Нужно выбрать студентов, которые получают например повышенную стипендию (т.е стипендию с определенным номером)
            command.CommandText = $"SELECT FAMILIYA,IMYA,OTCHESTVO FROM STUDENT WHERE NSTUDENT IN (SELECT NSTUDENT FROM STIPENDIYA WHERE NVID={nvid})";

            using (SqliteDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read())   // построчно считываем данные
                    {
                        var fam = reader.GetValue(0);
                        var im = reader.GetValue(1);
                        var otch = reader.GetValue(2);

                        studentGridView.Rows.Add(fam, im, otch);
                    }
                }
            }
        }

    }
}
