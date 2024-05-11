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
        string ordb = "data source= orcl;user id =scott; password= tiger";

        public Add_meters_Info()
        {
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
            int metersNumber = Convert.ToInt32(metersNumberTextBox.Text);

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "add_meter_info";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("meters_number", metersNumber);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Meter info has been added successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
