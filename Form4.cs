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
    public partial class Form4 : Form
    {
        Form2 f2;
        const string constr = @"Data Source = ROHAN-PC\SPARTA; Initial Catalog = dbproj ;Integrated Security = SSPI";
        SqlConnection con = new SqlConnection(constr);
        SqlCommand cm = new SqlCommand();
        public Form4(Form2 frm2)
        {
            InitializeComponent();
            this.f2 = frm2;
        }
        private void LoadCars()
        {
            // TODO: Complete the function LoadOrders
            // SQL Query to Select all records from orders table in the descending order of order date
            con.Open();
            string sql = "select * from [cardetails]";
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
            string sql = "select max(booking_id) from [bookingdetails]";
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
            int bookingid = GetMaxID()+1;
            string sql = "INSERT INTO [bookingdetails] ([booking_id],[car_id],[salesperson_id],[customer_id],[booking_date],[delivery_date]) VALUES (@booking_id,@car_id, 2, (select customer_id from [customerdetails] where first_name = '" + "Hunain" + "'),getdate(), '2/25/2023')";
            cm = new SqlCommand(sql, con);

            // Specify the value of the parameters
            con.Open();
            cm = new SqlCommand(sql, con);
            cm.Parameters.AddWithValue("@car_id", textBox1.Text);
            cm.Parameters.AddWithValue("@booking_id", bookingid);

            cm.ExecuteNonQuery();
            con.Close();
        }

        private void InsertTransaction()
        {
            int transactionid = GetMaxID();
            string sql = "INSERT INTO [bookingtranscaction] ([transaction_id],[booking_id],[payment_date],[amount]) VALUES (@transaction_id,@booking_id,getdate(), (select price from [cardetails] where car_id = '"+ textBox1.Text + "'))";
            cm = new SqlCommand(sql, con);

            // Specify the value of the parameters
            con.Open();
            cm = new SqlCommand(sql, con);
            cm.Parameters.AddWithValue("@transaction_id", transactionid);
            cm.Parameters.AddWithValue("@booking_id", transactionid);

            cm.ExecuteNonQuery();
            con.Close();
        }


        private void Form4_Load(object sender, EventArgs e)
        {
            LoadCars();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            if (comboBox1.SelectedIndex == 0)
            {
                comboBox2.Items.Add("City 1.2LS");
                comboBox2.Items.Add("City 1.5LS");
                comboBox2.Items.Add("Aspire 1.5LAS");
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                comboBox2.Items.Add("Civic Standard");
                comboBox2.Items.Add("Civic Oriel");
                comboBox2.Items.Add("Civic RS");
            }

            else
            {
                comboBox2.Items.Add("BR-V CVT S 1.5 L");
            }

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bookingid = GetMaxID() + 1;
            int transactionid = GetMaxID() + 1;
            InsertBooking();
            MessageBox.Show("Please check your booking history for confirmation. Your booking id is " + bookingid);
            InsertTransaction();
            //this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            Form2 f = new Form2(f1);
            f.Show();
            this.Close();
        }
    }
}
