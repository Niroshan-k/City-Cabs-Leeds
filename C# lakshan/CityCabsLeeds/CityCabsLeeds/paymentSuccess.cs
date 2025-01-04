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
    public partial class paymentSuccess : Form
    {
        private AdminDBhelper adminDBhelper = new AdminDBhelper();
        public static paymentSuccess instance;
        public Label lbl1;
        public Label lbl2;

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
        // Import the necessary Win32 functions
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        // Constants for Win32 messages
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        public paymentSuccess(string pdfPath)
        {
            InitializeComponent();

            instance = this;
            lbl1 = label2;
            lbl2 = label3;

            ShowPdf(pdfPath);

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 10, 10));
            button2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button2.Width, button2.Height, 10, 10));
        }
        private void ShowPdf(string pdfPath)
        {
            webBrowser1.Navigate(pdfPath);
        }
 

        private void paymentSuccess_Load(object sender, EventArgs e)
        {

        }
        private void paymentSuccess_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           string driverId = label3.Text;

            bool success = adminDBhelper.removeDriverAvailability(driverId);
            if (success)
            {
                new Customerlogin().Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to update driver's availability. Make sure the driver's current availability is 'yes'.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string bookingid = label2.Text;

            bool success = adminDBhelper.Removebooking(bookingid);
            if (success == true)
            {
                new CustomerDashboard().Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("failed to Remove your booking! Restart your booking.");
                new CustomerDashboard().Show();
                this.Close();
            }
        }
    }
}
