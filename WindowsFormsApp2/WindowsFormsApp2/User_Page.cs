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


namespace WindowsFormsApp2
{
    public partial class User_Page : Form
    {
        OracleConnection conn;
        string ordb = "data source= orcl ; user id = scott ; password = tiger";
        Decimal user_id;
        int service_number;

        public User_Page(Decimal id)
        {
            InitializeComponent();
            user_id = id;
        }

        private void User_Page_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT service_number FROM users WHERE userID =:id";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id", user_id);
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                service_number = Convert.ToInt32(dr[0]);
            }

        }

        private void add_meters_btn_Click(object sender, EventArgs e)
        {
            Add_meters_Info add_Meters_Info = new Add_meters_Info(service_number);
            add_Meters_Info.Show(); 
        }

        private void pay_btn_Click(object sender, EventArgs e)
        {
            PayBill payBill = new PayBill(service_number);
            payBill.Show();
        }

        private void view_btn_Click(object sender, EventArgs e)
        {
            ViewBill viewBill = new ViewBill();
            viewBill.Show();
        }
    }
}
