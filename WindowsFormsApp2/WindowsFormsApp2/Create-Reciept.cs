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
    public partial class Form3 : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder commandBuilder;
        DataSet ds;
        OracleDataAdapter adapter2;
        OracleCommandBuilder commandBuilder2;
        DataSet ds2;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string ordb = "data source = orcl ; user id = scott ; password = tiger";
           
            string statment = "SELECT * FROM  bills WHERE service_number =:service_no AND name =:user_name";
            adapter = new OracleDataAdapter(statment, ordb);
            ds = new DataSet();
           
            string statment2 = "SELECT meters_reading FROM meter_info WHERE service_number =:service_no";
            adapter2 = new OracleDataAdapter(statment2, ordb);
            ds2 = new DataSet();

        }

        private void create_btn_Click(object sender, EventArgs e)
        {
            adapter.SelectCommand.Parameters.Add("service_no", Convert.ToDecimal(service_no.Text));
            adapter.SelectCommand.Parameters.Add("user_name", consumer_name.Text.ToString().Trim());
            adapter2.SelectCommand.Parameters.Add("service_no", Convert.ToDecimal(service_no.Text.Trim()));

            adapter.Fill(ds);
            adapter2.Fill(ds2);


            commandBuilder = new OracleCommandBuilder(adapter);

            if (ds.Tables[0].Rows[0]["payment_method"].ToString() != "")
            {
                if (ds2.Tables[0].Rows[0]["meters_reading"].ToString() != "")
                {
                    ds.Tables[0].Rows[0]["total_price"] = (Convert.ToDecimal(price.Text) * Convert.ToDecimal(ds2.Tables[0].Rows[0]["meters_reading"]));
                    ds.Tables[0].Rows[0]["meter_price"] = Convert.ToInt32(price.Text);
                    adapter.Update(ds.Tables[0]);
                    MessageBox.Show("Reciept created successfully");
                }
                else
                {
                    MessageBox.Show("User has not entered the meters reading!");
                }

            }
            else
            {
                MessageBox.Show("Bill has not been paid yet!");
            }


           

        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 AdminPage = new Form2();
            AdminPage.Show();
        }
    }
}