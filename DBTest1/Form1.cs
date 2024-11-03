using FastReport;
using System.Data;
using System.Windows.Forms;

//
using FastReport;
using FastReport.Utils;
using FastReport.TypeConverters;
using FastReport.Code;
using FastReport.Data;
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

        private void requestStudentsListMenuItem_Click(object sender, EventArgs e)
        {
            StudentListRequest studentListRequest = new StudentListRequest();
            studentListRequest.Show();
        }

        public DataSet BindData()
        {
            DataSet _dataSet = new DataSet();
            /*SqlConnection con = new SqlConnection(sql);
            SqlCommand cmd = new SqlCommand("select * from cities", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(_dataSet);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();*/
            return _dataSet;
        }

        private void report1MenuItem_Click(object sender, EventArgs e)
        {
            DataSet _dataSet = new DataSet();
            _dataSet = BindData();
            Report report = new Report();
            // register the "Cities" table
            report.RegisterData(_dataSet.Tables[0], "Cities");
            // enable it to use in a report
            report.GetDataSource("Cities").Enabled = true;
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
            group1.Name = "Cities Data";
            group1.Height = Units.Centimeters * 1;
            // set group condition
            group1.Condition = "[Cities.CityName]";//[Cities.CityName].Substring(0, 1)
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
            data1.DataSource = report.GetDataSource("Cities");
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
            text1.Text = "CitiesData";
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
            text2.Text = "[Cities.CityName]";//[Cities.CityName].Substring(0, 1)
            text2.Font = new Font("Tahoma", 10, FontStyle.Bold);
            // add it to GroupHeader
            group1.Objects.Add(text2);
            report.Prepare();
        }
    }
}
