using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityCabsLeeds
{
    public partial class Driversignup : Form
    {
        private DBhelper DBhelper = new DBhelper();
        private Driver driver = new Driver("","", "", "", "", "", "",new DateTime(),"","","","","","","","","");
        string avalability;
        public Driversignup()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
        string Havevehicle;
        string Worktime;
        private void signupbtn_Click(object sender, EventArgs e)
        {
            //id genarator
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

                    driver.driverID = otp;
                    driver.Firstname = textName.Text;
                    driver.Lastname = textName.Text;
                    driver.Username = textUsername.Text;
                    driver.Email = textEmail.Text;
                    driver.contact = textContact.Text;
                    driver.password = textPassword.Text;
                    driver.DOB = DOB.Value;
                    driver.Gender = Gender.Text;
                    driver.District = textDistrict.Text;
                    driver.Havevehicle = Havevehicle;
                    driver.vmake = textVmake.Text;
                    driver.vmodel = textVmodel.Text;
                    driver.plateno = textPlateno.Text;
                    driver.license = textDriverlicense.Text;
                    driver.Worktime = Worktime;
                    driver.available = avalability;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred" + ex.Message);
                }
                finally
                {

                    bool success = DBhelper.addDriver(driver);
                    if (success)
                    {
                        new Driverlogin().Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Registration failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        public void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Havevehicle = "yes";
            textPlateno.Show();
            textVmake.Show();
            textVmodel.Show();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Havevehicle = "no";
            textPlateno.Hide();
            textVmake.Hide(); 
            textVmodel.Hide();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Worktime = "part time";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Worktime = "full time";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Driverlogin().Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }

        private void avlyes_CheckedChanged(object sender, EventArgs e)
        {
            avalability = "yes";
        }

        private void avlno_CheckedChanged(object sender, EventArgs e)
        {
            avalability = "no";
        }
    }
}
