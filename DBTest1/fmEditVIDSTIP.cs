п»їusing System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FastReport.RichTextParser.RFont;

namespace DBTest1
{
    public partial class fmEditVIDSTIP : Form
    {
        public string VIDSTIP, SUMSTIP;
        public fmEditVIDSTIP(string vidstip1, string sumstip1)
        {
            VIDSTIP = vidstip1;
            SUMSTIP = sumstip1;
            InitializeComponent();
            sumstip.Text = sumstip1;
            vidstip.Text = vidstip1;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            SUMSTIP = sumstip.Text;
            VIDSTIP = vidstip.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
