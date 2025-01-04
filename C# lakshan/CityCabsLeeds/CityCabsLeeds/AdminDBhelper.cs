using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CityCabsLeeds
{
    internal class AdminDBhelper
    {
        private string connectionstring;
        //private string connection;

        public AdminDBhelper()
        {
            connectionstring = ConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString;
        }
        public bool AdminLogin(Admin admin)
        {
            bool isSuccess = false;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    string selectQuery = "SELECT COUNT(1) FROM adminDB WHERE username=@username AND password=@password";
                    SqlCommand cmd = new SqlCommand(selectQuery, conn);

                    cmd.Parameters.AddWithValue("@username", admin.Username);
                    cmd.Parameters.AddWithValue("@password", admin.Password);

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

       
        public bool addCars(Car car)
        {
            bool isSuccess = false;

            try
            {
                using (SqlConnection  conn = new SqlConnection(connectionstring))
                {
                    string insertQuery = "INSERT INTO CarDB VALUES (@carid, @carmodel, @carmake, @plateno, @type, @availability)";
                    SqlCommand cmd = new SqlCommand(insertQuery, conn);

                    conn.Open();
                    cmd.Parameters.AddWithValue("@carid",car.CarID);
                    cmd.Parameters.AddWithValue("@carmodel", car.Vehiclemodel);
                    cmd.Parameters.AddWithValue("@carmake", car.Vehiclemake);
                    cmd.Parameters.AddWithValue("@plateno", car.PlateNo);
                    cmd.Parameters.AddWithValue("@type", car.Type);
                    cmd.Parameters.AddWithValue("@availability", car.availability);

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
        public bool addVans(Van van)
        {
            bool isSuccess = false;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    string insertQuery = "INSERT INTO VanDB VALUES (@vanid, @vanmodel, @vanmake, @plateno, @availability)";
                    SqlCommand cmd = new SqlCommand(insertQuery, conn);

                    conn.Open();
                    cmd.Parameters.AddWithValue("@vanid", van.VanID);
                    cmd.Parameters.AddWithValue("@vanmodel", van.Vehiclemodel);
                    cmd.Parameters.AddWithValue("@vanmake", van.Vehiclemake);
                    cmd.Parameters.AddWithValue("@plateno", van.PlateNo);
                    cmd.Parameters.AddWithValue("@availability", van.availability);

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

        public bool addSuvs(Suv suv)
        {
            bool isSuccess = false;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    string insertQuery = "INSERT INTO SuvDB VALUES (@suvid, @suvmodel, @suvmake, @plateno, @availability)";
                    SqlCommand cmd = new SqlCommand(insertQuery, conn);

                    conn.Open();
                    cmd.Parameters.AddWithValue("@suvid", suv.SuvID);
                    cmd.Parameters.AddWithValue("@suvmodel", suv.Vehiclemodel);
                    cmd.Parameters.AddWithValue("@suvmake", suv.Vehiclemake);
                    cmd.Parameters.AddWithValue("@plateno", suv.PlateNo);
                    cmd.Parameters.AddWithValue("@availability", suv.availability);

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
            finally
            {
                //
            }
            return isSuccess;
        }

        public List<Car> loadcars()
        {
            List<Car> cars = new List<Car>();

            SqlConnection conn = new SqlConnection(connectionstring);
            try
            {
                string sql = "SELECT * FROM CarDB";
                SqlCommand cmd = new SqlCommand(sql, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Car car = new Car("","","","","","") 
                    {
                        CarID = reader["carid"].ToString(),
                        Vehiclemodel = reader["carmodel"].ToString(),
                        Vehiclemake = reader["carmake"].ToString(),
                        PlateNo = reader["plateno"].ToString(),
                        Type = reader["type"].ToString(),
                        availability = reader["availability"].ToString()
                    };
                    cars.Add(car); // Add the car to the list
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return cars;
        }
        public List<Car> loadcarsforCustomer()
        {
            List<Car> cars = new List<Car>();

            SqlConnection conn = new SqlConnection(connectionstring);
            try
            {
                string sql = "SELECT carid,plateno,type FROM CarDB WHERE availability='yes'";
                SqlCommand cmd = new SqlCommand(sql, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Car car = new Car("", "", "", "", "", "")
                    {
                        CarID = reader["carid"].ToString(),
                        //Vehiclemodel = reader["carmodel"].ToString(),
                        //Vehiclemake = reader["carmake"].ToString(),
                        PlateNo = reader["plateno"].ToString(),
                        Type = reader["type"].ToString(),
                        //availability = reader["availability"].ToString()
                    };
                    cars.Add(car); // Add the car to the list
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return cars;
        }
        public List<Booking> loadBooking()
        {
            List<Booking> bookings = new List<Booking>();
            SqlConnection conn = new SqlConnection(connectionstring);
            try
            {
                string sql = "SELECT * FROM BookingDB";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Booking booking = new Booking("", "", 0, "", "", "", "", "", 0, "", "", "", new DateTime(), new DateTime(), "", "")
                    {
                        bookingID = reader["booking_id"].ToString(),
                        pickupLocation = reader["pickup"].ToString(),
                        dropoffLocation = reader["drop_off"].ToString(),
                        Distance = Convert.ToDecimal(reader["distance_km"]),
                        Price = Convert.ToInt32(reader["price"]),
                        Date = reader["date"] != DBNull.Value ? Convert.ToDateTime(reader["date"]) : DateTime.MinValue,
                        Time = reader["time"] != DBNull.Value ? (new DateTime().Add((TimeSpan)reader["time"])) : DateTime.MinValue,
                        VehicleID = reader["vehicle_id"].ToString(),
                        Plateno = reader["plate_no"].ToString(),
                        driver = new Driver
                        {
                            driverID = reader["driver_id"].ToString(),
                            license = reader["driverlicense_no"].ToString(),
                            contact = reader["contact"].ToString(),
                            District = reader["district"].ToString()
                        },
                        Customer = new Customer { customerID = reader["customer_id"].ToString() },
                        Payementmethod = reader["payement_method"].ToString(),
                        Request = reader["specialrequest"].ToString()
                    };
                    bookings.Add(booking);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return bookings;
        }

        public List<Van> loadVans() 
        {
            List<Van> vans = new List<Van>();

            SqlConnection conn = new SqlConnection( connectionstring );
            try
            {
                string sql = "SELECT * FROM VanDB";
                SqlCommand cmd = new SqlCommand(sql, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Van van = new Van("", "", "", "","")
                    {
                        VanID = reader["vanid"].ToString(),
                        Vehiclemodel = reader["vanmodel"].ToString(),
                        Vehiclemake = reader["vanmake"].ToString(),
                        PlateNo = reader["plateno"].ToString(),
                        availability = reader["availability"].ToString()
                    };
                    vans.Add(van); // Add the car to the list
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return vans;
        }

        public List<Van> loadVansforcustomers()
        {
            List<Van> vans = new List<Van>();

            SqlConnection conn = new SqlConnection(connectionstring);
            try
            {
                string sql = "SELECT vanid,plateno FROM VanDB WHERE availability='yes'";
                SqlCommand cmd = new SqlCommand(sql, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Van van = new Van("", "", "", "", "")
                    {
                        VanID = reader["vanid"].ToString(),
                        //Vehiclemodel = reader["vanmodel"].ToString(),
                        //Vehiclemake = reader["vanmake"].ToString(),
                        PlateNo = reader["plateno"].ToString(),
                        //availability = reader["availability"].ToString()
                    };
                    vans.Add(van); // Add the car to the list
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return vans;
        }

        public List<Suv> loadSuvs()
        {
            List<Suv> suvs = new List<Suv>();

            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                string sql = "SELECT * FROM SuvDB";
                SqlCommand cmd = new SqlCommand(sql, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Suv suv = new Suv("", "", "", "","")
                    {
                        SuvID = reader["suvid"].ToString(),
                        Vehiclemodel = reader["suvmodel"].ToString(),
                        Vehiclemake = reader["suvmake"].ToString(),
                        PlateNo = reader["plateno"].ToString(),
                        availability = reader["availability"].ToString()
                    };
                    suvs.Add(suv); // Add the car to the list
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return suvs;
        }
        public List<Suv> loadSuvsforCustomers()
        {
            List<Suv> suvs = new List<Suv>();

            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                string sql = "SELECT suvid,plateno FROM SuvDB WHERE availability='yes'";
                SqlCommand cmd = new SqlCommand(sql, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Suv suv = new Suv("", "", "", "", "")
                    {
                        SuvID = reader["suvid"].ToString(),
                        //Vehiclemodel = reader["suvmodel"].ToString(),
                        //Vehiclemake = reader["suvmake"].ToString(),
                        PlateNo = reader["plateno"].ToString(),
                        //availability = reader["availability"].ToString()
                    };
                    suvs.Add(suv); // Add the car to the list
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return suvs;
        }
        public List<Driver> loadDrivers()
        {
            List<Driver> drivers = new List<Driver>();
            SqlConnection conn = new SqlConnection( connectionstring);

            try
            {
                string sql = "SELECT * FROM DriversignupDB";
                SqlCommand cmd = new SqlCommand(sql, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Driver driver = new Driver()
                    {
                        Firstname = reader["name"].ToString(),
                        Username = reader["username"].ToString(),
                        Email = reader["email"].ToString(),
                        contact = reader["contact"].ToString(),
                        password = reader["password"].ToString(),
                        Gender = reader["gender"].ToString(),
                        District = reader["district"].ToString(),
                        Havevehicle = reader["havevehicle"].ToString(),
                        vmake = reader["vmake"].ToString(),
                        vmodel = reader["vmodel"].ToString(),
                        plateno = reader["plateno"].ToString(),
                        license = reader["driverlicenseno"].ToString(),
                        Worktime = reader["worktime"].ToString(),
                        driverID = reader["driverID"].ToString(),
                        available = reader["availability"].ToString(),
                        DOB = Convert.ToDateTime(reader["dob"])
                    };
                drivers.Add(driver);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return drivers;
        }
         public List<Driver> loadDriversforcustomer()
        {
            List<Driver> drivers = new List<Driver>();
            SqlConnection conn = new SqlConnection( connectionstring);
            
            try
            {
                string sql = "SELECT driverID,contact,driverlicenseno,district FROM DriversignupDB WHERE availability='yes' AND havevehicle='no'";
                SqlCommand cmd = new SqlCommand(sql, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Driver driver = new Driver("", "", "", "", "", "", "", new DateTime(), "", "", "", "", "", "", "", "","")
                    {
                        //Firstname = reader["name"].ToString(),
                        //Username = reader["username"].ToString(),
                        //Email = reader["email"].ToString(),
                        contact = reader["contact"].ToString(),
                        //password = reader["password"].ToString(),
                        //DOB = Convert.ToDateTime(reader["dob"]),
                        //Gender = reader["gender"].ToString(),
                        District = reader["district"].ToString(),
                        //Havevehicle = reader["havevehicle"].ToString(),
                        //vmake = reader["vmake"].ToString(),
                        //vmodel = reader["vmodel"].ToString(),
                        //plateno = reader["plateno"].ToString(),
                        license = reader["driverlicenseno"].ToString(),
                        //Worktime = reader["worktime"].ToString(),
                        driverID = reader["driverID"].ToString(),
                        //available = reader["availability"].ToString()
                    };
                drivers.Add(driver);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return drivers;
        }
        public List<Driver> loadDrivershavevehicleforcustomer()
        {
            List<Driver> drivers = new List<Driver>();
            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                string sql = "SELECT driverID,contact,driverlicenseno,district,plateno FROM DriversignupDB WHERE availability='yes' AND havevehicle='yes'";
                SqlCommand cmd = new SqlCommand(sql, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Driver driver = new Driver("", "", "", "", "", "", "", new DateTime(), "", "", "", "", "", "", "", "", "")
                    {
                        //Firstname = reader["name"].ToString(),
                        //Username = reader["username"].ToString(),
                        //Email = reader["email"].ToString(),
                        contact = reader["contact"].ToString(),
                        //password = reader["password"].ToString(),
                        //DOB = Convert.ToDateTime(reader["dob"]),
                        //Gender = reader["gender"].ToString(),
                        District = reader["district"].ToString(),
                        //Havevehicle = reader["havevehicle"].ToString(),
                        //vmake = reader["vmake"].ToString(),
                        //vmodel = reader["vmodel"].ToString(),
                        plateno = reader["plateno"].ToString(),
                        license = reader["driverlicenseno"].ToString(),
                        //Worktime = reader["worktime"].ToString(),
                        driverID = reader["driverID"].ToString(),
                        //available = reader["availability"].ToString()
                    };
                    drivers.Add(driver);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return drivers;
        }
        public List<Customer> loadCustomers()
        {
            List<Customer> customers = new List<Customer>();
            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                string sql = "SELECT * FROM CustomersignupDB";
                SqlCommand cmd = new SqlCommand(sql, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Customer customer = new Customer("","","","","","","", new DateTime(),"")
                    {
                        //Firstname = reader["fname"].ToString(),
                        //Lastname = reader["lname"].ToString(),
                        Username = reader["username"].ToString(),
                        Email = reader["email"].ToString(),
                        contact = reader["contact"].ToString(),
                        //password = reader["password"].ToString(),
                        //DOB = Convert.ToDateTime(reader["dob"]),
                        //Gender = reader["gender"].ToString(),
                        customerID = reader["customerID"].ToString(),
                    };
                    customers.Add(customer);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return customers;
        }
        
        public bool RemoveCar(string carId)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                string sql = "DELETE FROM CarDB WHERE carid=@carid";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@carid", carId);

                conn.Open();
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
            return isSuccess;

        }
        public bool Removebooking(string bookingId)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                string sql = "DELETE FROM BookingDB WHERE booking_id=@booking_id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@booking_id", bookingId);

                conn.Open();
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
            return isSuccess;

        }

        public bool RemoveVan(string vanId)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                string sql = "DELETE FROM VanDB WHERE vanid=@vanid";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@vanid", vanId);

                conn.Open();
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
            return isSuccess;

        }

        public bool RemoveSuv(string suvId)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                string sql = "DELETE FROM SuvDB WHERE suvid=@suvid";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@suvid", suvId);

                conn.Open();
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
            return isSuccess;

        }
        public bool addDriver(Driver driver)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(connectionstring);
            try
            {
                string sql = "INSERT INTO DriversignupDB VALUES (@driverID, @name, @username, @email, @contact, @password, @gender, @district, @havevehicle, @vmake, @vmodel, @plateno, @driverlicenseno, @worktime, @availability, @dob)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                conn.Open();
                cmd.Parameters.AddWithValue("@name", driver.Firstname);
                cmd.Parameters.AddWithValue("@username", driver.Username);
                cmd.Parameters.AddWithValue("@email", driver.Email);
                cmd.Parameters.AddWithValue("@contact", driver.contact);
                cmd.Parameters.AddWithValue("@password", driver.password);
                cmd.Parameters.AddWithValue("@gender", driver.Gender);
                cmd.Parameters.AddWithValue("@district", driver.District);
                cmd.Parameters.AddWithValue("@havevehicle", driver.Havevehicle);
                cmd.Parameters.AddWithValue("@vmake", driver.vmake);
                cmd.Parameters.AddWithValue("@vmodel", driver.vmodel);
                cmd.Parameters.AddWithValue("@plateno", driver.plateno);
                cmd.Parameters.AddWithValue("@driverlicenseno", driver.license);
                cmd.Parameters.AddWithValue("@worktime", driver.Worktime);
                cmd.Parameters.AddWithValue("@driverID", driver.driverID);
                cmd.Parameters.AddWithValue("@availability", driver.available);
                cmd.Parameters.Add("@dob", SqlDbType.DateTime).Value = driver.DOB;

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }catch (Exception ex)
            {
                MessageBox.Show("An error occurred: from here" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        public bool removeDriver(string driverId)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                string sql = "DELETE FROM DriversignupDB WHERE driverID=@driverID";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@driverID", driverId);

                conn.Open();
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
            return isSuccess;
        }
        public bool removeDriverAvailability(string driverId)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                string sql = "UPDATE DriversignupDB SET availability = 'no' WHERE driverID = @driverID AND availability = 'yes'";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@driverID", driverId);

                conn.Open();
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
            return isSuccess;
        }
        public bool removeCustomer(string customerId)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                string sql = "DELETE FROM CustomersignupDB WHERE customerID=@customerID";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@customerID", customerId);

                conn.Open();
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
            return isSuccess;
        }

    }
}
