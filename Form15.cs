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
    public partial class Form15 : Form
    {
        Form2 f2;
        const string constr = @"Data Source = ROHAN-PC\SPARTA; Initial Catalog = dbproj ;Integrated Security = SSPI";
        SqlConnection con = new SqlConnection(constr);
        SqlCommand cm = new SqlCommand();
        public Form15(Form2 frm2)
        {
            InitializeComponent();
            this.f2 = frm2;
        }

        private void LoadServiceHistory()
        {
            // TODO: Complete the function LoadOrders
            // SQL Query to Select all records from orders table in the descending order of order date
            con.Open();
            string sql = "select [serviceticket].service_ticket_id, ([CustomerDetails].first_name + ' ' + [CustomerDetails].last_name) as 'Customer', [Service].service_name as 'Service', [serviceticket].date_recieved, [serviceticket].date_returned, [serviceticket].vehicle_number, [serviceticket].Instructions from [serviceticket], [Service], [CustomerDetails] where [serviceticket].customer_id =  [customerdetails].customer_id and [serviceticket].service_id = [Service].service_id and [customerdetails].first_name = '" + "Hunain" + "' ";
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
            string sql = "select * from [serviceinvoice] where service_ticket_id in (select service_ticket_id from [serviceticket] where customer_id in (select customer_id from [customerdetails] where first_name = '" + "Hunain" + "')) ";
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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form15_Load(object sender, EventArgs e)
        {
            LoadServiceHistory();
            LoadTransactions();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
