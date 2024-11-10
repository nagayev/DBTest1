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
            string message = "Данное программное обеспечение предназначено для учета\nинформации о назначенных студентам стипендиях,\nа так же контроля выплат этих стипендий.\nАвтор приложения студент группы 20ВОЭ1:\nНагаев М.Т.";
            string caption = "Информация о разработчике";
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

        //Запросы

        private void requestStudentsListMenuItem_Click(object sender, EventArgs e)
        {
            StudentListRequest studentListRequest = new StudentListRequest();
            studentListRequest.Show();
        }

        private void списокВидовСтидендийВУказанномДипазонеСуммыСтипендииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VIDSTIPRequest vidstipRequest = new VIDSTIPRequest();
            vidstipRequest.Show();
        }

        //Отчеты

        public DataSet BindData()
        {
            DataSet _dataSet = new DataSet();
            var con = new System.Data.SQLite.SQLiteConnection("Data Source=bd.db");
            var cmd = new System.Data.SQLite.SQLiteCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from vidstip ORDER BY VIDSTIP";
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            da.Fill(_dataSet);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return _dataSet;
        }

        public DataTable BindData2()
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
            // Добавляем источник данных в отчет
            DataTable dataTable = new DataTable();
            dataTable = BindData2();
            report.RegisterData(dataTable, "VIDSTIP");

            // Создаем макет отчета
            report.Load("report1.frx"); // Замените на путь к вашему файлу отчета

            // Настраиваем отчет
            report.GetDataSource("VIDSTIP").Enabled = true;

            // Печатаем отчет
            report.Prepare();
            report.Show();
            //dead code
            return;
            DataSet _dataSet = new DataSet();
            _dataSet = BindData();
            // register the "Cities" table
            report.RegisterData(_dataSet.Tables[0], "vidstip");
            // enable it to use in a report
            report.GetDataSource("vidstip").Enabled = true;
            // create A4 page with all margins set to 1cm
            ReportPage page1 = new ReportPage();
            page1.Name = "Page1";
            report.Pages.Add(page1);
            // create ReportTitle band
            page1.ReportTitle = new ReportTitleBand();
            page1.ReportTitle.Name = "FastReport";
            // set its height to 1.5cm
            page1.ReportTitle.Height = Units.Centimeters * 1.5f;
            // create group header
            GroupHeaderBand group1 = new GroupHeaderBand();
            group1.Name = "АА";
            group1.Height = Units.Centimeters * 1;
            // set group condition
            group1.Condition = "[vidstip.VIDSTIP]";//[Cities.CityName].Substring(0, 1)
            // add group to the page.Bands collection
            page1.Bands.Add(group1);
            // create group footer
            group1.GroupFooter = new GroupFooterBand();
            group1.GroupFooter.Name = "GroupFooter1";
            group1.GroupFooter.Height = Units.Centimeters * 1;
            // create DataBand
            DataBand data1 = new DataBand();
            data1.Name = "Data1";
            data1.Height = Units.Centimeters * 0.5f;
            // set data source
            data1.DataSource = report.GetDataSource("vidstip");
            // connect databand to a group
            group1.Data = data1;
            // create "Text" objects
            // report title
            TextObject text1 = new TextObject();
            text1.Name = "Text1";
            // set bounds
            text1.Bounds = new System.Drawing.RectangleF(0, 0,
            Units.Centimeters * 19, Units.Centimeters * 1);
            // set text
            text1.Text = "Список видов стипендии по алфавиту";
            // set appearance
            text1.HorzAlign = HorzAlign.Center;
            text1.Font = new System.Drawing.Font("Tahoma", 14, FontStyle.Bold);
            // add it to ReportTitle
            page1.ReportTitle.Objects.Add(text1);
            // group
            TextObject text2 = new TextObject();
            text2.Name = "Text2";
            text2.Bounds = new RectangleF(0, 0,
            Units.Centimeters * 2, Units.Centimeters * 1);
            text2.Text = "[vidstip.SUMSTIP]";//[Cities.CityName].Substring(0, 1)
            text2.Font = new Font("Tahoma", 10, FontStyle.Bold);
            // add it to GroupHeader
            group1.Objects.Add(text2);
            report.Show();
        }

        private void stipsMenuItem_Click(object sender, EventArgs e)
        {
            VIDSTIPTable vidstipTable = new VIDSTIPTable();
            vidstipTable.Show();
        }

    }
}
