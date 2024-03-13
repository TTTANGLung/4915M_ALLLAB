using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01.Lab3a
{
    public partial class Lab03a : Form
    {
        public Lab03a()
        {
            InitializeComponent();
        }

        private void btnCast_Click(object sender, EventArgs e)
        {
             MessageBox.Show("You are welcomed \n"+cboMovie.Text);
        }
    }
}
