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
using static System.Net.WebRequestMethods;

namespace CityCabsLeeds
{
    public partial class Managedrivers : Form
    {
        private Driver drivers = new Driver("", "", "", "", "", "", "", new DateTime(), "", "", "", "", "", "", "", "","");
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
        public Managedrivers()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            addDriver.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, addDriver.Width, addDriver.Height, 10, 10));
            removeDriver.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, removeDriver.Width, removeDriver.Height, 10, 10));
            showdrivers.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, showdrivers.Width, showdrivers.Height, 10, 10));
            clearDriverfield.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, clearDriverfield.Width, clearDriverfield.Height, 10, 10));
        }

        string Havevehicle;
        string Worktime;
        string availability;
        private void addDriver_Click(object sender, EventArgs e)
        {
            bool isAnyEmpty = false;
            foreach (Control control in this.Controls)
            {
                if (control is DateTimePicker)
                {
                    if (((DateTimePicker)control).Value == null)
                    {
                        isAnyEmpty = true;
                        break;
                    }
                }
                else if (control is ComboBox)
                {
                    if (((ComboBox)control).SelectedIndex == -1)
                    {
                        isAnyEmpty = true;
                        break;
                    }
                }
            }
            if (isAnyEmpty)
            {
                MessageBox.Show("One or more fields are empty, please fill it before submitting");
            }
            else
            {
                try
                {

                    drivers.driverID = textBoxdriverid.Text;
                    drivers.Firstname = textName.Text;
                    drivers.Lastname = textName.Text;
                    drivers.Username = textUsername.Text;
                    drivers.Email = textEmail.Text;
                    drivers.contact = textContact.Text;
                    drivers.password = textPassword.Text;
                    drivers.DOB = DOB.Value;
                    drivers.Gender = Gender.Text;
                    drivers.District = textDistrict.Text;
                    drivers.Havevehicle = Havevehicle;
                    drivers.vmake = textVmake.Text;
                    drivers.vmodel = textVmodel.Text;
                    drivers.plateno = textPlateno.Text;
                    drivers.license = textDriverlicense.Text;
                    drivers.Worktime = Worktime;
                    drivers.available = availability;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred" + ex.Message);
                }
                finally
                {

                    bool success = adminDBhelper.addDriver(drivers);
                    if (success)
                    {
                        MessageBox.Show("Succefully added");
                    }
                    else
                    {
                        MessageBox.Show("Registration failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        public void gendriverid_Click(object sender, EventArgs e)
        {

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

                textBoxdriverid.Text = otp;
            }
        }

        private void fulltime_CheckedChanged(object sender, EventArgs e)
        {
            Worktime = "full time";
        }

        private void parttime_CheckedChanged(object sender, EventArgs e)
        {
            Worktime = "part time";
        }

        private void havevehi_CheckedChanged(object sender, EventArgs e)
        {
            Havevehicle = "yes";
            textPlateno.Show();
            textVmake.Show();
            textVmodel.Show();
            label13.Show();
            label12.Show();
            label15.Show();
            panel6.Show();
            panel7.Show();
            panel8.Show();
        }

        private void novehicle_CheckedChanged(object sender, EventArgs e)
        {
            Havevehicle = "no";
            textPlateno.Hide();
            textVmake.Hide();
            textVmodel.Hide();
            label13.Hide();
            label12.Hide();
            label15.Hide();
            panel6.Hide();
            panel7.Hide();
            panel8.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new AdminDashboard().Show();
            this.Close();
        }

        private void removeDriver_Click(object sender, EventArgs e)
        {
            string driverid = textBoxdriverid.Text;

            bool success = adminDBhelper.removeDriver(driverid);
            if (success == true)
            {
                MessageBox.Show("Success fully removed"); 
            }
            else
            {
                MessageBox.Show("failed to remove! Enter DriverID");
            }
        }
        public void clear()
        {
            textBoxdriverid.Clear();
            textName.Clear();
            textEmail.Clear();
            textPassword.Clear();
            DOB.Value = DateTime.Now;
            textDistrict.Clear();
            textDriverlicense.Clear();
            havevehi.Checked = false;
            novehicle.Checked = false;
            textVmake.Clear();
            textVmodel.Clear();
            textPlateno.Clear();
            textUsername.Clear();
            textContact.Clear();
            Gender.SelectedIndex = -1;
            parttime.Checked = false;
            fulltime.Checked = false;
            avlno.Checked = false;
            avlyes.Checked = false;

        }
        private void clearDriverfield_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new DriverDetails().Show();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            availability = "yes";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            availability = "no";
        }

        private void Managedrivers_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DOB_ValueChanged(object sender, EventArgs e)
        {
            DOB.CustomFormat = "dd/MM/yyyy";
        }

        private void DOB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DOB.CustomFormat = " ";
            }
        }
    }
}
