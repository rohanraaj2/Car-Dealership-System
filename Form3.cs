using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace DatabaseProject
{
    public partial class Form3 : Form
    {
        Form1 f1;
        /* public Form3()
        {
            InitializeComponent();
        } */
        public Form3(Form1 frm1)
        {
            InitializeComponent();
            this.f1 = frm1;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Rohan";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Form5 g = new Form5(this);
            //g.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            f.Show();
            this.Close();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form7 f = new Form7();
            f.Show();
            this.Close();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form8 f = new Form8();
            f.Show();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form13 f = new Form13();
            f.Show();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }
        /* Form9 f = new Form9();
        f.Show();
            this.Close(); */

        private void button6_Click(object sender, EventArgs e)
        {
            Form12 f = new Form12();
            f.Show();
            this.Close();

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form16 f = new Form16();
            f.Show();
            this.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }
    }
}
