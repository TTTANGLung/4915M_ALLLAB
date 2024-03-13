using System;
using System.Windows.Forms;

namespace Lab01.Lab2a
{
    public partial class Lab02a : Form
    {
        private int price;
        private string payment;
        public Lab02a()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            price = 250;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            price = 180;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            price = 75;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            payment = "VISA";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            payment = "MasterCard";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int total = Convert.ToInt32(textBox1.Text) * price;
            label2.Text = "Total Price: " + total + ", Payment Method: " + payment;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Lab02a_Load(object sender, EventArgs e)
        {

        }
    }
}
