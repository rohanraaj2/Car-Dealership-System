﻿using System;
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
    public partial class Form5: Form
    {
        Form2 f2;
        //const string constr = @"Data Source=DESKTOP-SIPFLUH\DBSML3;Initial Catalog=dbproj;Integrated Security=SSPI";
        const string constr = @"Data Source = ROHAN-PC\SPARTA; Initial Catalog = dbproj ;Integrated Security = SSPI";
        SqlConnection con = new SqlConnection(constr);
        SqlCommand cm = new SqlCommand();
        
        public Form5(Form2 frm2)
        {
            InitializeComponent();
            this.f2 = frm2;
 
        }
        private void LoadOrders()
        {
            // TODO: Complete the function LoadOrders
            // SQL Query to Select all records from orders table in the descending order of order date
            con.Open();
            string sql = "select * from [customerdetails] where first_name = '" + "Hunain" + "'";
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.RowHeadersVisible = false;

            LoadOrders();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {   
            //LoadOrders();
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
