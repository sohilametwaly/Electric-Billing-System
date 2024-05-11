using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Add_meters_Info : Form
    {
        OracleConnection conn;
        string ordb = "data source= orcl ; user id = scott ; password = tiger";
        int service_number;

        public Add_meters_Info(int number)
        {
            Console.WriteLine(number);
            service_number = number;
            InitializeComponent();

        }

        private void Add_meters_Info_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddMeterInfoButton_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "UPDATE meter_info SET METERS_READING = :reading WHERE SERVICE_NUMBER = :serv";
            cmd.Parameters.Add(":reading", Convert.ToInt32(metersNumberTextBox.Text));
            cmd.Parameters.Add(":serv", Convert.ToInt32(service_number));
            int r = cmd.ExecuteNonQuery();

            if (r == -1)
            {
                MessageBox.Show("Error");
            }
            else
            {
                MessageBox.Show("Meters added successfully");
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
