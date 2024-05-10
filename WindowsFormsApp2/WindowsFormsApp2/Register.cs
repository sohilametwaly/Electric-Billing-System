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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class Register : Form
    {
        OracleConnection conn;
        string ordb = "data source= orcl;user id =scott; password= tiger";
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            string name = name_box.Text;
            string id = id_box.Text;
            string service_no = service_number_box.Text;
            string phone_number = phone_box.Text;
            string address = address_box.Text;
            string password = password_box.Text.ToString();    


            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO users(name, userid, service_number,phone_number,address,password) VALUES (:name, :id,  :service_no, :phone_number, :address, :password)";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("name", name);
            cmd.Parameters.Add("id", id);
            cmd.Parameters.Add("service_no", service_no);
            cmd.Parameters.Add("phone_number", phone_number);
            cmd.Parameters.Add("address", address);
            cmd.Parameters.Add("password", password);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                Login login = new Login();
                login.Show();
                this.Hide();
                MessageBox.Show("New user is Added");

               
            }
            else
            {
                MessageBox.Show("User ID or Service number already existed choose anothe one");
            }

        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LandingForm landing = new LandingForm();
            landing.Show();
        }

        private void goToLogin_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
