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
                DataGridViewRow Current = studentGridView.CurrentRow;
                var studentId = studentGridView.CurrentRow.Cells[0].Value.ToString();
                var nvid = vidstipGridView.CurrentRow.Cells[0].Value.ToString();
                studentGridView.Rows.RemoveAt(Current.Index);
                SqliteCommand command = new SqliteCommand();
                command.Connection = connection;
                command.CommandText = $"DELETE FROM STIPENDIYA WHERE NSTUDENT={studentId} AND NVID={nvid}";
                int number = command.ExecuteNonQuery();
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            string oldid = studentGridView.SelectedRows[0].Cells[0].Value.ToString();
            string fam = studentGridView.SelectedRows[0].Cells[1].Value.ToString();
            string im = studentGridView.SelectedRows[0].Cells[2].Value.ToString();
            var otch = studentGridView.SelectedRows[0].Cells[3].Value.ToString();

            fmAddVIDSTIP3 fmEditVIDSTIP3 = new fmAddVIDSTIP3(oldid, fam, im,otch);
            var result = fmEditVIDSTIP3.ShowDialog();
            if (result == DialogResult.OK)
            {
                var selectedRows = vidstipGridView.SelectedRows;
                if (selectedRows.Count == 0)
                {
                    MessageBox.Show("Ошибка", "Не выбран!");
                    return;
                }
                string nstudentId = fmEditVIDSTIP3.nstudentId;
                string nvid = vidstipGridView.SelectedRows[0].Cells[0].Value.ToString();
                fam = fmEditVIDSTIP3.familiya;
                im = fmEditVIDSTIP3.imiya;
                otch = fmEditVIDSTIP3.otchestvo;
                SqliteCommand command = new SqliteCommand();
                command.Connection = connection;
                command.CommandText = $"UPDATE STIPENDIYA SET NSTUDENT = {nstudentId} WHERE NSTUDENT = {oldid} AND NVID = {nvid}";
                int number = command.ExecuteNonQuery();
                studentGridView.SelectedRows[0].Cells[1].Value = fam;
                studentGridView.SelectedRows[0].Cells[2].Value = im;
                studentGridView.SelectedRows[0].Cells[3].Value = otch;

                //studentsGridView.Rows.Add(autoincrementId, FAMILIYA, IMYA, OTCHESTVO);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            fmAddVIDSTIP3 fmVidStip3 = new fmAddVIDSTIP3();
            var result = fmVidStip3.ShowDialog();
            if (result == DialogResult.OK)
            {
                string nstudentId = fmVidStip3.nstudentId;            //values preserved after close
                string fam = fmVidStip3.familiya;
                string im = fmVidStip3.imiya;
                string otch = fmVidStip3.otchestvo;
                string nvid = vidstipGridView.SelectedRows[0].Cells[0].Value.ToString();
                //Do something here with these values
                SqliteCommand command = new SqliteCommand();
                command.Connection = connection;
                command.CommandText = $"INSERT INTO STIPENDIYA(NSTUDENT,NVID) VALUES ({nstudentId}, {nvid})";
                int number = command.ExecuteNonQuery();
                //for example
                autoincrementId++;
                studentGridView.Rows.Add(nstudentId, fam, im, otch);
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
            command.CommandText = $"SELECT NSTUDENT,FAMILIYA,IMYA,OTCHESTVO FROM STUDENT WHERE NSTUDENT IN (SELECT NSTUDENT FROM STIPENDIYA WHERE NVID={nvid})";

            using (SqliteDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read())   // построчно считываем данные
                    {
                        var nstudent = reader.GetValue(0);
                        var fam = reader.GetValue(1);
                        var im = reader.GetValue(2);
                        var otch = reader.GetValue(3);

                        studentGridView.Rows.Add(nstudent, fam, im, otch);
                    }
                }
            }
        }

        private void studentGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
