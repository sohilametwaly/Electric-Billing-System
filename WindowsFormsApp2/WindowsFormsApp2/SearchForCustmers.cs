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
    public partial class SearchForCustmers : Form
    {

        OracleConnection conn;
        string ordb = "data source= orcl;user id =scott; password= tiger";
        public SearchForCustmers()
        {
            InitializeComponent();
        }

        private void SearchForCustmers_Load(object sender, EventArgs e)
        {

            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT userID FROM users";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                id_comboBox.Items.Add(dr[0]);
            }


        }

        private void id_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        { 
           
            OracleCommand c2 = new OracleCommand();
            c2.Connection = conn;
            c2.CommandText = "SELECT name,address,service_number,phone_number FROM users WHERE userID=:id";
            c2.Parameters.Add("id", id_comboBox.SelectedItem.ToString());
            c2.CommandType = CommandType.Text;
            OracleDataReader r = c2.ExecuteReader();
            while (r.Read())
            {
                name_box.Text = r[0].ToString();
                address_box.Text = r[1].ToString();
                service_box.Text = r[2].ToString();
                phone_box.Text = r[3].ToString();
               
            }
            r.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 AdminPage = new Form2();
            AdminPage.Show();
        }
    }
}
