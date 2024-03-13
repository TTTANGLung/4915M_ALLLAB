using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01.Lab2c
{
    public partial class frmStudents : Form
    {
        public frmStudents()
        {
            InitializeComponent();
        }

        private void frmStudents_Load(object sender, EventArgs e)
        {
            lasStudents.Items.Add("Mary Chu");
            lasStudents.Items.Add("Peter Lee");
            lasStudents.Items.Add("Johnson Chan");
            lasStudents.Items.Add("Alex Leung");
        }

        private void lasStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lasStudents.SelectedItem !=null)
            {
                lblMessage.Text = $"The following item is selected:  {lasStudents.SelectedItem}";
            } 
        }

        private void lasStudents_DoubleClick(object sender, EventArgs e)
        {
            lblMessage.Text = $"The following item is deleted: {lasStudents.SelectedItem}";
            lasStudents.Items.Remove(lasStudents.SelectedItem);
        }

        private void txtName_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lasStudents.Items.Add(txtName.Text);
        }
    }
}
