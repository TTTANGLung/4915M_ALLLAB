using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01.Lab3b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Double amount = Convert.ToDouble(txtAmount.Text);
            Double rate = 1+Convert.ToDouble(txtRate.Text);
            lblValue2.Text = Convert.ToString(amount * Math.Pow(rate,10));
            Double total = Convert.ToDouble(txtAmount.Text);
            int n = 0;
            while(total < 1000000)
            {
                total = total * rate;
                n += 1;
            }
            lblMillion2.Text = Convert.ToString(n);
        }
    }
}
