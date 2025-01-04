using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityCabsLeeds
{
    public partial class AdminDashboard : Form
    {
        private List<Booking> bookinglist = new List<Booking>();
        private AdminDBhelper adminDBhelper = new AdminDBhelper(); 

       [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
      (
          int nLeftRect,     // x-coordinate of upper-left corner
          int nTopRect,      // y-coordinate of upper-left corner
          int nRightRect,    // x-coordinate of lower-right corner
          int nBottomRect,   // y-coordinate of lower-right corner
          int nWidthEllipse, // height of ellipse
          int nHeightEllipse // width of ellipse
      );
        public AdminDashboard()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        private void loadbookings()
        {
            bookinglist = adminDBhelper.loadBooking();
            dataGridView1.DataSource = bookinglist;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            new Addvehicle().Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Managedrivers().Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new ManageCustomer().Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Show();
            panel2.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Show();
            loadbookings();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new Addvehicle().Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new Managedrivers().Show();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            new ManageCustomer().Show();
            this.Close();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            Logout.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Logout.Width, Logout.Height, 20, 20));
            dataGridView1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, dataGridView1.Width, dataGridView1.Height, 10, 10));
            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 20, 20));
            button2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button2.Width, button2.Height, 20, 20));
            button3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button3.Width, button3.Height, 20, 20));
            panel1.Show();
            panel2.Hide();

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            new ADMINlogin().Show();
            this.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cancelBooking_Click(object sender, EventArgs e)
        {
            string bookingId = bookingid.Text;

            bool success = adminDBhelper.Removebooking(bookingId);
            if (success == true)
            {
                MessageBox.Show("Successfully Canceled");
                loadbookings();
                bookingid.Clear();
            }
            else
            {
                MessageBox.Show("failed to remove!");
                loadbookings();
            }
        }
    }
}
