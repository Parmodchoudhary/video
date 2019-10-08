namespace video
{
    partial class Rental
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.datereturned_date = new System.Windows.Forms.Label();
            this.rentedate_label = new System.Windows.Forms.Label();
            this.custid_label = new System.Windows.Forms.Label();
            this.movieid_label = new System.Windows.Forms.Label();
            this.rmid_label = new System.Windows.Forms.Label();
            this.returndate_text = new System.Windows.Forms.TextBox();
            this.rentdate_text = new System.Windows.Forms.TextBox();
            this.Custid_text = new System.Windows.Forms.TextBox();
            this.movieid_text = new System.Windows.Forms.TextBox();
            this.RMID_text = new System.Windows.Forms.TextBox();
            this.rentedout_ = new System.Windows.Forms.RadioButton();
            this.allrent_radio = new System.Windows.Forms.RadioButton();
            this.return_button = new System.Windows.Forms.Button();
            this.issue_button = new System.Windows.Forms.Button();
            this.rentalGrid = new System.Windows.Forms.DataGridView();
            this.rMIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieIDFKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custIDFKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateRentedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateReturnedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentedMoviesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet5 = new video.Database1DataSet5();
            this.rentedMoviesTableAdapter = new video.Database1DataSet5TableAdapters.RentedMoviesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentedMoviesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(2, 375);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(842, 162);
            this.dataGridView4.TabIndex = 37;
            // 
            // datereturned_date
            // 
            this.datereturned_date.AutoSize = true;
            this.datereturned_date.Location = new System.Drawing.Point(598, 193);
            this.datereturned_date.Name = "datereturned_date";
            this.datereturned_date.Size = new System.Drawing.Size(101, 17);
            this.datereturned_date.TabIndex = 36;
            this.datereturned_date.Text = "Date Returned";
            // 
            // rentedate_label
            // 
            this.rentedate_label.AutoSize = true;
            this.rentedate_label.Location = new System.Drawing.Point(602, 150);
            this.rentedate_label.Name = "rentedate_label";
            this.rentedate_label.Size = new System.Drawing.Size(88, 17);
            this.rentedate_label.TabIndex = 35;
            this.rentedate_label.Text = "Rented Date";
            // 
            // custid_label
            // 
            this.custid_label.AutoSize = true;
            this.custid_label.Location = new System.Drawing.Point(641, 113);
            this.custid_label.Name = "custid_label";
            this.custid_label.Size = new System.Drawing.Size(49, 17);
            this.custid_label.TabIndex = 34;
            this.custid_label.Text = "CustID";
            // 
            // movieid_label
            // 
            this.movieid_label.AutoSize = true;
            this.movieid_label.Location = new System.Drawing.Point(641, 74);
            this.movieid_label.Name = "movieid_label";
            this.movieid_label.Size = new System.Drawing.Size(58, 17);
            this.movieid_label.TabIndex = 33;
            this.movieid_label.Text = "MovieID";
            // 
            // rmid_label
            // 
            this.rmid_label.AutoSize = true;
            this.rmid_label.Location = new System.Drawing.Point(657, 27);
            this.rmid_label.Name = "rmid_label";
            this.rmid_label.Size = new System.Drawing.Size(42, 17);
            this.rmid_label.TabIndex = 32;
            this.rmid_label.Text = "RMID";
            // 
            // returndate_text
            // 
            this.returndate_text.Location = new System.Drawing.Point(718, 193);
            this.returndate_text.Name = "returndate_text";
            this.returndate_text.Size = new System.Drawing.Size(100, 22);
            this.returndate_text.TabIndex = 31;
            // 
            // rentdate_text
            // 
            this.rentdate_text.Location = new System.Drawing.Point(718, 145);
            this.rentdate_text.Name = "rentdate_text";
            this.rentdate_text.Size = new System.Drawing.Size(100, 22);
            this.rentdate_text.TabIndex = 30;
            // 
            // Custid_text
            // 
            this.Custid_text.Location = new System.Drawing.Point(718, 110);
            this.Custid_text.Name = "Custid_text";
            this.Custid_text.Size = new System.Drawing.Size(100, 22);
            this.Custid_text.TabIndex = 29;
            // 
            // movieid_text
            // 
            this.movieid_text.Location = new System.Drawing.Point(718, 69);
            this.movieid_text.Name = "movieid_text";
            this.movieid_text.Size = new System.Drawing.Size(100, 22);
            this.movieid_text.TabIndex = 28;
            // 
            // RMID_text
            // 
            this.RMID_text.Location = new System.Drawing.Point(718, 27);
            this.RMID_text.Name = "RMID_text";
            this.RMID_text.Size = new System.Drawing.Size(100, 22);
            this.RMID_text.TabIndex = 27;
            // 
            // rentedout_
            // 
            this.rentedout_.AutoSize = true;
            this.rentedout_.Location = new System.Drawing.Point(705, 235);
            this.rentedout_.Name = "rentedout_";
            this.rentedout_.Size = new System.Drawing.Size(102, 21);
            this.rentedout_.TabIndex = 26;
            this.rentedout_.TabStop = true;
            this.rentedout_.Text = "Out Rented";
            this.rentedout_.UseVisualStyleBackColor = true;
            this.rentedout_.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // allrent_radio
            // 
            this.allrent_radio.AutoSize = true;
            this.allrent_radio.Location = new System.Drawing.Point(605, 235);
            this.allrent_radio.Name = "allrent_radio";
            this.allrent_radio.Size = new System.Drawing.Size(94, 21);
            this.allrent_radio.TabIndex = 25;
            this.allrent_radio.TabStop = true;
            this.allrent_radio.Text = "All Rented";
            this.allrent_radio.UseVisualStyleBackColor = true;
            this.allrent_radio.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // return_button
            // 
            this.return_button.Location = new System.Drawing.Point(705, 277);
            this.return_button.Name = "return_button";
            this.return_button.Size = new System.Drawing.Size(106, 48);
            this.return_button.TabIndex = 24;
            this.return_button.Text = "Return Movie";
            this.return_button.UseVisualStyleBackColor = true;
            this.return_button.Click += new System.EventHandler(this.button8_Click);
            // 
            // issue_button
            // 
            this.issue_button.Location = new System.Drawing.Point(578, 277);
            this.issue_button.Name = "issue_button";
            this.issue_button.Size = new System.Drawing.Size(121, 48);
            this.issue_button.TabIndex = 23;
            this.issue_button.Text = "Issue Movie";
            this.issue_button.UseVisualStyleBackColor = true;
            this.issue_button.Click += new System.EventHandler(this.button7_Click);
            // 
            // rentalGrid
            // 
            this.rentalGrid.AutoGenerateColumns = false;
            this.rentalGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentalGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rMIDDataGridViewTextBoxColumn,
            this.movieIDFKDataGridViewTextBoxColumn,
            this.custIDFKDataGridViewTextBoxColumn,
            this.dateRentedDataGridViewTextBoxColumn,
            this.dateReturnedDataGridViewTextBoxColumn});
            this.rentalGrid.DataSource = this.rentedMoviesBindingSource;
            this.rentalGrid.Location = new System.Drawing.Point(30, 27);
            this.rentalGrid.Name = "rentalGrid";
            this.rentalGrid.RowTemplate.Height = 24;
            this.rentalGrid.Size = new System.Drawing.Size(542, 298);
            this.rentalGrid.TabIndex = 22;
            this.rentalGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // rMIDDataGridViewTextBoxColumn
            // 
            this.rMIDDataGridViewTextBoxColumn.DataPropertyName = "RMID";
            this.rMIDDataGridViewTextBoxColumn.HeaderText = "RMID";
            this.rMIDDataGridViewTextBoxColumn.Name = "rMIDDataGridViewTextBoxColumn";
            this.rMIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // movieIDFKDataGridViewTextBoxColumn
            // 
            this.movieIDFKDataGridViewTextBoxColumn.DataPropertyName = "MovieIDFK";
            this.movieIDFKDataGridViewTextBoxColumn.HeaderText = "MovieIDFK";
            this.movieIDFKDataGridViewTextBoxColumn.Name = "movieIDFKDataGridViewTextBoxColumn";
            // 
            // custIDFKDataGridViewTextBoxColumn
            // 
            this.custIDFKDataGridViewTextBoxColumn.DataPropertyName = "CustIDFK";
            this.custIDFKDataGridViewTextBoxColumn.HeaderText = "CustIDFK";
            this.custIDFKDataGridViewTextBoxColumn.Name = "custIDFKDataGridViewTextBoxColumn";
            // 
            // dateRentedDataGridViewTextBoxColumn
            // 
            this.dateRentedDataGridViewTextBoxColumn.DataPropertyName = "DateRented";
            this.dateRentedDataGridViewTextBoxColumn.HeaderText = "DateRented";
            this.dateRentedDataGridViewTextBoxColumn.Name = "dateRentedDataGridViewTextBoxColumn";
            // 
            // dateReturnedDataGridViewTextBoxColumn
            // 
            this.dateReturnedDataGridViewTextBoxColumn.DataPropertyName = "DateReturned";
            this.dateReturnedDataGridViewTextBoxColumn.HeaderText = "DateReturned";
            this.dateReturnedDataGridViewTextBoxColumn.Name = "dateReturnedDataGridViewTextBoxColumn";
            // 
            // rentedMoviesBindingSource
            // 
            this.rentedMoviesBindingSource.DataMember = "RentedMovies";
            this.rentedMoviesBindingSource.DataSource = this.database1DataSet5;
            // 
            // database1DataSet5
            // 
            this.database1DataSet5.DataSetName = "Database1DataSet5";
            this.database1DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rentedMoviesTableAdapter
            // 
            this.rentedMoviesTableAdapter.ClearBeforeFill = true;
            // 
            // Rental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 538);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.datereturned_date);
            this.Controls.Add(this.rentedate_label);
            this.Controls.Add(this.custid_label);
            this.Controls.Add(this.movieid_label);
            this.Controls.Add(this.rmid_label);
            this.Controls.Add(this.returndate_text);
            this.Controls.Add(this.rentdate_text);
            this.Controls.Add(this.Custid_text);
            this.Controls.Add(this.movieid_text);
            this.Controls.Add(this.RMID_text);
            this.Controls.Add(this.rentedout_);
            this.Controls.Add(this.allrent_radio);
            this.Controls.Add(this.return_button);
            this.Controls.Add(this.issue_button);
            this.Controls.Add(this.rentalGrid);
            this.Name = "Rental";
            this.Text = "Rental";
            this.Load += new System.EventHandler(this.Rental_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentedMoviesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Label datereturned_date;
        private System.Windows.Forms.Label rentedate_label;
        private System.Windows.Forms.Label custid_label;
        private System.Windows.Forms.Label movieid_label;
        private System.Windows.Forms.Label rmid_label;
        private System.Windows.Forms.TextBox returndate_text;
        private System.Windows.Forms.TextBox rentdate_text;
        private System.Windows.Forms.TextBox Custid_text;
        private System.Windows.Forms.TextBox movieid_text;
        private System.Windows.Forms.TextBox RMID_text;
        private System.Windows.Forms.RadioButton rentedout_;
        private System.Windows.Forms.RadioButton allrent_radio;
        private System.Windows.Forms.Button return_button;
        private System.Windows.Forms.Button issue_button;
        private System.Windows.Forms.DataGridView rentalGrid;
        private Database1DataSet5 database1DataSet5;
        private System.Windows.Forms.BindingSource rentedMoviesBindingSource;
        private Database1DataSet5TableAdapters.RentedMoviesTableAdapter rentedMoviesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rMIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieIDFKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custIDFKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateRentedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateReturnedDataGridViewTextBoxColumn;
    }
}