using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment2Movies
{
    public partial class Form1 : Form
    {
        private Database myDatabase = new Database();
        public Form1()
        {
            InitializeComponent();
            loadDB();
        }

        public void loadDB()
        {
            //Load the customers
            DisplayDataGridViewCustomers();
            DisplayDataGridViewMovies();
            DisplayDataGridViewRentals();
        }

        private void DisplayDataGridViewCustomers()
        {
            //Clear out the old data
            DGVCustomers.DataSource = null;
            try
            {
                //Pass the datatable to the DataGridView
                DGVCustomers.DataSource = myDatabase.FillDGVCustomerWithCustomers();
                DGVCustomers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DisplayDataGridViewMovies()
        {
            //Clear out the old data
            DGVMovies.DataSource = null;
            try
            {
                //Pass the datatable to the DataGridView
                DGVMovies.DataSource = myDatabase.FillDGVMoviesWithMovies();
                DGVMovies.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisplayDataGridViewRentals()
        {
            //Clear out the old data
            DGVRentals.DataSource = null;
            try
            {
                //Pass the datatable to the DataGridView

                DGVRentals.DataSource = myDatabase.FillDGVRentalsWithRentedMovies();
                DGVRentals.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Make the DGV clicks enter the right values
        private void DGVRentals_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblRentalID.Text = DGVRentals.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch
            {
            }
        }

        private void DGVCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //show the data in the DGV in the text boxes
                string newvalue = DGVCustomers.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                //show the output on the header
                this.Text = "Row : " + e.RowIndex.ToString() + " Col : " +
                            e.ColumnIndex.ToString() + " Value = " + newvalue;
                //pass data to the text boxes
                lblCustomerID.Text = DGVCustomers.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtFirstName.Text = DGVCustomers.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtLastName.Text = DGVCustomers.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtAddress.Text = DGVCustomers.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtPhone.Text = DGVCustomers.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch
            {
            }
        }
        private void DGVMovies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //show the data in the DGV in the text boxes
                string newvalue = DGVMovies.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                //show the output on the header
                this.Text = "Row : " + e.RowIndex.ToString() + " Col : " +
                            e.ColumnIndex.ToString() + " Value = " + newvalue;
                //pass data to the text boxes
                lblMovieID.Text = DGVMovies.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTitle.Text = DGVMovies.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtYear.Text = DGVMovies.Rows[e.RowIndex].Cells[2].Value.ToString();
                lbxRating.SelectedIndex = -1;
                int currentRating = lbxRating.Items.IndexOf(DGVMovies.Rows[e.RowIndex].Cells[3].Value.ToString());
                lbxRating.SelectedIndex = currentRating;

            }
            catch
            {
            }
        }
    }
}
