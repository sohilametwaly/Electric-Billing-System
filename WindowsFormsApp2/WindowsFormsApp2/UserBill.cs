using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
namespace WindowsFormsApp2
{
    public partial class UserBill : Form
    {
        CrystalReport3 cr;
        public UserBill()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cr.SetParameterValue(0, Convert.ToInt32(textBox1.Text));
            crystalReportViewer1.ReportSource = cr;
        }

        private void UserBill_Load(object sender, EventArgs e)
        {
            cr = new CrystalReport3();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
