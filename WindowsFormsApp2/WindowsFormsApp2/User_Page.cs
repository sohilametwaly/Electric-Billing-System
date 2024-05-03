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
    public partial class User_Page : Form
    {
        public User_Page()
        {
            InitializeComponent();
        }

        private void User_Page_Load(object sender, EventArgs e)
        {

        }

        private void add_meters_btn_Click(object sender, EventArgs e)
        {
            Add_meters_Info add_Meters_Info = new Add_meters_Info();
            add_Meters_Info.Show(); 
        }

        private void pay_btn_Click(object sender, EventArgs e)
        {
            PayBill payBill = new PayBill();
            payBill.Show();
        }

        private void view_btn_Click(object sender, EventArgs e)
        {
            ViewBill viewBill = new ViewBill();
            viewBill.Show();
        }
    }
}
