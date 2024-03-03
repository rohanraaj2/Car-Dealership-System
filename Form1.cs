using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DatabaseProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //const string constr = @"Data Source=DESKTOP-SIPFLUH\DBSML3;Initial Catalog=dbproj;Integrated Security=SSPI";
            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-SIPFLUH\\DBSML3;Initial Catalog=cmblogin;Integrated Security=True");
            SqlConnection con = new SqlConnection("Data Source = ROHAN-PC\\ROHAN-PC; Initial Catalog = cmblogin ;Integrated Security = True");
            //SqlConnection con = new SqlConnection(constr);

            SqlCommand cmd = new SqlCommand("select * from login where username = '" + txtuser.Text + "' and password = '" + txtpass.Text + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);


            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Please select a User Type");
            }
            else
            {
                string cmbItemValue = comboBox1.SelectedItem.ToString();
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (dt.Rows[i]["usertype"].ToString() == cmbItemValue)
                        {
                            MessageBox.Show("You are logged in as" + " " + dt.Rows[i][2]);
                            if (comboBox1.SelectedIndex == 0)
                            {
                                Form3 f = new Form3(this);
                                f.Show();
                                //this.Close();
                                this.Hide();
                            }

                            else
                            {
                                Form2 ff = new Form2(this);
                                ff.Show();
                                //this.Close();
                                this.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid User Access");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }
            }


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
