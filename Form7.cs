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
    public partial class Form7 : Form
    {
        //const string constr = @"Data Source=DESKTOP-SIPFLUH\DBSML3;Initial Catalog=dbproj;Integrated Security=SSPI";
        const string constr = @"Data Source = ROHAN-PC\SPARTA; Initial Catalog = dbproj ;Integrated Security = SSPI";
        SqlConnection con = new SqlConnection(constr);
        SqlCommand cm = new SqlCommand();
        public Form7()
        {
            InitializeComponent();
        }

        private void LoadOrders()
        {
            // TODO: Complete the function LoadOrders
            // SQL Query to Select all records from orders table in the descending order of order date
            con.Open();
            string sql = "select [BookingDetails].booking_id As 'Booking ID', [CarDetails].model as 'Car', ([EmployeeDetails].first_name + ' ' +  " +
                "[EmployeeDetails].last_name) as 'Salesperson', ([CustomerDetails].first_name + ' ' +  [CustomerDetails].last_name) as 'Customer' from " +
                "[BookingDetails], [CarDetails], [EmployeeDetails], [CustomerDetails] where [BookingDetails].car_id = " +
                "[CarDetails].car_id and [BookingDetails].salesperson_id = [EmployeeDetails].salesperson_id and " +
                "[BookingDetails].customer_id = [CustomerDetails].customer_id;";
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
        private void Form7_Load(object sender, EventArgs e)
        {
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.RowHeadersVisible = false;
            LoadOrders();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            Form3 f = new Form3(f1);
            f.Show();
            this.Close();
        }
    }
}
