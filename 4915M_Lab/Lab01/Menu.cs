using Lab01.Lab2a;
using Lab01.Lab2b;
using Lab01.Lab2c;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Meun_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lab01 lab1 = new Lab01();
            lab1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lab02a lab2a= new Lab02a();
            lab2a.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lab02b lab2b = new Lab02b();
            lab2b.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lab2c.frmStudents lab2c = new frmStudents();
            lab2c.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Lab3a.Lab03a lab3a = new Lab3a.Lab03a();
            lab3a.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Lab3b.Form1 lab3b = new Lab3b.Form1();
            lab3b.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Lab3c.Lab3c lab3c = new Lab3c.Lab3c();
            lab3c.ShowDialog();
        }
    }
}
