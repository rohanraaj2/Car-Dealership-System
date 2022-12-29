using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseProject
{
    public partial class Form2 : Form
    {
        Form1 f1;
        /* public Form2()
        {
            InitializeComponent();
        } */
        public Form2(Form1 frm1)
        {
            InitializeComponent();
            this.f1 = frm1;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Hunain";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            Form2 f2 = new Form2(f1);
            Form4 f = new Form4(this);
            f.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5(this);
            f.Show();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form14 f = new Form14();
            f.Show();
            this.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            Form2 f2 = new Form2(f1);

            Form15 f = new Form15(f2);
            f.Show();
            this.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form17 f = new Form17(this);
            f.Show();
            this.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }
    }
}
