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
    public partial class Movies : Form
    {
        SqlDataAdapter adap = new SqlDataAdapter();//adapter of sql
        SqlConnection con = new SqlConnection();//connection of sql
        SqlCommand com = new SqlCommand();//command of sql
        DataSet d = new DataSet();//dataset of sql
        public Movies()//constructor
        {
            InitializeComponent();
        }
        string connectionstrings()// connection string method
        {
            return (@"Data Source=A2I-STUDENT\SQLEXPRESS;Initial Catalog=videorental;Integrated Security=True");

        }
        private void Movies_Load(object sender, EventArgs e)//form load function
        {
            // TODO: This line of code loads data into the 'database1DataSet3.Movies' table. You can move, or remove it, as needed.
            this.moviesTableAdapter.Fill(this.database1DataSet3.Movies);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (e.RowIndex >= 0)//check the rowindex
                {
                    DataGridViewRow row = this.movie_Grid.Rows[e.RowIndex];//pick the row index
                    moveid_text.Text = row.Cells[0].Value.ToString();//will get the vale for moveid
                    rating_text.Text = row.Cells[1].Value.ToString();//will get the vale for rating
                    title_text.Text = row.Cells[2].Value.ToString();//will get the vale for title
                    year_text.Text = row.Cells[3].Value.ToString();//will get the vale for year
                    rentalcost_text.Text = row.Cells[4].Value.ToString();//will get the vale for rental cost
                    copies_text.Text = row.Cells[5].Value.ToString();//will get the vale for copies
                    plot_text.Text = row.Cells[6].Value.ToString();//will get the vale for plot
                    genre_text.Text = row.Cells[7].Value.ToString();//will get the vale for genre


                }
            }
            catch (Exception e1)
            {
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            bool check = insertnewmovie(moveid_text.Text, rating_text.Text, title_text.Text, year_text.Text, copies_text.Text, plot_text.Text, genre_text.Text);// call the function
            if (check == true)
            {
                MessageBox.Show("New Movie Inserted");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            bool check = updatemovie(moveid_text.Text, rating_text.Text, title_text.Text, year_text.Text, copies_text.Text, plot_text.Text, genre_text.Text);// call update movie
            MessageBox.Show("Updated");
        }

        private void button5_Click(object sender, EventArgs e)
        {

            
            bool check = deletemovie(moveid_text.Text);// will call delete method
            if (check == true)
            {
                MessageBox.Show("Movie Deleted");//messagebox
                rating_text.Text = "";//empty up the field
                title_text.Text = "";
                year_text.Text = "";
                rentalcost_text.Text = "";
                copies_text.Text = "";
                plot_text.Text = "";
                genre_text.Text = "";
                

                            }
        }
        
        public int getmaxmovieid()
        {
            string str = connectionstrings();//conenction string
            con.Close();//closing the connection
            con.ConnectionString = str;
            com.CommandType = CommandType.Text;
            com.CommandText = "select max(MovieID) from Movies";//command text
            adap.SelectCommand = com;//select command
            com.Connection = con;
            con.Open();
            adap.Fill(d);//fill the adapter
            int id = Convert.ToInt16(d.Tables[0].Rows[0][0]);// assiging the ID
            return (id);
        }
        public bool insertnewmovie(string movieid, string rating, string title, string year, string copies, string plot, string genre)
        {
            con.Close();
            string str = connectionstrings();//conenctionstring
            int year1 = Convert.ToInt16(year);//year
            string rent = "";//empty up
            if (2019 - year1 > 5)//checking the year condition
            {
                rent = "2";
            }
            else
            {
                rent = "5";
            }

            con.ConnectionString = str;// conenctionstring
            com.CommandType = CommandType.Text;//command text
            com.CommandText = "insert into Movies values('" + rating + "','" + title + "','" + year + "'," + rent + ",'" + copies + "','" + plot + "','" + genre + "')";

            adap.InsertCommand = com;//insert command
            com.Connection = con;//connection
            con.Open();
            com.ExecuteNonQuery();//call the command
            return (true);
        }
        public DataSet moviedata(string movieid)//function for movie data
        {
            string str = connectionstrings();
            con.Close();
            con.ConnectionString = str;
            com.CommandType = CommandType.Text;
            com.CommandText = "select * from Movies where movieid=" + movieid;
            adap.SelectCommand = com;
            com.Connection = con;
            con.Open();
            adap.Fill(d);
            return (d);
        }
        public bool updatemovie(string movieid, string rating, string title, string year, string copies, string plot, string genre)//update the movie
        {
            con.Close();
            string str = connectionstrings();
            int year1 = Convert.ToInt16(year);
            string rent = "";
            if (2019 - year1 > 5)
            {
                rent = "2";
            }
            else
            {
                rent = "5";
            }

            con.ConnectionString = str;
            com.CommandType = CommandType.Text;

            com.CommandText = "update Movies set Rating='" + rating + "',Title='" + title + "',Year='" + year + "',Rental_Cost=" + rent + ",Copies='" + copies + "',Genre='" + genre + "' where MovieID=" + movieid;

            adap.UpdateCommand = com;
            com.Connection = con;
            con.Open();
            com.ExecuteNonQuery();
            return (true);
        }
        public bool deletemovie(string movieid) // comment for delete 
        {
            con.Close();
            string str = connectionstrings();


            con.ConnectionString = str;
            com.CommandType = CommandType.Text;
            com.CommandText = "delete Movies where MovieID=" + movieid;

            adap.DeleteCommand = com;
            com.Connection = con;
            con.Open();
            com.ExecuteNonQuery();
            return (true);
        }

    }
}
