using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CityCabsLeeds
{
    public partial class Customerlogin : Form
    {
        private Customer customer = new Customer("", "", "", "", "", "", "", new DateTime(), "");
        private DBhelper DBhelper = new DBhelper();

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
        public Customerlogin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 10, 10));


        }

        private void button2_Click(object sender, EventArgs e)
        {
            var customersignup = new Customersignup();
            customersignup.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textemail.Text.Length == 0)
            {
                emailerror.Text = "Username cannot be empty";
                pswderror.Text = "";
            }
            else if (textpassword.Text.Length == 0)
            {
                pswderror.Text = "Password cannot be empty";
                emailerror.Text = "";
            }
            else
            {
                try
                {
                    customer.Email = textemail.Text;
                    customer.password = textpassword.Text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    Customer loggedInCustomer = DBhelper.CustomerLogin(customer);
                    if (loggedInCustomer != null)
                    {
                        CustomerDashboard dashboard = new CustomerDashboard();
                        dashboard.cusid.Text = (loggedInCustomer.customerID);  // Use the public method to set customerID
                        dashboard.Accountname.Text = loggedInCustomer.Email;  // Assuming you have a Username textbox in the dashboard

                        dashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Login failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        pswderror.Text = "Email or Password not valid";
                        textemail.Clear();
                        textpassword.Clear();
                    }
                }
            }
        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox3.Hide();
        }

        private void Customerlogin_Load(object sender, EventArgs e)
        {
            pictureBox3.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox3.Show();
            pictureBox4.Hide();
            textpassword.UseSystemPasswordChar = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Hide();
            pictureBox4.Show();
            textpassword.UseSystemPasswordChar = true;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
