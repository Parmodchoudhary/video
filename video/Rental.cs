using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace video
{
    public partial class Rental : Form
    {
        SqlDataAdapter adap = new SqlDataAdapter();//adapter class
        SqlConnection con = new SqlConnection();//connection
        SqlCommand com = new SqlCommand();//sql command
        DataSet d = new DataSet();//dataset
        public Rental()//constructor
        {
            InitializeComponent();
        }
        string connectionstrings()//connectiostring
        {
            return (@"Data Source=A2I-STUDENT\SQLEXPRESS;Initial Catalog=videorental;Integrated Security=True");

        }
        private void button7_Click(object sender, EventArgs e)
        {
            
            bool check = issuemovie(movieid_text.Text, Custid_text.Text, rentdate_text.Text);//issue movie method
            if (check == true)
            {
                MessageBox.Show("Movie Issued");
            }
        }

        private void Rental_Load(object sender, EventArgs e)//rental load
        {
            // TODO: This line of code loads data into the 'database1DataSet5.RentedMovies' table. You can move, or remove it, as needed.
            this.rentedMoviesTableAdapter.Fill(this.database1DataSet5.RentedMovies);

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.rentalGrid.Rows[e.RowIndex];

                RMID_text.Text = row.Cells[0].Value.ToString();

                movieid_text.Text = row.Cells[1].Value.ToString();//setting the movie text
                Custid_text.Text = row.Cells[2].Value.ToString();//setting the customerid
                rentdate_text.Text = row.Cells[3].Value.ToString();//setting the rent date
                returndate_text.Text = row.Cells[4].Value.ToString();//setting return date


            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            bool check = returnmovie(RMID_text.Text, returndate_text.Text);// will return date
            if (check == true)
            {
                MessageBox.Show("Movie retunrned");
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            DataSet f = showcurrent();
            dataGridView4.DataSource = f.Tables[0];//calling the object
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
            DataSet f1 = mostpopular();
            dataGridView4.DataSource = f1.Tables[0];// datagrid stting
        }
        public bool issuemovie(string movieid, string custid, string daterented)
        {
            con.Close();
            string str = connectionstrings();//conenction string


            con.ConnectionString = str;
            com.CommandType = CommandType.Text;
            com.CommandText = "insert into RentedMovies (MovieIDFK,CustIDFK,DateRented)values(" + movieid + "," + custid + ",'" + daterented + "')";//insert command

            adap.InsertCommand = com;
            com.Connection = con;
            con.Open();
            com.ExecuteNonQuery();
            return (true);
        }
        public bool returnmovie(string rmid, string returndate)//returning movie
        {
            con.Close();
            string str = connectionstrings();


            con.ConnectionString = str;
            com.CommandType = CommandType.Text;
            com.CommandText = "update RentedMovies set DateReturned='" + returndate + "' where RMID=" + rmid;

            adap.UpdateCommand = com;
            com.Connection = con;
            con.Open();
            com.ExecuteNonQuery();
            return (true);
        }
        public DataSet showcurrent()//show current
        {
            string str = connectionstrings();
            con.Close();
            con.ConnectionString = str;
            com.CommandType = CommandType.Text;
            com.CommandText = "select * from Movies where year='2019'";
            adap.SelectCommand = com;
            com.Connection = con;
            con.Open();
            adap.Fill(d);
            return (d);
        }
        public DataSet mostpopular()//most popular
        {
            string str = connectionstrings();
            con.Close();
            con.ConnectionString = str;
            com.CommandType = CommandType.Text;
            com.CommandText = "select * from Movies where  MovieID in (select MovieIDFK from RentedMovies)";
            adap.SelectCommand = com;
            com.Connection = con;
            con.Open();
            adap.Fill(d);
            return (d);
        }
    }
}
