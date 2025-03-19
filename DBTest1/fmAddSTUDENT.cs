п»їusing System;
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
    public partial class fmAddSTUDENT : Form
    {
        public string? FAMILYA, IMYA, OTCHESTVO;
        public fmAddSTUDENT()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IMYA = imia.Text;
            FAMILYA = familiya.Text;
            OTCHESTVO = otchestvo.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
