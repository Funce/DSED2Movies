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
    }
}
