using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class ViewBill : Form
    {
        OracleDataAdapter adapter;
        DataSet ds;
        public ViewBill()
        {
            InitializeComponent();
        }

        private void ViewBill_Load(object sender, EventArgs e)
        {
            string conn = "Data Source = orcl ; User Id = scott ; Password=tiger;";

            string s = "SELECT METER_PRICE, TOTAL_PRICE,METERS_READING FROM bills b, meter_info m WHERE b.SERVICE_NUMBER = m.SERVICE_NUMBER AND b.SERVICE_NUMBER = :serv_no";


            adapter = new OracleDataAdapter(s, conn);

            ds = new DataSet();
        }

      
        private void button1_Click_1(object sender, EventArgs e)
        {
            adapter.SelectCommand.Parameters.Add("serv_no", Convert.ToInt32(textBox1.Text));

            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}


