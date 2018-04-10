using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment2Movies
{
    class Database
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
    }
}
