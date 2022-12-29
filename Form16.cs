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
    public partial class Form16 : Form
    {

        //const string constr = @"Data Source=DESKTOP-SIPFLUH\DBSML3;Initial Catalog=dbproj;Integrated Security=SSPI";
        const string constr = @"Data Source = ROHAN-PC\SPARTA; Initial Catalog = dbproj ;Integrated Security = SSPI";
        SqlConnection con = new SqlConnection(constr);
        SqlCommand cm = new SqlCommand();
        public Form16()
        {
            InitializeComponent();
        }

        private void LoadCustomers()
        {
            // TODO: Complete the function LoadOrders
            // SQL Query to Select all records from orders table in the descending order of order date
            con.Open();
            string sql = "select * from [customerdetails]";
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

        /* private void DeleteCustomer(string customer_id)
        {
            con.Open();
            // SQL query to Delete the from the order and order details table
            string sql = "Delete [BookingTranscaction] where @booking_id = select booking_id from BookingDetails where @customer_id = customer_id; Delete [BookingDetails] where @customer_id = customer_id; Delete [CustomerDetails] where @customer_id = customer_id;";
            cm = new SqlCommand(sql, con);

            // Specify the value of the parameters
            cm.Parameters.AddWithValue("@customer_id", customer_id);
            cm.Parameters.AddWithValue("@booking_id", select booking_id from BookingDetails where @customer_id = customer_id);

            cm.ExecuteNonQuery();
            cm.Dispose();
            con.Close(); 
        }  */
        private void Form16_Load(object sender, EventArgs e)
        {
             dataGridView1.BackgroundColor = Color.White;
            dataGridView1.RowHeadersVisible = false;
            /* var deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "dataGridViewDeleteButton";
            deleteButton.HeaderText = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.UseColumnTextForButtonValue = true; */

            LoadCustomers();
            //dataGridView1.Columns.Add(deleteButton);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //tbcustomer_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbfirst_name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            tblast_name.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbphone_number.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbaddress.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            //if click is on new row or header row
             /* if (e.RowIndex == dataGridView1.NewRowIndex || e.RowIndex < 0)
                return;

            //Check if click is on specific column 
            if (e.ColumnIndex == dataGridView1.Columns["dataGridViewDeleteButton"].Index)
            {

                var data = dataGridView1.Rows[e.RowIndex];
                MessageBox.Show("Deleting");


                DeleteCustomer(data.Cells[0].Value.ToString());
                dataGridView1.Columns.Remove("dataGridViewDeleteButton");

                dataGridView1.DataSource = null;

                LoadCustomers();

                var deleteButton = new DataGridViewButtonColumn();
                deleteButton.Name = "dataGridViewDeleteButton";
                deleteButton.HeaderText = "Delete";
                deleteButton.Text = "Delete";
                deleteButton.UseColumnTextForButtonValue = true;

                dataGridView1.Columns.Add(deleteButton);
            } */
        } 
        private void InsertCustomer()
        {
            // Sql query to insert a new supplier.
            string sql = "Insert Into [CustomerDetails] ([customer_id],[first_name],[last_name], [phone_number], [address]) values ((select max(customer_id) from CustomerDetails) + 1, @first_name, @last_name, @phone_number, @address)";
            cm = new SqlCommand(sql, con);

            // Specify the value of the parameters
            con.Open();
            cm = new SqlCommand(sql, con);
            // Specify the value for the parameters.
            if (tbfirst_name.TextLength > 0 && tblast_name.TextLength > 0 && tbphone_number.TextLength > 0 && tbaddress.TextLength > 0)
            {
                //cm.Parameters.AddWithValue("@customer_id", tbcustomer_id.Text);
                cm.Parameters.AddWithValue("@first_name", tbfirst_name.Text);
                cm.Parameters.AddWithValue("@last_name", tblast_name.Text);
                cm.Parameters.AddWithValue("@phone_number", tbphone_number.Text);
                cm.Parameters.AddWithValue("@address", tbaddress.Text);


                //dataGridView1.Rows.Add(tbSupplierID.Text.ToString(), tbSupplierName.Text.ToString());

            }
            else
            {
                MessageBox.Show("Please provide valid information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //tbcustomer_id.Text = "";
            tbfirst_name.Text = "";
            tblast_name.Text = "";
            tbphone_number.Text = "";
            tbaddress.Text = "";

            cm.ExecuteNonQuery();
            con.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            InsertCustomer();
            MessageBox.Show("Customer has been successfully inserted.");
            //tbcustomer_id.Text = "";
            tbfirst_name.Text = "";
            tblast_name.Text = "";
            tbphone_number.Text = "";
            tbaddress.Text = "";
            this.Close();
            Form16 f = new Form16();
            f.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //tbcustomer_id.Text = "";
            tbfirst_name.Text = "";
            tblast_name.Text = "";
            tbphone_number.Text = "";
            tbaddress.Text = "";
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
