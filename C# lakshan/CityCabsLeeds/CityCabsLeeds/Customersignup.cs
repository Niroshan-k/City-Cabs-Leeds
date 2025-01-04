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
    public partial class Customersignup : Form
    {
        private Customer customer = new Customer("","", "", "", "", "", "",new DateTime(),""); 
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
        public Customersignup()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            signupbtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, signupbtn.Width, signupbtn.Height, 10, 10));
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var customerlogin = new Customerlogin();
            customerlogin.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ID generator
            string num = "123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int len = num.Length;
            string otp = string.Empty;
            int otpdigit = 7;
            string finaldigits;
            int getindex;

            for (int i = 0; i < otpdigit; i++)
            {
                do
                {
                    getindex = new Random().Next(0, len);
                    finaldigits = num.ToCharArray()[getindex].ToString();
                }
                while (otp.IndexOf(finaldigits) != -1);
                otp += finaldigits;
            }

            
            bool isAnyEmpty = AreAnyControlsEmpty(this);
            if (isAnyEmpty)
            {
                MessageBox.Show("One or more fields are empty, please fill them before submitting");
                return;
            }

            
            if (!IsValidEmail(textEmail.Text))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            
            if (!IsValidUsername(textusername.Text))
            {
                MessageBox.Show("Username must be at least 5 characters long and contain no special characters.");
                return;
            }

            

            try
            {
                customer.customerID = otp;
                customer.Firstname = textFName.Text;
                customer.Lastname = textLName.Text;
                customer.Username = textusername.Text;
                customer.Email = textEmail.Text;
                customer.contact = textTel.Text;
                customer.password = textPassword.Text;
                customer.DOB = DOB.Value;
                customer.Gender = Gender.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                return;
            }
            if (textPassword.Text != textRtypePwd.Text)
            {
                MessageBox.Show("Passwords Doesn't match");
                textRtypePwd.Clear();
            }
            else
            {
                bool success = DBhelper.addCustomer(customer);
                if (success)
                {
                    new Customerlogin().Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Registration failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool AreAnyControlsEmpty(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox && string.IsNullOrEmpty(control.Text))
                {
                    return true;
                }
                else if (control is DateTimePicker && ((DateTimePicker)control).Value == null)
                {
                    return true;
                }
                else if (control is ComboBox && ((ComboBox)control).SelectedIndex == -1)
                {
                    return true;
                }
                else if (control.HasChildren)
                {
                    if (AreAnyControlsEmpty(control))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsValidUsername(string username)
        {
            // Example: Username must be at least 5 characters long and contain no special characters
            return username.Length >= 5 && username.All(char.IsLetterOrDigit);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Customersignup_Load(object sender, EventArgs e)
        {

        }
    }
}
