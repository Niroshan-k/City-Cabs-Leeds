using Azure.Identity;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Drawing.Text;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using System.CodeDom;


namespace CityCabsLeeds
{
    public partial class CustomerDashboard : Form
    {
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



        private List<Car> carlist = new List<Car>();
        private List<Van> vanlist = new List<Van>();
        private List<Suv> suvlist = new List<Suv>();
        private List<Driver> driverlist = new List<Driver>();
        private AdminDBhelper adminDBhelper = new AdminDBhelper();
        private DBhelper dbhelper = new DBhelper();
        private Booking booking = new Booking("","",0,"","","","","",0,"","","",new DateTime(),new DateTime(),"","");
        public static CustomerDashboard Instance;
        public Label username;
        public CustomerDashboard()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            Instance = this;
            username = acountname;
            this.KeyPreview = true;
            this.numericUpDown1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numericUpDown1_KeyDown);

        }
        public Label Accountname
        {
            get { return acountname; }
        }
        public Label cusid
        {
            get { return cusID; }
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // This method can remain empty or handle other logic related to value changes if needed
            CalculateAndUpdatePrice();
        }
        private void CalculateAndUpdatePrice()
        {
            distance = numericUpDown1.Value;
            if (distance < 0)
            {
                priceerror.Text = "Distance must be greater than 0.\n";
            }
            else
            {
                price = Convert.ToInt32(distance * 400);
                pricebooking.Text = Convert.ToString(price);
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
           
        }
        private void numericUpDown1_KeyDown(object sender, KeyEventArgs e)
        {
            // Get the current value from the textbox
            if (!decimal.TryParse(pricebooking.Text, out decimal currentPrice))
            {
                currentPrice = 0; // Default to 0 if parsing fails
            }

            if (e.KeyCode == Keys.Up)
            {
                // Increase price by 200
                currentPrice += 200;
            }
            else if (e.KeyCode == Keys.Down)
            {
                // Decrease price by 200 but ensure it doesn't go below 0
                currentPrice -= 200;
                if (currentPrice < 0)
                {
                    currentPrice = 0;
                }
            }

            // Update the textbox with the new price
            pricebooking.Text = currentPrice.ToString();

            // To prevent further processing of the key event
            e.Handled = true;
        }


        private void CustomerDashboard_Load(object sender, EventArgs e)
        {
            adminDBhelper = new AdminDBhelper();
            LoadCars();

            carview.Show();
            vanview.Hide();
            suvview.Hide();

            selectDriverpanel.Hide();
            bookingpanel.Hide();
            carselectpanel.Hide();
            driversWithvehiclePanel.Hide();

            button4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button4.Width, button4.Height, 10, 10));
            button5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button5.Width, button5.Height, 10, 10));
            button6.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button6.Width, button6.Height, 10, 10));
            button7.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button7.Width, button7.Height, 10, 10));
            button9.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button9.Width, button9.Height, 10, 10));
            button10.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button10.Width, button10.Height, 10, 10));
            vehiselctBTN.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, vehiselctBTN.Width, vehiselctBTN.Height, 10, 10));
            cancel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, cancel1.Width, cancel1.Height, 10, 10));
            goTobooking.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, goTobooking.Width, goTobooking.Height, 10, 10));
            button11.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button11.Width, button11.Height, 10, 10));
            bookingplace.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, bookingplace.Width, bookingplace.Height, 10, 10));
            cancelbooking.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, cancelbooking.Width, cancelbooking.Height, 10, 10));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            adminDBhelper = new AdminDBhelper();
            LoadCars();

            vanview.Hide();
            suvview.Hide();
            carview.Show();

            button5.BackColor = Color.Goldenrod;
            button6.BackColor = Color.Gold;
            button7.BackColor = Color.Gold;

           
        }

        private void LoadCars()
        {
            try
            {
                carlist = adminDBhelper.loadcarsforCustomer();

                if (carlist == null)
                {
                    MessageBox.Show("No cars found for the customer.");
                    return;
                }

                carview.Columns.Clear();
                carview.AutoGenerateColumns = false;

                DataGridViewTextBoxColumn caridcol = new DataGridViewTextBoxColumn();
                caridcol.HeaderText = "Car ID";
                caridcol.DataPropertyName = "carid";
                carview.Columns.Add(caridcol);

                DataGridViewTextBoxColumn plate = new DataGridViewTextBoxColumn();
                plate.HeaderText = "Plate No";
                plate.DataPropertyName = "plateno";
                carview.Columns.Add(plate);

                DataGridViewTextBoxColumn cartype = new DataGridViewTextBoxColumn();
                cartype.HeaderText = "Type";
                cartype.DataPropertyName = "type";
                carview.Columns.Add(cartype);

                carview.DataSource = carlist;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading cars: " + ex.Message);
            }
        }
       
        private void LoadVans()
        {
            try
            {
                vanlist = adminDBhelper.loadVansforcustomers();

                if (vanlist == null)
                {
                    MessageBox.Show("No vans found for the customer.");
                    return;
                }

                vanview.Columns.Clear();
                vanview.AutoGenerateColumns = false;

                DataGridViewTextBoxColumn vanidcol = new DataGridViewTextBoxColumn();
                vanidcol.HeaderText = "Van ID";
                vanidcol.DataPropertyName = "vanid";
                vanview.Columns.Add(vanidcol);

                DataGridViewTextBoxColumn platecol = new DataGridViewTextBoxColumn();
                platecol.HeaderText = "Plateno";
                platecol.DataPropertyName = "plateno";
                vanview.Columns.Add(platecol);

                vanview.DataSource = vanlist;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading vans: " + ex.Message);
            }
        }

        private void LoadSuvs()
        {
            try
            {
                suvlist = adminDBhelper.loadSuvsforCustomers();

                if (suvlist == null)
                {
                    MessageBox.Show("No SUVs found for the customer.");
                    return;
                }

                suvview.Columns.Clear();
                suvview.AutoGenerateColumns = false;

                DataGridViewTextBoxColumn suvcol = new DataGridViewTextBoxColumn();
                suvcol.HeaderText = "Suv ID";
                suvcol.DataPropertyName = "suvid";
                suvview.Columns.Add(suvcol);

                DataGridViewTextBoxColumn platecol = new DataGridViewTextBoxColumn();
                platecol.HeaderText = "Plateno";
                platecol.DataPropertyName = "plateno";
                suvview.Columns.Add(platecol);

                suvview.DataSource = suvlist;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading SUVs: " + ex.Message);
            }
        }
        private void loadDrivers()
        {
            try
            {
                driverlist = adminDBhelper.loadDriversforcustomer();

                if (driverlist == null)
                {
                    MessageBox.Show("No drivers found for the customer.");
                    return;
                }

                driverview.Columns.Clear();
                driverview.AutoGenerateColumns = false;

                DataGridViewTextBoxColumn driveridcol = new DataGridViewTextBoxColumn();
                driveridcol.HeaderText = "Driver ID";
                driveridcol.DataPropertyName = "driverID";
                driverview.Columns.Add(driveridcol);

                DataGridViewTextBoxColumn contactcol = new DataGridViewTextBoxColumn();
                contactcol.HeaderText = "Contact";
                contactcol.DataPropertyName = "contact";
                driverview.Columns.Add(contactcol);

                DataGridViewTextBoxColumn licencol = new DataGridViewTextBoxColumn();
                licencol.HeaderText = "Driver License No";
                licencol.DataPropertyName = "license";
                licencol.Visible = true;
                driverview.Columns.Add(licencol);

                DataGridViewTextBoxColumn districtcol = new DataGridViewTextBoxColumn();
                districtcol.HeaderText = "District";
                districtcol.DataPropertyName = "district";
                driverview.Columns.Add(districtcol);

                driverview.DataSource = driverlist;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading drivers: " + ex.Message);
            }
        }
        private void loadDriverswithVehicle()
        {
            try
            {
                driverlist = adminDBhelper.loadDrivershavevehicleforcustomer();

                if (driverlist == null)
                {
                    MessageBox.Show("No Drivers found for the customer. Check the Drivers without Vehicle");
                    return;
                }

                driverWithvehilceview.Columns.Clear();
                driverWithvehilceview.AutoGenerateColumns = false;

                DataGridViewTextBoxColumn driveridcol = new DataGridViewTextBoxColumn();
                driveridcol.HeaderText = "Driver ID";
                driveridcol.DataPropertyName = "driverID";
                driverWithvehilceview.Columns.Add(driveridcol);

                DataGridViewTextBoxColumn contactcol = new DataGridViewTextBoxColumn();
                contactcol.HeaderText = "Contact";
                contactcol.DataPropertyName = "contact";
                driverWithvehilceview.Columns.Add(contactcol);

                DataGridViewTextBoxColumn licencol = new DataGridViewTextBoxColumn();
                licencol.HeaderText = "Driver License No";
                licencol.DataPropertyName = "license";
                licencol.Visible = true;
                driverWithvehilceview.Columns.Add(licencol);

                DataGridViewTextBoxColumn districtcol = new DataGridViewTextBoxColumn();
                districtcol.HeaderText = "District";
                districtcol.DataPropertyName = "district";
                driverWithvehilceview.Columns.Add(districtcol);

                DataGridViewTextBoxColumn plateno = new DataGridViewTextBoxColumn();
                plateno.HeaderText = "Plate No";
                plateno.DataPropertyName = "plateno";
                driverWithvehilceview.Columns.Add(plateno);

                driverWithvehilceview.DataSource = driverlist;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading cars: " + ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            adminDBhelper = new AdminDBhelper();
            LoadVans();
            carview.Hide();
            suvview.Hide();
            vanview.Show();
            button6.BackColor = Color.Goldenrod;
            button7.BackColor = Color.Gold;
            button5.BackColor = Color.Gold;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            adminDBhelper = new AdminDBhelper();
            LoadSuvs();
            carview.Hide();
            vanview.Hide();
            suvview.Show();
            button7.BackColor = Color.Goldenrod;
            button5.BackColor = Color.Gold;
            button6.BackColor = Color.Gold;
        }

        private void carview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.carview.Rows[e.RowIndex];

                    diplayID.Text = row.Cells[0].Value.ToString();
                    shwplateno.Text = row.Cells[1].Value.ToString();
                    shwvehiid2.Text = row.Cells[0].Value.ToString();
                    shwplateno2.Text = row.Cells[1].Value.ToString();
                    vehicleidbooking.Text = row.Cells[0].Value.ToString();
                    platenobooking.Text = row.Cells[1].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while selecting a car: " + ex.Message);
            }
        }

        private void vanview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.vanview.Rows[e.RowIndex];

                    diplayID.Text = row.Cells[0].Value.ToString();
                    shwplateno.Text = row.Cells[1].Value.ToString();
                    shwvehiid2.Text = row.Cells[0].Value.ToString();
                    shwplateno2.Text = row.Cells[1].Value.ToString();
                    vehicleidbooking.Text = row.Cells[0].Value.ToString();
                    platenobooking.Text = row.Cells[1].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while selecting a van: " + ex.Message);
            }
        }

        private void suvview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.suvview.Rows[e.RowIndex];

                    diplayID.Text = row.Cells[0].Value.ToString();
                    shwplateno.Text = row.Cells[1].Value.ToString();
                    shwvehiid2.Text = row.Cells[0].Value.ToString();
                    shwplateno2.Text = row.Cells[1].Value.ToString();
                    vehicleidbooking.Text = row.Cells[0].Value.ToString();
                    platenobooking.Text = row.Cells[1].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while selecting an SUV: " + ex.Message);
            }
        }
        public void hideAvlVehicle()
        {
            carselectpanel.Hide();
            button2.BackColor = Color.Goldenrod;
        }
        private void vehiselctBTN_Click(object sender, EventArgs e)
        {

            hideAvlVehicle();
            loadDrivers();
            selectDriverpanel.Show();

        }

        private void goTobooking_Click(object sender, EventArgs e)
        {
            selectDriverpanel.Hide();
            button3.BackColor = Color.Goldenrod;
            bookingpanel.Show();
            BookingIDgen();
        }

        private void driverview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.driverview.Rows[e.RowIndex];

                    driveridshow.Text = row.Cells[0].Value.ToString();
                    contactshow.Text = row.Cells[1].Value.ToString();
                    textBox2.Text = row.Cells[2].Value.ToString();
                    textBox1.Text = row.Cells[3].Value.ToString();
                    driveridbooking.Text = row.Cells[0].Value.ToString();
                    contactbooking.Text = row.Cells[1].Value.ToString();
                    licensebooking.Text = row.Cells[2].Value.ToString();
                    districtbooking.Text = row.Cells[3].Value.ToString() ;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while selecting a driver: " + ex.Message);
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            driversWithvehiclePanel.Show();
            bookingpanel.Hide();
            selectDriverpanel.Hide();
            carselectpanel.Hide();
            customerdashboardpanel.Hide();
            button8.BackColor = Color.Goldenrod;
            button1.BackColor = Color.Gold;
            button2.BackColor = Color.Gold;
            button3.BackColor = Color.Gold;
            loadDriverswithVehicle();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bookingpanel.Hide();
            selectDriverpanel.Hide();
            carselectpanel.Show();
            driversWithvehiclePanel.Hide();
            customerdashboardpanel.Hide();
            button1.BackColor = Color.Goldenrod;
            button2.BackColor = Color.Gold;
            button3.BackColor = Color.Gold;
            button8.BackColor = Color.Gold;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bookingpanel.Hide();
            selectDriverpanel.Show();
            carselectpanel.Hide();
            driversWithvehiclePanel.Hide();
            customerdashboardpanel.Hide();
            button2.BackColor = Color.Goldenrod;
            button1.BackColor = Color.Gold;
            button3.BackColor = Color.Gold;
            button8.BackColor = Color.Gold;
            loadDrivers();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bookingpanel.Show();
            selectDriverpanel.Hide();
            carselectpanel.Hide();
            driversWithvehiclePanel.Hide();
            customerdashboardpanel.Hide();
            button3.BackColor = Color.Goldenrod;
            button1.BackColor = Color.Gold;
            button2.BackColor = Color.Gold;
            button8.BackColor = Color.Gold;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Customerlogin().Show();
            this.Close();
        }

        private void selectDriverpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            diplayID.Text = "";
            shwplateno.Text = "";
            selectDriverpanel.Hide();
            carselectpanel.Hide();
            bookingpanel.Hide();
            customerdashboardpanel.Show();

        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            driveridshow.Text = "";
            contactshow.Text = "";
            textBox2.Text = "";
            textBox1.Text = "";
            selectDriverpanel.Hide();
            carselectpanel.Show();
            bookingpanel.Hide();
            button2.BackColor = Color.Gold;
           
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            selectDriverpanel.Hide();
            carselectpanel.Hide();
            bookingpanel.Hide();
            customerdashboardpanel.Show();
            button1.BackColor = Color.Gold;
            button2.BackColor = Color.Gold;
            button3.BackColor = Color.Gold;
        }

        private void BookingIDgen()
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

                bookingid.Text = otp;
            }
        }
        private void pricebooking_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits (0-9), control keys (backspace), and handling for the Enter key
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void pricebooking_Leave(object sender, EventArgs e)
        {
            // Disable the TextBox after the user leaves it
            pricebooking.Enabled = false;
        }

        private void distanceKM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void bookingpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Time_ValueChaned(object sender, EventArgs e)
        {
            dateTimePicker2.CustomFormat = "HH:mm";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Back) 
            {
                dateTimePicker1.CustomFormat = " ";
            }
        }

        private void dateTimePicker2_MouseDown(object sender, MouseEventArgs e)
        {
            //dateTimePicker2.CustomFormat = "HH:mm";
        }
        private void clear()
        {
            vehicleidbooking.Text = "";
            platenobooking.Text = "";
            licensebooking.Text = "";
            driveridbooking.Text = "";
            contactbooking.Text = "";
            districtbooking.Text = "";
            bookingid.Text = "";
            location.Clear();
            destination.Clear();
            numericUpDown1.Value = 0;
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            paymentmethoscombo.SelectedItem = -1;
            specialrequestsbooking.Clear();
            pricebooking.Text = "";
        }
        private void bookingplace_Click(object sender, EventArgs e)
        {
            try
            {
                // Initialize the booking object and nested objects
                Booking booking = new Booking
                {
                    driver = new Driver(),
                    Customer = new Customer()
                };

                // Validation
                string errorMessage = "";

                if (string.IsNullOrWhiteSpace(vehicleidbooking.Text))
                {
                    errorMessage += "Vehicle ID cannot be empty.\n";
                }
                if (string.IsNullOrWhiteSpace(platenobooking.Text))
                {
                    errorMessage += "Plate Number cannot be empty.\n";
                }
                if (string.IsNullOrWhiteSpace(licensebooking.Text))
                {
                    errorMessage += "License cannot be empty.\n";
                }
                if (string.IsNullOrWhiteSpace(driveridbooking.Text))
                {
                    errorMessage += "Driver ID cannot be empty.\n";
                }
                if (string.IsNullOrWhiteSpace(contactbooking.Text))
                {
                    errorMessage += "Contact cannot be empty.\n";
                }
                if (string.IsNullOrWhiteSpace(districtbooking.Text))
                {
                    errorMessage += "District cannot be empty.\n";
                }
                if (string.IsNullOrWhiteSpace(bookingid.Text))
                {
                    errorMessage += "Booking ID cannot be empty.\n";
                }
                if (string.IsNullOrWhiteSpace(location.Text))
                {
                    errorMessage += "Pickup Location cannot be empty.\n";
                }
                if (string.IsNullOrWhiteSpace(destination.Text))
                {
                    errorMessage += "Dropoff Location cannot be empty.\n";
                }
                if (numericUpDown1.Value <= 0)
                {
                    errorMessage += "Distance must be greater than 0.\n";
                }
                if (paymentmethoscombo.SelectedIndex < 0)
                {
                    errorMessage += "Payment Method must be selected.\n";
                }
                if (string.IsNullOrWhiteSpace(cusID.Text))
                {
                    errorMessage += "Customer ID cannot be empty.\n";
                }

                if (!string.IsNullOrEmpty(errorMessage))
                {
                    MessageBox.Show("Please correct the following errors:\n" + errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Assign values to booking properties
                booking.VehicleID = vehicleidbooking.Text;
                booking.Plateno = platenobooking.Text;
                booking.driver.license = licensebooking.Text;
                booking.driver.driverID = driveridbooking.Text;
                booking.driver.contact = contactbooking.Text;
                booking.driver.District = districtbooking.Text;
                booking.bookingID = bookingid.Text;
                booking.pickupLocation = location.Text;
                booking.dropoffLocation = destination.Text;
                booking.Distance = numericUpDown1.Value;
                booking.Date = dateTimePicker1.Value.Date;
                booking.Time = dateTimePicker2.Value;
                booking.Payementmethod = paymentmethoscombo.SelectedItem.ToString();
                booking.Request = specialrequestsbooking.Text;
                booking.Price = Convert.ToInt32(pricebooking.Text);
                booking.Customer.customerID = cusID.Text;

                // Save booking to the database
                bool success = dbhelper.addBooking(booking);
                if (success)
                {
                    // Generate PDF
                    string pdfPath = GenerateBookingPdf(booking);

                    // Open PaymentSuccess form
                    paymentSuccess paymentSuccessForm = new paymentSuccess(pdfPath);
                    paymentSuccess.instance.lbl1.Text = bookingid.Text;
                    paymentSuccess.instance.lbl2.Text = driveridbooking.Text;
                    paymentSuccessForm.Show();
                    this.Hide();
                    clear();
                }
                else
                {
                    MessageBox.Show("Booking failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private string GenerateBookingPdf(Booking booking)
        {
            // Path to save the PDF
            string pdfPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "BookingDetails.pdf");

            // Create a new PDF document
            Document doc = new Document(PageSize.A4);
            PdfWriter.GetInstance(doc, new FileStream(pdfPath, FileMode.Create));

            // Open the document to enable writing
            doc.Open();

            // Add title
            Paragraph title = new Paragraph("Booking Details", FontFactory.GetFont("Arial", BaseFont.IDENTITY_H, 20f));
            title.Alignment = Element.ALIGN_CENTER;
            doc.Add(title);
            doc.Add(new Paragraph("\n"));

            // Add booking details
            doc.Add(new Paragraph($"Vehicle ID: {booking.VehicleID}"));
            doc.Add(new Paragraph($"Plate Number: {booking.Plateno}"));
            doc.Add(new Paragraph($"Driver License: {booking.driver.license}"));
            doc.Add(new Paragraph($"Driver ID: {booking.driver.driverID}"));
            doc.Add(new Paragraph($"Driver Contact: {booking.driver.contact}"));
            doc.Add(new Paragraph($"Driver District: {booking.driver.District}"));
            doc.Add(new Paragraph($"Booking ID: {booking.bookingID}"));
            doc.Add(new Paragraph($"Pickup Location: {booking.pickupLocation}"));
            doc.Add(new Paragraph($"Dropoff Location: {booking.dropoffLocation}"));
            doc.Add(new Paragraph($"Distance: {booking.Distance} km"));
            doc.Add(new Paragraph($"Date: {booking.Date.ToShortDateString()}"));
            doc.Add(new Paragraph($"Time: {booking.Time.ToShortTimeString()}"));
            doc.Add(new Paragraph($"Payment Method: {booking.Payementmethod}"));
            doc.Add(new Paragraph($"Special Requests: {booking.Request}"));
            doc.Add(new Paragraph($"Price: {booking.Price}"));
            doc.Add(new Paragraph($"Customer ID: {booking.Customer.customerID}"));

            // Close the document
            doc.Close();

            return pdfPath;
        }

        private void driverWithvehilceview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.driverWithvehilceview.Rows[e.RowIndex];

                    driveridHV.Text = row.Cells[0].Value.ToString();
                    driveridbooking.Text = row.Cells[0].Value.ToString();
                    contactHV.Text = row.Cells[1].Value.ToString();
                    contactbooking.Text = row.Cells[1].Value.ToString();
                    licenHV.Text = row.Cells[2].Value.ToString();
                    licensebooking.Text = row.Cells[2].Value.ToString();
                    districtHV.Text = row.Cells[3].Value.ToString();
                    districtbooking.Text = row.Cells[3].Value.ToString();
                    platenoHV.Text = row.Cells[4].Value.ToString();
                    platenobooking.Text = row.Cells[4].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while selecting an Driver: " + ex.Message);
            }
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            driversWithvehiclePanel.Hide();
            bookingpanel.Show();
            button3.BackColor = Color.Goldenrod;
            BookingIDgen();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            driversWithvehiclePanel.Hide();
            customerdashboardpanel.Show();

            contactHV.Text = "";
            districtHV.Text = "";
            driveridHV.Text = "";
            licenHV.Text = "";
            platenoHV.Text = "";
        }

        private void navbar_Paint(object sender, PaintEventArgs e)
        {

        }
        public decimal distance;
        public int price;
       
    }

}
