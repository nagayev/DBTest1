using System;
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
    public partial class fmEditSTUDENT : Form
    {
        public string? FAMILYA, IMYA, OTCHESTVO;
        public fmEditSTUDENT(string f, string i, string o)
        {
            InitializeComponent();
            familiya.Text = f;
            imia.Text = i;
            otchestvo.Text = o;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            IMYA = imia.Text;
            FAMILYA = familiya.Text;
            OTCHESTVO = otchestvo.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
