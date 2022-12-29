using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseProject
{
    public partial class Form17 : Form
    {
        Form2 f2;
        const string constr = @"Data Source = ROHAN-PC\SPARTA; Initial Catalog = dbproj ;Integrated Security = SSPI";
        SqlConnection con = new SqlConnection(constr);
        SqlCommand cm = new SqlCommand();
        
        public Form17(Form2 frm2)
        {
            InitializeComponent();
            this.f2 = frm2;
        }

        private void LoadCustomerBookings()
        {
            // TODO: Complete the function LoadOrders
            // SQL Query to Select all records from orders table in the descending order of order date
            con.Open();
            string sql = "select [bookingdetails].booking_id, [CarDetails].model as Car, ([EmployeeDetails].first_name + ' ' + [EmployeeDetails].last_name) as 'Salesperson' , ([CustomerDetails].first_name + ' ' + [CustomerDetails].last_name) as 'Customer' , [bookingdetails].booking_date , [bookingdetails].delivery_date from [bookingdetails], [customerdetails],[cardetails],[employeedetails] where [bookingdetails].customer_id = [customerdetails].customer_id and [bookingdetails].car_id = [CarDetails].car_id and [bookingdetails].salesperson_id = [EmployeeDetails].salesperson_id and [customerdetails].first_name = '" + "Hunain" + "' ";
            cm = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable d = new DataTable();
            da.Fill(d);
            cm.Dispose();
            con.Close();
            dataGridView1.DataSource = d;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }

        private void LoadTransactions()
        {
            // TODO: Complete the function LoadOrders
            // SQL Query to Select all records from orders table in the descending order of order date
            con.Open();
            string sql = "select * from [bookingtranscaction] where booking_id in (select booking_id from [bookingdetails] where customer_id in (select customer_id from [customerdetails] where first_name = '" + "Hunain" + "')) ";
            cm = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable d = new DataTable();
            da.Fill(d);
            cm.Dispose();
            con.Close();
            dataGridView2.DataSource = d;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }

        private void Form17_Load(object sender, EventArgs e)
        {
            LoadCustomerBookings();
            LoadTransactions();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            Form2 f = new Form2(f1);
            f.Show();
            this.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
