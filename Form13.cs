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
    public partial class Form13 : Form
    {
        //const string constr = @"Data Source=DESKTOP-SIPFLUH\DBSML3;Initial Catalog=dbproj;Integrated Security=SSPI";
        const string constr = @"Data Source = ROHAN-PC\SPARTA; Initial Catalog = dbproj ;Integrated Security = SSPI";
        SqlConnection con = new SqlConnection(constr);
        SqlCommand cm = new SqlCommand();
        public Form13()
        {
            InitializeComponent();
        }

        private void LoadSpareParts()
        {
            // TODO: Complete the function LoadOrders
            // SQL Query to Select all records from orders table in the descending order of order date
            con.Open();
            string sql = "select part_id, part_type, part_price, (select supplier_name from [SupplierDetails] where [SupplierDetails].supplier_id = [sparepartsdetails].supplier_id) as 'Supplier', part_stock_level from [sparepartsdetails]";
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

        private void UpdateStockLevel(string part_id)
        {
            con.Open();
            // TODO: Complete the function DeleteOrder 
            // SQL query to Delete the from the order and order details table
            string sql = "Update [SparePartsDetails] Set part_stock_level = @part_stock_level where part_id = @part_id;" ;
            cm = new SqlCommand(sql, con);

            // Specify the value of the parameters
            cm.Parameters.AddWithValue("@part_stock_level", Convert.ToInt32(tbStockLevel.Text));
            cm.Parameters.AddWithValue("@part_id", part_id);

            cm.ExecuteNonQuery();
            cm.Dispose();
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["dataGridViewUpdateButton"].Index)
            {
                var data = dataGridView1.Rows[e.RowIndex];
                MessageBox.Show("Updating");


                UpdateStockLevel(data.Cells[0].Value.ToString());



                dataGridView1.Columns.Remove("dataGridViewUpdateButton");
                dataGridView1.DataSource = null;

                LoadSpareParts();

                var updateButton = new DataGridViewButtonColumn();
                updateButton.Name = "dataGridViewUpdateButton";
                updateButton.HeaderText = "Update";
                updateButton.Text = "Update";
                updateButton.UseColumnTextForButtonValue = true;

                dataGridView1.Columns.Add(updateButton);

            }
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.RowHeadersVisible = false;
            var updateButton = new DataGridViewButtonColumn();
            updateButton.Name = "dataGridViewUpdateButton";
            updateButton.HeaderText = "Update";
            updateButton.Text = "Update";
            updateButton.UseColumnTextForButtonValue = true;

            LoadSpareParts();
            dataGridView1.Columns.Add(updateButton);
        }



        private void btnClear_Click(object sender, EventArgs e)
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
