using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityCabsLeeds
{
    public partial class ManageCustomer : Form
    {
        private Customer customer = new Customer("", "", "", "", "", "", "", new DateTime(), "");
        private AdminDBhelper adminDBhelper = new AdminDBhelper();
        private List<Customer> list = new List<Customer>();

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
        public ManageCustomer()
        {
            InitializeComponent();
            adminDBhelper = new AdminDBhelper();
            loadCustomers();


            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            removeCustomer.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, removeCustomer.Width, removeCustomer.Height, 10, 10));
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new AdminDashboard().Show();
            this.Close();
        }

        private void addDriver_Click(object sender, EventArgs e)
        {
            
        }

        private void gendriverid_Click(object sender, EventArgs e)
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

            textBoxCusid.Text = otp;
        }

        private void removeCustomer_Click(object sender, EventArgs e)
        {
            string customerid = textBoxCusid.Text;

            bool success = adminDBhelper.removeCustomer(customerid);
            if (success == true)
            {
                MessageBox.Show("Success fully removed");
                loadCustomers();
            }
            else
            {
                MessageBox.Show("failed to remove! Enter CustomerID");
            }
        }
        private void clearDriverfield_Click(object sender, EventArgs e)
        {
            
        }

        private void AddnewCustomer_Click(object sender, EventArgs e)
        { }

        private void ClearCustomerfield_Click(object sender, EventArgs e)
        {
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            new Customerdetails().Show();
            this.Close();
        }
        private void loadCustomers()
        {
           try
             {
                 list = adminDBhelper.loadCustomers();
                 if (list == null)
                 {
                     MessageBox.Show("No cars found for the customer.");
                     return;
                 }
                 dataGridView.Columns.Clear();
                 dataGridView.AutoGenerateColumns = false;

                 DataGridViewTextBoxColumn username = new DataGridViewTextBoxColumn();
                 username.HeaderText = "Username";
                 username.DataPropertyName = "Username";
                 dataGridView.Columns.Add(username);

                 DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn();
                 id.HeaderText = "Customer ID";
                 id.DataPropertyName = "customerID";
                 dataGridView.Columns.Add(id);

                DataGridViewTextBoxColumn email = new DataGridViewTextBoxColumn();
                 email.HeaderText = "Email";
                 email.DataPropertyName = "Email";
                 dataGridView.Columns.Add(email);

                 DataGridViewTextBoxColumn tel = new DataGridViewTextBoxColumn();
                 tel.HeaderText = "Contact";
                 tel.DataPropertyName = "contact";
                 dataGridView.Columns.Add(tel);

                dataGridView.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading cars: " + ex.Message);
            }
            //list = adminDBhelper.loadCustomers();
            //dataGridView.DataSource = list;
        }

        private void ManageCustomer_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridView.Rows[e.RowIndex];

                
                    textBoxCusid.Text = row.Cells[1].Value.ToString();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while selecting an SUV: " + ex.Message);
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
