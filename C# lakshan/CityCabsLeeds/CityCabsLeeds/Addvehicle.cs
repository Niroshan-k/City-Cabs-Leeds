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
    public partial class Addvehicle : Form
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
        private AdminDBhelper adminDBhelper = new AdminDBhelper();
        private Car car = new Car("", "", "", "", "","");
        private Van van = new Van("", "", "", "","");
        private Suv suv = new Suv("", "", "", "","");
        private List<Car> carlist = new List<Car>();
        private List<Van> vanlist = new List<Van>();
        private List<Suv> suvlist = new List<Suv>();
        public Addvehicle()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));



            //hide Addvan option
            vanid.Hide(); vanmake.Hide(); vanmodel.Hide(); vanplateno.Hide();
            textBox1van.Hide(); textBox2van.Hide(); textBox3van.Hide();
            textBox4van.Hide(); addvan.Hide(); removevan.Hide(); clearvan.Hide();vanidgen.Hide();dataGridViewvan.Hide();

            //hide add suv option
            suvid.Hide(); suvmake.Hide(); suvmodel.Hide(); suvplateno.Hide(); textBox1suv.Hide(); textBox2suv.Hide();
            textBox3suv.Hide(); textBox4suv.Hide(); addsuv.Hide(); removesuv.Hide(); clearsuv.Hide();suvidgen.Hide();dataGridViewsuv.Hide();

            adminDBhelper = new AdminDBhelper();
            LoadCars();
          

        }


        public void showsuvfield()
        {
            carid.Hide(); carmake.Hide(); carmodel.Hide(); carplateno.Hide(); comboBoxcar.Hide(); textBox1car.Hide(); textBox2car.Hide(); textBox3car.Hide(); textBox4car.Hide();
            caradd.Hide(); carremove.Hide(); carclear.Hide(); cartype.Hide(); caridgen.Hide();dataGridViewcar.Hide();

            //hide Addvan option
            vanid.Hide(); vanmake.Hide(); vanmodel.Hide(); vanplateno.Hide(); textBox1van.Hide(); textBox2van.Hide(); textBox3van.Hide();
            textBox4van.Hide(); addvan.Hide(); removevan.Hide(); clearvan.Hide(); vanidgen.Hide();dataGridViewvan.Hide();

            //hide add suv option
            suvid.Show(); suvmake.Show(); suvmodel.Show(); suvplateno.Show(); textBox1suv.Show(); textBox2suv.Show(); textBox3suv.Show();
            textBox4suv.Show(); addsuv.Show(); removesuv.Show(); clearsuv.Show(); suvidgen.Show();dataGridViewsuv.Show();
        }
        public void showvanfield()
        {
            carid.Hide(); carmake.Hide(); carmodel.Hide(); carplateno.Hide(); comboBoxcar.Hide(); textBox1car.Hide(); textBox2car.Hide(); textBox3car.Hide();
            textBox4car.Hide(); caradd.Hide(); carremove.Hide(); carclear.Hide(); cartype.Hide(); caridgen.Hide();dataGridViewcar.Hide();

            //hide Addvan option
            vanid.Show(); vanmake.Show(); vanmodel.Show(); vanplateno.Show(); textBox1van.Show(); textBox2van.Show(); textBox3van.Show(); textBox4van.Show(); addvan.Show();
            removevan.Show(); clearvan.Show(); vanidgen.Show();dataGridViewvan.Show();

            //hide add suv option
            suvid.Hide(); suvmake.Hide(); suvmodel.Hide(); suvplateno.Hide(); textBox1suv.Hide(); textBox2suv.Hide(); textBox3suv.Hide(); textBox4suv.Hide();
            addsuv.Hide(); removesuv.Hide(); clearsuv.Hide(); suvidgen.Hide(); dataGridViewsuv.Hide();
        }
        public void showcarfield()
        {
            carid.Show(); carmake.Show(); carmodel.Show(); carplateno.Show(); comboBoxcar.Show(); textBox1car.Show();
            textBox2car.Show(); textBox3car.Show(); textBox4car.Show(); caradd.Show(); carremove.Show(); carclear.Show(); cartype.Show(); caridgen.Show();dataGridViewcar.Show();

            //hide Addvan option
            vanid.Hide(); vanmake.Hide(); vanmodel.Hide(); vanplateno.Hide(); textBox1van.Hide(); textBox2van.Hide(); textBox3van.Hide(); textBox4van.Hide();
            addvan.Hide(); removevan.Hide(); clearvan.Hide(); vanidgen.Hide();dataGridViewvan.Hide();

            //hide add suv option
            suvid.Hide(); suvmake.Hide(); suvmodel.Hide(); suvplateno.Hide(); textBox1suv.Hide(); textBox2suv.Hide(); textBox3suv.Hide();
            textBox4suv.Hide(); addsuv.Hide(); removesuv.Hide(); clearsuv.Hide(); suvidgen.Hide();dataGridViewsuv.Hide();
        }



        private void LoadCars()
        {
            carlist = adminDBhelper.loadcars();
            dataGridViewcar.DataSource = carlist;
        }
        private void LoadVans()
        {
            vanlist = adminDBhelper.loadVans();
            dataGridViewvan.DataSource = vanlist;
        }
        private void LoadSuvs()
        {
            suvlist = adminDBhelper.loadSuvs();
            dataGridViewsuv.DataSource = suvlist;
        }
        public void clearcarfield()
        {
            textBox1car.Clear();
            textBox2car.Clear();
            textBox3car.Clear();
            textBox4car.Clear();
            comboBoxcar.SelectedIndex = -1;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
        public void clearvanfield()
        {
            textBox1van.Clear();
            textBox2van.Clear();
            textBox3van.Clear();
            textBox4van.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
        public void clearsuvfield()
        {
            textBox1suv.Clear();
            textBox2suv.Clear();
            textBox3suv.Clear();
            textBox4suv.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            showcarfield();
            adminDBhelper = new AdminDBhelper();
            LoadCars();
        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            showvanfield();
            adminDBhelper = new AdminDBhelper();
            LoadVans();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            showsuvfield();
            adminDBhelper = new AdminDBhelper();
            LoadSuvs();
        }

        private void carclear_Click(object sender, EventArgs e)
        {
            clearcarfield();
        }

        private void clearvan_Click(object sender, EventArgs e)
        {
            clearvanfield();
        }

        private void clearsuv_Click(object sender, EventArgs e)
        {
            clearsuvfield();
        }

        private void caradd_Click(object sender, EventArgs e)
        {
            bool isAnyEmpty = false;
            foreach (Control control in this.Controls)
            {
               
                if (control is ComboBox)
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
                    car.CarID = textBox1car.Text;
                    car.Vehiclemodel = textBox2car.Text;
                    car.Vehiclemake = textBox3car.Text;
                    car.PlateNo = textBox4car.Text;
                    car.Type = comboBoxcar.SelectedItem.ToString();
                    car.availability = avl;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred" + ex.Message);
                }
                finally
                {

                    bool success = adminDBhelper.addCars(car);
                    if (success)
                    {
                        MessageBox.Show("New Car Added to the system");
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        clearcarfield();
                        LoadCars();
                    }
                    else
                    {
                        MessageBox.Show("Error occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void addvan_Click(object sender, EventArgs e)
        {
            string first = textBox1van.Text;
            string second = textBox2van.Text;
            string third = textBox3van.Text;
            string forth = textBox4van.Text;
            if(first == "" || second == "" || third == "" || forth == "")
            {
                MessageBox.Show("One or more fields are empty, please fill it before submitting");
            }
            else
            {
                try
                {
                    van.VanID = textBox1van.Text;
                    van.Vehiclemodel = textBox2van.Text;
                    van.Vehiclemake = textBox3van.Text;
                    van.PlateNo = textBox4van.Text;
                    van.availability = avl;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred" + ex.Message);
                }
                finally
                {
                    bool successs = adminDBhelper.addVans(van);
                    if (successs)
                    {
                        MessageBox.Show("New van Added to the system");
                        clearvanfield();
                        LoadVans();
                    }
                    else
                    {
                        MessageBox.Show("Error occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
           
        }

        private void addsuv_Click(object sender, EventArgs e)
        {
            string first = textBox1suv.Text;
            string second = textBox2suv.Text;
            string third = textBox3suv.Text;
            string forth = textBox4suv.Text;
            if (first == "" || second == "" || third == "" || forth == "")
            {
                MessageBox.Show("One or more fields are empty, please fill it before submitting");
            }
            else
            {
                try
                {
                    suv.SuvID = textBox1suv.Text;
                    suv.Vehiclemodel = textBox2suv.Text;
                    suv.Vehiclemake = textBox3suv.Text;
                    suv.PlateNo = textBox4suv.Text;
                    suv.availability = avl;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred" + ex.Message);
                }
                finally
                {
                    bool successs = adminDBhelper.addSuvs(suv);
                    if (successs)
                    {
                        MessageBox.Show("New suv Added to the system");
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        clearsuvfield();
                        LoadSuvs();
                    }
                    else
                    {
                        MessageBox.Show("Error occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void suvid_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
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

                textBox1car.Text = otp;
            }
        }

        private void vanidgen_Click(object sender, EventArgs e)
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

                textBox1van.Text = otp;
            }
        }

        private void suvidgen_Click(object sender, EventArgs e)
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

                textBox1suv.Text = otp;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void carremove_Click(object sender, EventArgs e)
        {
            string carid = textBox1car.Text;

            bool success = adminDBhelper.RemoveCar(carid);
            if(success == true)
            {
                MessageBox.Show("Success fully removed");
                clearcarfield();
                LoadCars();
            }
            else 
            { 
                MessageBox.Show("failed to remove!");
                clearcarfield();
                LoadCars();
            }
        }

        private void removevan_Click(object sender, EventArgs e)
        {
            string vanid = textBox1van.Text;

            bool success = adminDBhelper.RemoveVan(vanid);
            if (success == true)
            {
                MessageBox.Show("Success fully removed");
                clearvanfield();
                LoadVans();
            }
            else
            {
                MessageBox.Show("failed to remove!");
                clearvanfield();
                LoadVans();
            }
        }

        private void removesuv_Click(object sender, EventArgs e)
        {
            string suvid = textBox1suv.Text;

            bool success = adminDBhelper.RemoveSuv(suvid);
            if (success == true)
            {
                MessageBox.Show("Success fully removed");
                clearsuvfield();
                LoadSuvs();
            }
            else
            {
                MessageBox.Show("failed to remove!");
                clearsuvfield();
                LoadSuvs();
            }
        }

        private void dataGridViewsuv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Addvehicle_Load(object sender, EventArgs e)
        {
            addsuv.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, addsuv.Width, addsuv.Height, 10, 10));
            addvan.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, addvan.Width, addvan.Height, 10, 10));
            caradd.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, caradd.Width, caradd.Height, 10, 10));
            removesuv.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, removesuv.Width, removesuv.Height, 10, 10));
            removevan.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, removevan.Width, removevan.Height, 10, 10));
            carremove.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, carremove.Width, carremove.Height, 10, 10));
            clearsuv.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, clearsuv.Width, clearsuv.Height, 10, 10));
            clearvan.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, clearvan.Width, clearvan.Height, 10, 10));
            carclear.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, carclear.Width, carclear.Height, 10, 10));
            comboBoxcar.Region = Region.FromHrgn(CreateRoundRectRgn(0,0, comboBoxcar.Width, comboBoxcar.Height, 10, 10));
            caridgen.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, caridgen.Width, caridgen.Height, 10, 10));
            vanidgen.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, vanidgen.Width, vanidgen.Height, 10, 10));
            suvidgen.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, suvidgen.Width, suvidgen.Height, 10, 10));
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        string avl;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            avl = "yes";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            avl = "no";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new AdminDashboard().Show();
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
