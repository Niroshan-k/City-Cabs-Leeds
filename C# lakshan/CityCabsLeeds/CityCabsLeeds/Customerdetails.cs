using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityCabsLeeds
{
    public partial class Customerdetails : Form
    {
        private AdminDBhelper adminDBhelper = new AdminDBhelper();
        private List<Customer> list = new List<Customer>();
        public Customerdetails()
        {
            InitializeComponent();
            adminDBhelper = new AdminDBhelper();
            loadCustomers();
        }
        private void loadCustomers()
        {
            list = adminDBhelper.loadCustomers();
            dataGridView.DataSource = list;
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new ManageCustomer().Show();
            this.Close();
        }

        private void Customerdetails_Load(object sender, EventArgs e)
        {

        }
    }
}
