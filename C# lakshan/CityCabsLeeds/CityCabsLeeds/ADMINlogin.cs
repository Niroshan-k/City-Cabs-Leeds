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
    public partial class ADMINlogin : Form
    {

        private Admin admin = new Admin("","","","","","",new DateTime(),"");
        private AdminDBhelper  admindbheklper = new AdminDBhelper();

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
        public ADMINlogin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           //
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textemail.Text) && string.IsNullOrEmpty(textpassword.Text))
            {
                label4.Text = "Field is empty!";
                label5.Text = "Field is empty!";
            }
            else if (string.IsNullOrEmpty(textemail.Text))
            {
                label5.Text = "Username required";
            }
            else if (string.IsNullOrEmpty(textpassword.Text))
            {
                label4.Text = "Password required";
            }
            else
            {
                try
                {
                    admin.Username = textemail.Text;
                    admin.Password = textpassword.Text;

                    bool success = admindbheklper.AdminLogin(admin);
                    if (success)
                    {
                        new AdminDashboard().Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Login failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textemail.Clear();
                        textpassword.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ADMINlogin_Load(object sender, EventArgs e)
        {
            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 10, 10));
           
            pictureBox7.Hide();
            pictureBox4.Show();
            label4.Text = "";
            label5.Text = "";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            textpassword.UseSystemPasswordChar = false;
            pictureBox4.Hide();
            pictureBox7.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            textpassword.UseSystemPasswordChar = true;
            pictureBox7.Hide();
            pictureBox4.Show();
        }
    }
}
