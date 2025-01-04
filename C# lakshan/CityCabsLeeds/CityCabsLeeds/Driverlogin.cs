using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityCabsLeeds
{
    public partial class Driverlogin : Form
    {

        private Driver driver = new Driver("","","","","","","",new DateTime(),"","","","","","","","","");
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
        public Driverlogin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 10, 10));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textemail.Text.Length == 0)
            {
                label4.Text = "Username cannot be empty";
                label5.Text = "";
            }
            else if (textpassword.Text.Length == 0)
            {
                label5.Text = "Password cannot be empty";
                label4.Text = "";
            }
            else
            {
                try
                {
                    driver.Email = textemail.Text;
                    driver.password = textpassword.Text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred" + ex.Message);
                }
                finally
                {
                    bool success = DBhelper.DriverLogin(driver);
                    if (success)
                    {
                        new CustomerDashboard().Show();
                        this.Hide();

                        //CustomerDashboard.Instance.username.Text = textemail.Text;
                    }
                    else
                    {
                        MessageBox.Show("Login failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        label5.Text = "Email or Password not valid";
                        label4.Text = "";
                        textemail.Clear();
                        textpassword.Clear();
                    }
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) { }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            textpassword.UseSystemPasswordChar=false;
            pictureBox4.Hide();
            pictureBox7.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            textpassword.UseSystemPasswordChar = true;
            pictureBox7.Hide();
            pictureBox4.Show();
        }

        private void Driverlogin_Load(object sender, EventArgs e)
        {
            pictureBox7.Hide();
            pictureBox4.Show();
            label4.Text = "";
            label5.Text = "";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
