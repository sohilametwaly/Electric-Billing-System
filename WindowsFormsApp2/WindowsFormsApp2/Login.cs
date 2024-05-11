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
    public partial class Login : Form
    {
        OracleConnection conn;
        string ordb = "data source= orcl;user id =scott; password= tiger";
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            Decimal id = Convert.ToInt32(id_box.Text);
            string password = password_box.Text.ToString();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT is_admin FROM users WHERE userID =:id AND password =:password ";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id",OracleDbType.Decimal).Value = id;
            cmd.Parameters.Add("password",OracleDbType.Varchar2).Value = password;
            OracleDataReader dr  = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (dr[0].ToString() == "Y")
                {
                    Form2 form2 = new Form2();
                    form2.Show();
                }
                else
                {
                    User_Page user_Page = new User_Page(id);
                    user_Page.Show();   
                }
                this.Hide();
                MessageBox.Show("Login successful!");
            } else
            {
                MessageBox.Show("Invalid ID or password. Login failed.");

            }
            dr.Close();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.Show();
        }
    }
}
