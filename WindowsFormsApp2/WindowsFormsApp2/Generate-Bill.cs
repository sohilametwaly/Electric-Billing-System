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
    public partial class Form1 : Form
    {
        OracleConnection conn;
        string ordb = "data source= orcl;user id =scott; password= tiger";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int reading,price;
            int service_no = Convert.ToInt32(service_number.Text);
            string user_name = consumer_name.Text;

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "get_meters_info";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("service_no",service_no);
            cmd.Parameters.Add("price", OracleDbType.Int32, ParameterDirection.Output);
            cmd.Parameters.Add("reading",OracleDbType.Int32,ParameterDirection.Output);

            try
            {
                cmd.ExecuteNonQuery();
                reading = Convert.ToInt32(cmd.Parameters["reading"].Value.ToString());

                price = Convert.ToInt32(cmd.Parameters["price"].Value.ToString());

                int totalPrice = reading * price;

                OracleCommand cmd2 = new OracleCommand();

                cmd2.Connection = conn;
                cmd2.CommandText = "add_new_bill";
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.Add("service_no", service_no);
                cmd2.Parameters.Add("user_name", user_name);
                cmd2.Parameters.Add("totalprice", totalPrice);
                cmd2.Parameters.Add("price", price);
                cmd2.ExecuteNonQuery();

                MessageBox.Show("Bill Generated Succesfully");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Invalid Service Number!");
            }



        }
    }
}
