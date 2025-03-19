using FastReport;
using System.Data;
using System.Windows.Forms;

//
using FastReport;
using FastReport.Utils;
using FastReport.TypeConverters;
using FastReport.Code;
using FastReport.Data;
using System.Data.SqlClient;
//using Microsoft.Data.Sqlite;
using System.Data.SQLite;
/*
using FastReport.Web.Handlers;
using FastReport.Wizards;
using FastReport.MSChart;
using FastReport.Design.StandardDesigner;
*/

namespace DBTest1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.dx;
        }

        private void aboutDeveloperMenu_Click(object sender, EventArgs e)
        {
            string message = "������ ����������� ����������� ������������� ��� �����\n���������� � ����������� ��������� ����������,\n� ��� �� �������� ������ ���� ���������.\n����� ���������� ������� ������ 20���1:\n������ �.�.";
            string caption = "���������� � ������������";
            MessageBoxIcon icon = MessageBoxIcon.Information;
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, buttons, icon);
        }

        private void quitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void studentsMenuItem_Click(object sender, EventArgs e)
        {
            StudentTable studentTable = new StudentTable();
            studentTable.Show();
        }

        //�������

        private void requestStudentsListMenuItem_Click(object sender, EventArgs e)
        {
            StudentListRequest studentListRequest = new StudentListRequest();
            studentListRequest.Show();
        }

        private void ����������������������������������������������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VIDSTIPRequest vidstipRequest = new VIDSTIPRequest();
            vidstipRequest.Show();
        }

        private void �����������������������������������������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VYPLATYRequest vyplatyRequest = new VYPLATYRequest();
            vyplatyRequest.Show();
        }

        //������

        public DataTable BindData()
        {
            DataTable dataTable = new DataTable();
            var con = new System.Data.SQLite.SQLiteConnection("Data Source=bd.db");
            var cmd = new System.Data.SQLite.SQLiteCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from vidstip ORDER BY VIDSTIP";
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            da.Fill(dataTable);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return dataTable;
        }

        private void report1MenuItem_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            // ��������� �������� ������ � �����
            DataTable dataTable = new DataTable();
            dataTable = BindData();
            report.RegisterData(dataTable, "VIDSTIP");

            // ������� ����� ������
            report.Load("report1.frx"); // �������� �� ���� � ������ ����� ������
            report.SetParameterValue("test", "paramValue");

            // ����������� �����
            report.GetDataSource("VIDSTIP").Enabled = true;

            // �������� �����
            report.Prepare();
            report.Show();
        }

        private void report2MenuItem_Click(object sender, EventArgs e)
        {
            report2Window report2Window1 = new report2Window();
            report2Window1.Show();
        }

        private void report3MenuItem_Click(object sender, EventArgs e)
        {
            //������ ������ ���������� ��������
            report3Window report3Window1 = new report3Window();
            report3Window1.Show();
        }

        private void stipsMenuItem_Click(object sender, EventArgs e)
        {
            VIDSTIPTable vidstipTable = new VIDSTIPTable();
            vidstipTable.Show();
        }

        private void studentStipsMenuItem_Click(object sender, EventArgs e)
        {
            STUDENTSTIPSTable studentsStipsTable = new STUDENTSTIPSTable();
            studentsStipsTable.Show();
        }

        private void �����������������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VIDSTIP2Table vidstip2Table = new VIDSTIP2Table();
            vidstip2Table.Show();
        }

        private void ����������������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PAYOUTTable payoutTable = new PAYOUTTable();
            payoutTable.Show();
        }
    }
}
