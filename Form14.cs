using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseProject
{
    public partial class Form14 : Form
    {
        const string constr = @"Data Source = ROHAN-PC\SPARTA; Initial Catalog = dbproj ;Integrated Security = SSPI";
        SqlConnection con = new SqlConnection(constr);
        SqlCommand cm = new SqlCommand();
        public Form14()
        {
            InitializeComponent();
        }

        private void LoadServices()
        
        {
            // TODO: Complete the function LoadOrders
            // SQL Query to Select all records from orders table in the descending order of order date
            con.Open();
            string sql = "select * from [service]";
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

        private int GetMaxID()
        {
            // TODO: Complete the function GetMaxOrderID
            // Query to get max(orderid) from the orders table.
            con.Open();
            string sql = "select max(service_ticket_id) from [serviceticket]";
            cm = new SqlCommand(sql, con);
            SqlDataAdapter da5 = new SqlDataAdapter(cm);
            DataTable dt5 = new DataTable();
            da5.Fill(dt5);
            con.Close();

            int orderid = Convert.ToInt32(dt5.Rows[0].ItemArray[0].ToString());
            return orderid;

        }

        private void InsertBooking()
        {
            int bookingid = GetMaxID() + 1;
            string sql = "INSERT INTO [serviceticket] ([service_ticket_id],[customer_id],[service_id],[date_recieved],[date_returned],[vehicle_number],[Instructions]) VALUES (@ticket_id,(select customer_id from [customerdetails] where first_name = 'Hunain'),@service_id, getdate(), '12/3/2022',@number,@instructions)";
            cm = new SqlCommand(sql, con);

            // Specify the value of the parameters
            con.Open();
            cm = new SqlCommand(sql, con);
            cm.Parameters.AddWithValue("@ticket_id", bookingid);
            cm.Parameters.AddWithValue("@booking_id", bookingid);
            cm.Parameters.AddWithValue("@service_id", textBox3.Text);
            cm.Parameters.AddWithValue("@number", textBox1.Text);
            cm.Parameters.AddWithValue("@instructions", textBox4.Text);

            cm.ExecuteNonQuery();
            con.Close();
        }

        private void InsertTransaction()
        {
            int transactionid = GetMaxID();
            string sql = "INSERT INTO [serviceinvoice] ([invoice_id],[service_ticket_id],[amount_paid],[payment_date]) VALUES (@invoice_id,@service_ticket_id, (select charges from [service] where service_id = '" + textBox3.Text + "'),getdate())";
            cm = new SqlCommand(sql, con);

            // Specify the value of the parameters
            con.Open();
            cm = new SqlCommand(sql, con);
            cm.Parameters.AddWithValue("@invoice_id", transactionid);
            cm.Parameters.AddWithValue("@service_ticket_id", transactionid);

            cm.ExecuteNonQuery();
            con.Close();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            LoadServices();
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bookingid = GetMaxID() + 1;
            InsertBooking();
            MessageBox.Show("Please check your maintenance history for confirmation. Your ticket id is " + bookingid);
            InsertTransaction();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

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
    }
}
