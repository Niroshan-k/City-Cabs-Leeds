using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CityCabsLeeds;
using System.Data;

namespace CityCabsLeeds
{
    internal class DBhelper
    {
        private string connectionstring;
        //private SqlConnection connection;

        public DBhelper()
        {
            connectionstring = ConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString;
        }

        public bool addBooking(Booking booking)
        {
            bool isSuccess = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    string insertQuery = "INSERT INTO BookingDB VALUES (@vehicle_id, @plate_no, @driverlicense_no, @driver_id, @contact, @district, @booking_id, @pickup, @drop_off, @distance_km, @date, @time, @payement_method, @specialrequest, @price, @customer_id)";
                    SqlCommand cmd = new SqlCommand(insertQuery, conn);

                    conn.Open();
                    // Set parameters here...
                    cmd.Parameters.AddWithValue("@vehicle_id", booking.VehicleID);
                    cmd.Parameters.AddWithValue("@plate_no", booking.Plateno);
                    cmd.Parameters.AddWithValue("@driverlicense_no", booking.driver.license);
                    cmd.Parameters.AddWithValue("@driver_id", booking.driver.driverID);
                    cmd.Parameters.AddWithValue("@contact", booking.driver.contact);
                    cmd.Parameters.AddWithValue("@district", booking.driver.District);
                    cmd.Parameters.AddWithValue("@booking_id", booking.bookingID);
                    cmd.Parameters.AddWithValue("@pickup", booking.pickupLocation);
                    cmd.Parameters.AddWithValue("@drop_off", booking.dropoffLocation);
                    cmd.Parameters.AddWithValue("@distance_km", booking.Distance);
                    cmd.Parameters.AddWithValue("@date", booking.Date);
                    cmd.Parameters.AddWithValue("@time", booking.Time);
                    cmd.Parameters.AddWithValue("@payement_method", booking.Payementmethod);
                    cmd.Parameters.AddWithValue("@specialrequest", booking.Request);
                    cmd.Parameters.AddWithValue("@price", booking.Price);
                    cmd.Parameters.AddWithValue("@customer_id", booking.Customer.customerID);


                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        isSuccess = true;
                    }
                    else
                    {
                        isSuccess = false;
                    }
                } // Connection will be automatically closed and disposed here
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            return isSuccess;
        }
        public bool addCustomer(Customer customer)
        {
            bool isSuccess = false;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    string insertQuery = "INSERT INTO CustomersignupDB VALUES (@fname, @lname, @username, @email, @contact, @password, @dob, @gender,@customerID)";
                    SqlCommand cmd = new SqlCommand(insertQuery, conn);

                    conn.Open();
                    // Set parameters here...
                    cmd.Parameters.AddWithValue("@fname", customer.Firstname);
                    cmd.Parameters.AddWithValue("@lname", customer.Lastname);
                    cmd.Parameters.AddWithValue("@username", customer.Username);
                    cmd.Parameters.AddWithValue("@email", customer.Email);
                    cmd.Parameters.AddWithValue("@contact", customer.contact);
                    cmd.Parameters.AddWithValue("@password", customer.password);
                    cmd.Parameters.AddWithValue("@dob", customer.DOB);
                    cmd.Parameters.AddWithValue("@gender", customer.Gender);
                    cmd.Parameters.AddWithValue("@customerID", customer.customerID);

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        isSuccess = true;
                    }
                    else
                    {
                        isSuccess = false;
                    }
                } // Connection will be automatically closed and disposed here
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }


            return isSuccess;
        }
        public bool addDriver(Driver driver)
        {
            bool isSuccess = false;
            try
            {
                using(SqlConnection conn = new SqlConnection(connectionstring))
                {
                    string insertQuery = "INSERT INTO DriversignupDB VALUES (@name, @username, @email, @contact, @password, @dob, @gender, @district, @havevehicle, @vmake, @vmodel, @plateno, @driverlicenseno, @worktime, @driverID, @availability)";
                    SqlCommand cmd = new SqlCommand(insertQuery, conn);

                    conn.Open();
                    cmd.Parameters.AddWithValue("@name", driver.Firstname);
                    cmd.Parameters.AddWithValue("@username",driver.Username);
                    cmd.Parameters.AddWithValue("@email",driver.Email);
                    cmd.Parameters.AddWithValue("@contact",driver.contact);
                    cmd.Parameters.AddWithValue("@password",driver.password);
                    cmd.Parameters.AddWithValue("@dob",driver.DOB);
                    cmd.Parameters.AddWithValue("@gender",driver.Gender);
                    cmd.Parameters.AddWithValue("@district",driver.District);
                    cmd.Parameters.AddWithValue("@havevehicle",driver.Havevehicle);
                    cmd.Parameters.AddWithValue("@vmake",driver.vmake);
                    cmd.Parameters.AddWithValue("@vmodel",driver.vmodel);
                    cmd.Parameters.AddWithValue("@plateno",driver.plateno);
                    cmd.Parameters.AddWithValue("@driverlicenseno",driver.license);
                    cmd.Parameters.AddWithValue("@worktime",driver.Worktime);
                    cmd.Parameters.AddWithValue("@driverID", driver.driverID);
                    cmd.Parameters.AddWithValue("@availability", driver.available);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        isSuccess = true;
                    }
                    else
                    {
                        isSuccess = false;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }


            return isSuccess;
        }

        //customer login
        public Customer CustomerLogin(Customer customer)
        {
            Customer loggedInCustomer = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    string query = "SELECT customerID, email FROM CustomersignupDB WHERE email=@Email AND password=@Password";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@Email", customer.Email);
                    cmd.Parameters.AddWithValue("@Password", customer.password);

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            try
                            {
                                string customerID = reader["customerID"].ToString();
                                string email = reader["email"].ToString();

                                loggedInCustomer = new Customer
                                {
                                    customerID = customerID,
                                    Email = email
                                };
                            }
                            catch (InvalidCastException ex)
                            {
                                MessageBox.Show("Type conversion error: " + ex.Message);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            return loggedInCustomer;
        }




        public bool DriverLogin(Driver driver)
        {
            bool isSuccess = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    string query = "SELECT COUNT(1) FROM DriversignupDB WHERE email=@Email AND password=@Password";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@Email", driver.Email);
                    cmd.Parameters.AddWithValue("@Password", driver.password);

                    conn.Open();

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count == 1)
                    {
                        isSuccess = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            return isSuccess;
        }





    }
}
