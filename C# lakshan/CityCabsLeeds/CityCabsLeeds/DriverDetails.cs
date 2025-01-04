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
    public partial class DriverDetails : Form
    {
        private List<Driver> drivers = new List<Driver>();
        private AdminDBhelper adminDBhelper = new AdminDBhelper();
        public DriverDetails()
        {
            InitializeComponent();
            adminDBhelper = new AdminDBhelper();
            loadDriverslist();
        }
        private void loadDriverslist()
        {
            drivers = adminDBhelper.loadDrivers();
            dataGridView.DataSource = drivers;
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new Managedrivers().Show();
            this.Close();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
