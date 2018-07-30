using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment2Movies
{
    public class Database
    {
        //Create connection and Command and an Adapter
        private SqlConnection Connection = new SqlConnection();
        private SqlCommand Command = new SqlCommand();
        private SqlDataAdapter da = new SqlDataAdapter();

        public Database()
        {
            string connectionString =
                @"Data Source=CAMERON-GO\WORKINGSQL14;Initial Catalog=MoviesDSED02Assess;Integrated Security=True";
            Connection.ConnectionString = connectionString;
            Command.Connection = Connection;
        }

        //SHOWING DATA

        public DataTable FillDGVCustomerWithCustomers()
        {
            //Create a datatable as we only require one??
            DataTable dt = new DataTable();
            using (da = new SqlDataAdapter("SELECT * from Customer", Connection))
            {
                //Get results of query
                Connection.Open();
                //Fill the table from the Database
                da.Fill(dt);
                //Close the connection
                Connection.Close();
            }

            return dt;
        }
        public DataTable FillDGVMoviesWithMovies()
        {
            //Create a datatable as we only require one??
            DataTable dt = new DataTable();
            using (da = new SqlDataAdapter("SELECT * from MovieDGV", Connection))
            {
                //Get results of query
                Connection.Open();
                //Fill the table from the Database
                da.Fill(dt);
                //Close the connection
                Connection.Close();
            }

            return dt;
        }
        public DataTable FillDGVRentalsWithRentedMovies(bool Out_only)
        {
            //Create a datatable as we only require one??
            DataTable dt = new DataTable();
            //If the radio button is pressed
            string sqlQuery;
            if (Out_only)
            {
                sqlQuery = "SELECT * FROM RentedDGV WHERE DateReturned IS NULL";
            }
            else
            {
                sqlQuery = "SELECT * FROM RentedDGV";
            }
            using (da = new SqlDataAdapter(sqlQuery, Connection))
            {
                //Get results of query
                Connection.Open();
                //Fill the table from the Database
                da.Fill(dt);
                //Close the connection
                Connection.Close();
            }

            return dt;
        }

        //MODIFICATIONS TO CUSTOMER TABLE

        public string AddCustomer(string FirstName, string LastName, string Address, string Phone)
        {
            using (var queryCommand = new SqlCommand("INSERT INTO Customer (FirstName, LastName, Address, Phone) " +
                                                     "VALUES (@FirstName, @LastName, @Address, @Phone)", Connection))
            {
                //Parameters are SECURE
                queryCommand.Parameters.AddWithValue("@FirstName", FirstName);
                queryCommand.Parameters.AddWithValue("@LastName", LastName);
                queryCommand.Parameters.AddWithValue("@Address", Address);
                queryCommand.Parameters.AddWithValue("@Phone", Phone);
                Connection.Open();
                queryCommand.ExecuteNonQuery();
                Connection.Close();

                return " is Successful";
            }
        }

        public string UpdateCustomer(string FirstName, string LastName, string Address, string Phone, string ID)
        {
            //Update the customer's details
            using (var queryCommand = new SqlCommand("UPDATE Customer " +
                                                     "SET FirstName = @FirstName, LastName = @LastName, Address = @Address, Phone = @Phone " +
                                                     "WHERE CustID = @ID", Connection))
            {
                //Parameters are SECURE
                queryCommand.Parameters.AddWithValue("@FirstName", FirstName);
                queryCommand.Parameters.AddWithValue("@LastName", LastName);
                queryCommand.Parameters.AddWithValue("@Address", Address);
                queryCommand.Parameters.AddWithValue("@Phone", Phone);
                queryCommand.Parameters.AddWithValue("@ID", Convert.ToInt16(ID));
                Connection.Open();
                queryCommand.ExecuteNonQuery();
                Connection.Close();

                return " is Successful";
            }

        }
        public string DeleteCustomer(string ID)
        {
            //Remove the customer from the database
            using (var queryCommand = new SqlCommand("DELETE FROM Customer WHERE CustID = @ID", Connection))
            {
                //Parameters are SECURE
                queryCommand.Parameters.AddWithValue("@ID", Convert.ToInt16(ID));
                Connection.Open();
                queryCommand.ExecuteNonQuery();
                Connection.Close();

                return " is Successful";
            }

        }

        //MODIFICATIONS TO MOVIE TABLE

        public int GetRentalCost(string Year)
        {
            //Rental cost is $2 if the release year is more than 5 years ago
            //otherwise its $5
            int target = Convert.ToInt16(Year);
            int Rental_Cost;
            if (target > DateTime.Today.AddYears(-5).Year)
            {
                Rental_Cost = 5;
            }
            else
            {
                Rental_Cost = 2;
            }

            return Rental_Cost;
        }


        public string AddMovie(string Title, string Year, string Rating)
        {
            //Add a brand new movie!
            using (var queryCommand = new SqlCommand("INSERT INTO Movies (Title, Year, Rating, Rental_Cost) " +
                                                     "VALUES (@Title, @Year, @Rating, @Rental_Cost)", Connection))
            {

                //Rental cost is $2 if the release year is more than 5 years ago
                //otherwise its $5
                int Rental_Cost = GetRentalCost(Year);

                //Parameters are SECURE
                queryCommand.Parameters.AddWithValue("@Title", Title);
                queryCommand.Parameters.AddWithValue("@Year", Year);
                queryCommand.Parameters.AddWithValue("@Rating", Rating);
                queryCommand.Parameters.AddWithValue("@Rental_Cost", Rental_Cost);
                Connection.Open();
                queryCommand.ExecuteNonQuery();
                Connection.Close();

                return " is Successful";
            }
        }

        public string UpdateMovie(string Title, string Year, string Rating, string ID)
        {
            //Update the movie details
            using (var queryCommand = new SqlCommand("UPDATE Movies " +
                                                     "SET Title = @Title, Year = @Year, Rating = @Rating " +
                                                     "WHERE MovieID = @ID", Connection))
            {
                //Parameters are SECURE
                queryCommand.Parameters.AddWithValue("@Title", Title);
                queryCommand.Parameters.AddWithValue("@Year", Year);
                queryCommand.Parameters.AddWithValue("@Rating", Rating);
                queryCommand.Parameters.AddWithValue("@ID", Convert.ToInt16(ID));
                Connection.Open();
                queryCommand.ExecuteNonQuery();
                Connection.Close();

                return " is Successful";
            }

        }
        public string DeleteMovie(string ID)
        {
            //Remove the movie from the database
            using (var queryCommand = new SqlCommand("DELETE FROM Movies WHERE MovieID = @ID", Connection))
            {
                //Parameters are SECURE
                queryCommand.Parameters.AddWithValue("@ID", Convert.ToInt16(ID));
                Connection.Open();
                queryCommand.ExecuteNonQuery();
                Connection.Close();

                return " is Successful";
            }
        }
        public string IssueRental(string custID, string movieID)
        {
            //Remove the movie from the database
            using (var queryCommand = new SqlCommand("INSERT INTO RentedMovies (CustIDFK, MovieIDFK, DateRented) VALUES (@custID, @movieID, GETUTCDATE())", Connection))
            {
                //Parameters are SECURE
                queryCommand.Parameters.AddWithValue("@custID", custID);
                queryCommand.Parameters.AddWithValue("@movieID", movieID);
                Connection.Open();
                queryCommand.ExecuteNonQuery();
                Connection.Close();

                return " is Successful";
            }
        }
        public string ReturnRental(string ID)
        {
            //Update the movie details
            using (var queryCommand = new SqlCommand("UPDATE RentedMovies " +
                                                     "SET DateReturned = GETUTCDATE() " +
                                                     "WHERE RMID = @ID", Connection))
            {
                //Parameters are SECURE
                queryCommand.Parameters.AddWithValue("@ID", Convert.ToInt16(ID));
                Connection.Open();
                queryCommand.ExecuteNonQuery();
                Connection.Close();

                return " is Successful";
            }

        }
    }
}
