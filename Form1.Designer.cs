namespace Assessment2Movies
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.tabCustomers = new System.Windows.Forms.TabPage();
            this.DGVCustomers = new System.Windows.Forms.DataGridView();
            this.tabMovies = new System.Windows.Forms.TabPage();
            this.DGVMovies = new System.Windows.Forms.DataGridView();
            this.tabRentals = new System.Windows.Forms.TabPage();
            this.DGVRentals = new System.Windows.Forms.DataGridView();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.btnDeleteMovie = new System.Windows.Forms.Button();
            this.btnUpdateMovie = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.lbxRating = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnIssue = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoOutRented = new System.Windows.Forms.RadioButton();
            this.rdoAllRented = new System.Windows.Forms.RadioButton();
            this.lblRentalID = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblMovieID = new System.Windows.Forms.Label();
            this.TabControl1.SuspendLayout();
            this.tabCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustomers)).BeginInit();
            this.tabMovies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMovies)).BeginInit();
            this.tabRentals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRentals)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.tabCustomers);
            this.TabControl1.Controls.Add(this.tabMovies);
            this.TabControl1.Controls.Add(this.tabRentals);
            this.TabControl1.Location = new System.Drawing.Point(3, 4);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(665, 293);
            this.TabControl1.TabIndex = 0;
            // 
            // tabCustomers
            // 
            this.tabCustomers.Controls.Add(this.DGVCustomers);
            this.tabCustomers.Location = new System.Drawing.Point(4, 22);
            this.tabCustomers.Name = "tabCustomers";
            this.tabCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomers.Size = new System.Drawing.Size(657, 267);
            this.tabCustomers.TabIndex = 0;
            this.tabCustomers.Text = "Customers";
            this.tabCustomers.UseVisualStyleBackColor = true;
            // 
            // DGVCustomers
            // 
            this.DGVCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVCustomers.Location = new System.Drawing.Point(3, 3);
            this.DGVCustomers.Name = "DGVCustomers";
            this.DGVCustomers.Size = new System.Drawing.Size(651, 261);
            this.DGVCustomers.TabIndex = 0;
            this.DGVCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCustomers_CellClick);
            // 
            // tabMovies
            // 
            this.tabMovies.Controls.Add(this.DGVMovies);
            this.tabMovies.Location = new System.Drawing.Point(4, 22);
            this.tabMovies.Name = "tabMovies";
            this.tabMovies.Padding = new System.Windows.Forms.Padding(3);
            this.tabMovies.Size = new System.Drawing.Size(657, 267);
            this.tabMovies.TabIndex = 1;
            this.tabMovies.Text = "Movies";
            this.tabMovies.UseVisualStyleBackColor = true;
            // 
            // DGVMovies
            // 
            this.DGVMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMovies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVMovies.Location = new System.Drawing.Point(3, 3);
            this.DGVMovies.Name = "DGVMovies";
            this.DGVMovies.Size = new System.Drawing.Size(651, 261);
            this.DGVMovies.TabIndex = 1;
            this.DGVMovies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVMovies_CellClick);
            // 
            // tabRentals
            // 
            this.tabRentals.Controls.Add(this.DGVRentals);
            this.tabRentals.Location = new System.Drawing.Point(4, 22);
            this.tabRentals.Name = "tabRentals";
            this.tabRentals.Size = new System.Drawing.Size(657, 267);
            this.tabRentals.TabIndex = 2;
            this.tabRentals.Text = "Rentals";
            this.tabRentals.UseVisualStyleBackColor = true;
            // 
            // DGVRentals
            // 
            this.DGVRentals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVRentals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVRentals.Location = new System.Drawing.Point(0, 0);
            this.DGVRentals.Name = "DGVRentals";
            this.DGVRentals.Size = new System.Drawing.Size(657, 267);
            this.DGVRentals.TabIndex = 1;
            this.DGVRentals.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVRentals_CellClick);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(12, 298);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(124, 57);
            this.btnAddCustomer.TabIndex = 1;
            this.btnAddCustomer.Text = "Add\r\nCustomer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Location = new System.Drawing.Point(13, 366);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(123, 23);
            this.btnAddMovie.TabIndex = 2;
            this.btnAddMovie.Text = "Add Movie";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            // 
            // btnDeleteMovie
            // 
            this.btnDeleteMovie.Location = new System.Drawing.Point(13, 400);
            this.btnDeleteMovie.Name = "btnDeleteMovie";
            this.btnDeleteMovie.Size = new System.Drawing.Size(123, 23);
            this.btnDeleteMovie.TabIndex = 3;
            this.btnDeleteMovie.Text = "Delete Movie";
            this.btnDeleteMovie.UseVisualStyleBackColor = true;
            // 
            // btnUpdateMovie
            // 
            this.btnUpdateMovie.Location = new System.Drawing.Point(143, 399);
            this.btnUpdateMovie.Name = "btnUpdateMovie";
            this.btnUpdateMovie.Size = new System.Drawing.Size(123, 23);
            this.btnUpdateMovie.TabIndex = 4;
            this.btnUpdateMovie.Text = "Update Movie";
            this.btnUpdateMovie.UseVisualStyleBackColor = true;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(142, 368);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(172, 20);
            this.txtTitle.TabIndex = 5;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(142, 333);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(124, 20);
            this.txtFirstName.TabIndex = 6;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(272, 333);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(126, 20);
            this.txtLastName.TabIndex = 7;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(404, 333);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(136, 20);
            this.txtAddress.TabIndex = 8;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(546, 333);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(112, 20);
            this.txtPhone.TabIndex = 9;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(320, 368);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(116, 20);
            this.txtYear.TabIndex = 10;
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Location = new System.Drawing.Point(142, 298);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(123, 23);
            this.btnUpdateCustomer.TabIndex = 13;
            this.btnUpdateCustomer.Text = "Update Customer";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(271, 298);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(123, 23);
            this.btnDeleteCustomer.TabIndex = 14;
            this.btnDeleteCustomer.Text = "Delete Customer";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            // 
            // lbxRating
            // 
            this.lbxRating.FormattingEnabled = true;
            this.lbxRating.Items.AddRange(new object[] {
            "G",
            "PG",
            "PG-13",
            "M",
            "R"});
            this.lbxRating.Location = new System.Drawing.Point(442, 368);
            this.lbxRating.Name = "lbxRating";
            this.lbxRating.Size = new System.Drawing.Size(52, 69);
            this.lbxRating.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Movie Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(401, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(543, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(439, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Rating";
            // 
            // btnIssue
            // 
            this.btnIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.ForeColor = System.Drawing.Color.DarkRed;
            this.btnIssue.Location = new System.Drawing.Point(500, 368);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(61, 37);
            this.btnIssue.TabIndex = 23;
            this.btnIssue.Text = "Issue\r\nMovie";
            this.btnIssue.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnReturn.Location = new System.Drawing.Point(577, 368);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(61, 37);
            this.btnReturn.TabIndex = 24;
            this.btnReturn.Text = "Return\r\nMovie";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.rdoOutRented);
            this.groupBox1.Controls.Add(this.rdoAllRented);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(500, 405);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 33);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rented Movies";
            // 
            // rdoOutRented
            // 
            this.rdoOutRented.AutoSize = true;
            this.rdoOutRented.Location = new System.Drawing.Point(77, 14);
            this.rdoOutRented.Name = "rdoOutRented";
            this.rdoOutRented.Size = new System.Drawing.Size(80, 17);
            this.rdoOutRented.TabIndex = 1;
            this.rdoOutRented.TabStop = true;
            this.rdoOutRented.Text = "Out Rented";
            this.rdoOutRented.UseVisualStyleBackColor = true;
            // 
            // rdoAllRented
            // 
            this.rdoAllRented.AutoSize = true;
            this.rdoAllRented.Location = new System.Drawing.Point(7, 14);
            this.rdoAllRented.Name = "rdoAllRented";
            this.rdoAllRented.Size = new System.Drawing.Size(74, 17);
            this.rdoAllRented.TabIndex = 0;
            this.rdoAllRented.TabStop = true;
            this.rdoAllRented.Text = "All Rented";
            this.rdoAllRented.UseVisualStyleBackColor = true;
            // 
            // lblRentalID
            // 
            this.lblRentalID.AutoSize = true;
            this.lblRentalID.Location = new System.Drawing.Point(294, 419);
            this.lblRentalID.Name = "lblRentalID";
            this.lblRentalID.Size = new System.Drawing.Size(13, 13);
            this.lblRentalID.TabIndex = 26;
            this.lblRentalID.Text = "0";
            this.lblRentalID.Visible = false;
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(313, 419);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(13, 13);
            this.lblCustomerID.TabIndex = 27;
            this.lblCustomerID.Text = "0";
            this.lblCustomerID.Visible = false;
            // 
            // lblMovieID
            // 
            this.lblMovieID.AutoSize = true;
            this.lblMovieID.Location = new System.Drawing.Point(332, 419);
            this.lblMovieID.Name = "lblMovieID";
            this.lblMovieID.Size = new System.Drawing.Size(13, 13);
            this.lblMovieID.TabIndex = 28;
            this.lblMovieID.Text = "0";
            this.lblMovieID.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 450);
            this.Controls.Add(this.lblMovieID);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.lblRentalID);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxRating);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.btnUpdateMovie);
            this.Controls.Add(this.btnDeleteMovie);
            this.Controls.Add(this.btnAddMovie);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.TabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TabControl1.ResumeLayout(false);
            this.tabCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustomers)).EndInit();
            this.tabMovies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVMovies)).EndInit();
            this.tabRentals.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVRentals)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl1;
        private System.Windows.Forms.TabPage tabCustomers;
        private System.Windows.Forms.TabPage tabMovies;
        private System.Windows.Forms.TabPage tabRentals;
        private System.Windows.Forms.DataGridView DGVCustomers;
        private System.Windows.Forms.DataGridView DGVMovies;
        private System.Windows.Forms.DataGridView DGVRentals;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Button btnDeleteMovie;
        private System.Windows.Forms.Button btnUpdateMovie;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.ListBox lbxRating;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoOutRented;
        private System.Windows.Forms.RadioButton rdoAllRented;
        private System.Windows.Forms.Label lblRentalID;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblMovieID;
    }
}

