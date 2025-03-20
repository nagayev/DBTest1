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
    public partial class VIDSTIPTable : Form
    {
        private SqliteConnection connection;
        private int autoincrementId;
        public VIDSTIPTable()
        {
            InitializeComponent();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Удаление", "Удалить текущую запись", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DataGridViewRow Current = vidstipGridView.CurrentRow;
                var id = Current.Cells[0].Value.ToString();
                vidstipGridView.Rows.RemoveAt(Current.Index);
                SqliteCommand command = new SqliteCommand();
                command.Connection = connection;
                command.CommandText = "DELETE FROM VIDSTIP WHERE NVID=" + id;
                int number = command.ExecuteNonQuery();
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            string param1 = vidstipGridView.SelectedRows[0].Cells[1].Value.ToString();
            string param2 = vidstipGridView.SelectedRows[0].Cells[2].Value.ToString();
            fmEditVIDSTIP fmEditVIDSTIP = new fmEditVIDSTIP(param1, param2);
            var result = fmEditVIDSTIP.ShowDialog();
            if (result == DialogResult.OK)
            {
                var selectedRows = vidstipGridView.SelectedRows;
                if (selectedRows.Count == 0)
                {
                    MessageBox.Show("Ошибка", "Не выбран!");
                    return;
                }
                string NVID_s = selectedRows[0].Cells[0].Value.ToString();
                int NVID = Int32.Parse(NVID_s);
                string VIDSTIP = fmEditVIDSTIP.VIDSTIP;            //values preserved after close
                string SUMSTIP = fmEditVIDSTIP.SUMSTIP;
                //Do something here with these values
                SqliteCommand command = new SqliteCommand();
                command.Connection = connection;
                command.CommandText = $"UPDATE VIDSTIP SET VIDSTIP='{VIDSTIP}', SUMSTIP='{SUMSTIP}' WHERE NVID={NVID}";
                int number = command.ExecuteNonQuery();
                //for example
                selectedRows[0].Cells[1].Value = VIDSTIP;
                selectedRows[0].Cells[2].Value = SUMSTIP;

                //studentsGridView.Rows.Add(autoincrementId, FAMILIYA, IMYA, OTCHESTVO);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            fmAddVIDSTIP fmVidStip = new fmAddVIDSTIP();
            var result = fmVidStip.ShowDialog();
            if (result == DialogResult.OK)
            {
                string VIDSTIP = fmVidStip.VIDSTIP;            //values preserved after close
                string SUMSTIP = fmVidStip.SUMSTIP;
                //Do something here with these values
                SqliteCommand command = new SqliteCommand();
                command.Connection = connection;
                command.CommandText = $"INSERT INTO VIDSTIP(VIDSTIP,SUMSTIP) VALUES ('{VIDSTIP}', {SUMSTIP})";
                int number = command.ExecuteNonQuery();
                //for example
                autoincrementId++;
                vidstipGridView.Rows.Add(autoincrementId, VIDSTIP, SUMSTIP);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            vidstipGridView.Rows.Clear();
            SqliteCommand command = new SqliteCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM VIDSTIP";

            using (SqliteDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read())   // построчно считываем данные
                    {
                        var id = reader.GetValue(0);
                        var vidstip = reader.GetValue(1);
                        var sum = reader.GetValue(2);

                        vidstipGridView.Rows.Add(id, vidstip, sum);
                    }
                }
            }
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VIDSTIPTable_Load(object sender, EventArgs e)
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
    }
}
