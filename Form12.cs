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
    public partial class Form12 : Form
    {
        //const string constr = @"Data Source=DESKTOP-SIPFLUH\DBSML3;Initial Catalog=dbproj;Integrated Security=SSPI";
        const string constr = @"Data Source = ROHAN-PC\SPARTA; Initial Catalog = dbproj ;Integrated Security = SSPI";
        SqlConnection con = new SqlConnection(constr);
        SqlCommand cm = new SqlCommand();
        public Form12()
        {
            InitializeComponent();
        }

        private void LoadSuppliers()
        {
            // TODO: Complete the function LoadOrders
            // SQL Query to Select all records from orders table in the descending order of order date
            con.Open();
            string sql = "Select * from [SupplierDetails]";
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



        private void DeleteSupplier(string supplier_id)
        {
            con.Open();
            // SQL query to Delete the from the order and order details table
            string sql = "Delete [SparePartsDetails] where @supplier_id = supplier_id; Delete [SupplierDetails] where @supplier_id = supplier_id; "; //; Delete orders where @orderid = orderid; ";
            cm = new SqlCommand(sql, con);

            // Specify the value of the parameters
            cm.Parameters.AddWithValue("@supplier_id", supplier_id);
            cm.ExecuteNonQuery();
            cm.Dispose();
            con.Close();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form12_Load(object sender, EventArgs e)
        {
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.RowHeadersVisible = false;
            var deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "dataGridViewDeleteButton";
            deleteButton.HeaderText = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;

            LoadSuppliers();
            dataGridView1.Columns.Add(deleteButton);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //tbSupplierID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbSupplierName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            //if click is on new row or header row
            if (e.RowIndex == dataGridView1.NewRowIndex || e.RowIndex < 0)
                return;

            //Check if click is on specific column 
            if (e.ColumnIndex == dataGridView1.Columns["dataGridViewDeleteButton"].Index)
            {

                var data = dataGridView1.Rows[e.RowIndex];
                MessageBox.Show("Deleting");


                DeleteSupplier(data.Cells[0].Value.ToString());
                dataGridView1.Columns.Remove("dataGridViewDeleteButton");

                dataGridView1.DataSource = null;

                LoadSuppliers();

                var deleteButton = new DataGridViewButtonColumn();
                deleteButton.Name = "dataGridViewDeleteButton";
                deleteButton.HeaderText = "Delete";
                deleteButton.Text = "Delete";
                deleteButton.UseColumnTextForButtonValue = true;

                dataGridView1.Columns.Add(deleteButton);
            }

        }

        /* private int GetMaxOrderID()
        {
            // TODO: Complete the function GetMaxOrderID
            // Query to get max(orderid) from the orders table.
            con.Open();
            string sql = "select max(supplier_id) from SupplierDetails";
            cm = new SqlCommand(sql, con);
            SqlDataAdapter da5 = new SqlDataAdapter(cm);
            DataTable dt5 = new DataTable();
            da5.Fill(dt5);
            con.Close();

            int supplier_id = Convert.ToInt32(dt5.Rows[0].ItemArray[0].ToString());
            return supplier_id;

        } */
        private void InsertSupplier()
        {
            // Sql query to insert a new supplier.
            string sql = "Insert Into [SupplierDetails] ([supplier_id],[supplier_name]) values ((select max(supplier_id) from SupplierDetails) + 1,@supplier_name)";
            cm = new SqlCommand(sql, con);

            // Specify the value of the parameters
            con.Open();
            cm = new SqlCommand(sql, con);
            // Specify the value for the parameters.
            if (tbSupplierName.TextLength > 0)
            {
                //cm.Parameters.AddWithValue("@supplier_id", tbSupplierID.Text);
                cm.Parameters.AddWithValue("@supplier_name", tbSupplierName.Text);
                //dataGridView1.Rows.Add(tbSupplierID.Text.ToString(), tbSupplierName.Text.ToString());
                
            }
            else
            {
                MessageBox.Show("Please provide valid information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //tbSupplierID.Text = "";
            tbSupplierName.Text = "";
            cm.ExecuteNonQuery();
            con.Close();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            //tbSupplierID.Text = "";
            tbSupplierName.Text = "";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            InsertSupplier();
            MessageBox.Show("Supplier has been successfully inserted.");
            //tbSupplierID.Text = "";
            tbSupplierName.Text = "";
            LoadSuppliers();
            this.Close();
            Form12 f = new Form12();
            f.Show();
            //this.Show();

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
