using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form4 : Form
    {
        CrystalReport1 cr;
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = cr;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            cr = new CrystalReport1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 Admin_page = new Form2();
            Admin_page.Show();
        }
    }
}
