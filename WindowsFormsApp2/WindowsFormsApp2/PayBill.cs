using Oracle.DataAccess.Client;
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
    public partial class PayBill : Form
    {

        int service_number;

        OracleConnection conn;

        string ordb = "data source= orcl ; user id = scott ; password = tiger";


        public PayBill(int number)

        {
            service_number = number;
            InitializeComponent();

        }

        private void PayBill_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT METERS_READING FROM METER_INFO WHERE SERVICE_NUMBER = :serv";
            cmd.Parameters.Add(":serv", service_number);

            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                string payment_method = paymentBox.Text;

                dr.Close();

                OracleCommand cmd2 = new OracleCommand();
                cmd2.Connection = conn;
                Console.WriteLine("{0} {1} {2}", payment_method, DateTime.Today.Date, service_number);
                cmd2.CommandText = "UPDATE BILLS SET PAYMENT_METHOD = :method WHERE SERVICE_NUMBER = :serv";
                cmd2.Parameters.Add(":method", payment_method);
                cmd2.Parameters.Add(":serv", Convert.ToInt32(service_number));
                int r = cmd2.ExecuteNonQuery();
                MessageBox.Show("Bill paid successfully");
            }
            else
            {

                MessageBox.Show("Please enter meter reading first");
            }
        }
    }
}
