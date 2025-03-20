using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBTest1
{
    public partial class fmAddVIDSTIP : Form
    {
        public string? VIDSTIP, SUMSTIP;
        public fmAddVIDSTIP()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VIDSTIP = vidstip.Text;
            SUMSTIP = sumstip.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
