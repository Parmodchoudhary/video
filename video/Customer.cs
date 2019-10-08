using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace video
{
    public partial class Customer : Form
    {
        SqlDataAdapter adap = new SqlDataAdapter();//adapter object
        SqlConnection con = new SqlConnection();//connection
        SqlCommand com = new SqlCommand();//command
        DataSet d = new DataSet();//dataset
        public Customer()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.customer_Grid.Rows[e.RowIndex];//setting the index
                custid_text.Text = row.Cells[0].Value.ToString();//setting custid

                fname_text.Text = row.Cells[2].Value.ToString();//setting fname
                lname_text.Text = row.Cells[3].Value.ToString();//setting lname
                address_text.Text = row.Cells[4].Value.ToString();//setting address
                phone_text.Text = row.Cells[5].Value.ToString();//setting phone


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
             
            bool h = addcustomer(fname_text.Text, lname_text.Text, address_text.Text, phone_text.Text);//add customer
            if (h == true)
            {
                MessageBox.Show("Customer Added");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            bool g =  updatecustomer(custid_text.Text, fname_text.Text, lname_text.Text, address_text.Text, phone_text.Text);//update customer
            if (g == true)
            {
                MessageBox.Show("Customer Updated");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            deletecustomer(custid_text.Text);//delete customer
            fname_text.Text = "";
            lname_text.Text = "";
            address_text.Text = "";
            phone_text.Text = "";
            custid_text.Text = "";


            MessageBox.Show("Customer deleted");
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet6.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.database1DataSet6.Customer);

        }
        public bool addcustomer(string fname, string lname, string address, string phone)//add customer
        {
            con.Close();
            string str = connectionstrings();


            con.ConnectionString = str;
            com.CommandType = CommandType.Text;
            com.CommandText = "insert into Customer (FirstName,LastName,Address,Phone)values('" + fname + "','" + lname + "','" + address + "','" + phone + "')";

            adap.InsertCommand = com;
            com.Connection = con;
            con.Open();
            com.ExecuteNonQuery();
            return (true);
        }
        public bool updatecustomer(string custid, string fname, string lname, string address, string phone) //update customer
        {
            con.Close();
            string str = connectionstrings();


            con.ConnectionString = str;
            com.CommandType = CommandType.Text;
            com.CommandText = "update Customer set FirstName='" + fname + "',LastName='" + lname + "',Address='" + address + "',Phone='" + phone + "' where CustID=" + custid;

            adap.UpdateCommand = com;
            com.Connection = con;
            con.Open();
            com.ExecuteNonQuery();
            return (true);
        }
        public bool deletecustomer(string custid)//delete customer
        {
            con.Close();
            string str = connectionstrings();


            con.ConnectionString = str;
            com.CommandType = CommandType.Text;
            com.CommandText = "delete from Customer where CustID=" + custid;

            adap.DeleteCommand = com;
            com.Connection = con;
            con.Open();
            com.ExecuteNonQuery();
            return (true);
        }
        string connectionstrings()//connection string
        {
            return (@"Data Source=A2I-STUDENT\SQLEXPRESS;Initial Catalog=videorental;Integrated Security=True");

        }
    }
}
