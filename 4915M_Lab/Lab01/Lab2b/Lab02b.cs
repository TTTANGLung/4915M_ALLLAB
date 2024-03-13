using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01.Lab2b
{
    public partial class Lab02b : Form
    {
        public Lab02b()
        {
            InitializeComponent();
        }

        private void rbtCloudy_CheckedChanged(object sender, EventArgs e)
        {
            resetPic("Cloudy", picCloudy);
        }

        private void rbtRainy_CheckedChanged(object sender, EventArgs e)
        {
            resetPic("Rainy", picRainy);
        }

        private void rbtSonwy_CheckedChanged(object sender, EventArgs e)
        {
            resetPic("Sonwy", picSnowy);
        }

        private void rbtSunny_CheckedChanged(object sender, EventArgs e)
        {
            resetPic("Sunny",picSunny);
        }

        private void resetPic(string weather,PictureBox pic)
        {
            picCloudy.Visible = false;
            picRainy.Visible = false;
            picSnowy.Visible = false;
            picSunny.Visible = false;
            pic.Visible = true;
            lblMessage.Text = $"It’s going to be a {weather} day today,{textBox1.Text}.";
        }
    }
}
