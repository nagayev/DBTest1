п»їusing System;
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
    public partial class StudentListRequest : Form
    {
        private SqliteConnection connection;
        public StudentListRequest()
        {
            InitializeComponent();
        }
 

        private void updateButton_Click(object sender, EventArgs e)
        {
            studentsGridView.Rows.Clear();
            SqliteCommand command = new SqliteCommand();
            command.Connection = connection;
            command.CommandText = "SELECT FAMILIYA,IMYA,OTCHESTVO FROM STUDENT ORDER BY FAMILIYA";
            using (SqliteDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows) // РµСЃР»Рё РµСЃС‚СЊ РґР°РЅРЅС‹Рµ
                {
                    while (reader.Read())   // РїРѕСЃС‚СЂРѕС‡РЅРѕ СЃС‡РёС‚С‹РІР°РµРј РґР°РЅРЅС‹Рµ
                    {
                        var fam = reader.GetValue(0);
                        var name = reader.GetValue(1);
                        var otch = reader.GetValue(2);

                        studentsGridView.Rows.Add(fam, name, otch);
                    }
                }
            }
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StudentListRequest_Load(object sender, EventArgs e)
        {
            connection = new SqliteConnection("Data Source=bd.db");
            connection.Open();
        }
    }
}
