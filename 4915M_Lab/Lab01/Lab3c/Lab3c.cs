using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Lab01.Lab3c
{
    public partial class Lab3c : Form
    {
        public Lab3c()
        {
            InitializeComponent();
        }

        private void Lab3c_Load(object sender, EventArgs e)
        {
            lsbShop.Items.Add("Apple");
            lsbShop.Items.Add("Banana");
            lsbShop.Items.Add("Grape");
            lsbShop.Items.Add("Peach");
            lsbShop.Items.Add("Pear");
            lsbShop.Items.Add("Orange");
            lsbShop.Items.Add("Pineapple");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lsbShop.SelectedItems == null)
            {
                MessageBox.Show("Must select anyone in Left ListBox");
            }
            else if(lsbCart.SelectedItems != null)
            {
                MoveListBoxItems(lsbShop, lsbCart);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lsbCart.SelectedItems != null)
            {
                MoveListBoxItems(lsbCart, lsbShop);
            }
            else
            {
                MessageBox.Show("Must select anyone in Right ListBox");
            }
        }

        private void MoveListBoxItems(ListBox source, ListBox destination)
        {
            ListBox.SelectedObjectCollection sourceItems = source.SelectedItems;
            foreach (var item in sourceItems)
            {
                destination.Items.Add(item);
            }
            while (source.SelectedItems.Count > 0)
            {
                source.Items.Remove(source.SelectedItems[0]);
            }
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            int count = lsbCart.Items.Count+lsbShop.Items.Count;
            MessageBox.Show($"The count is {count}");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (var item in lsbCart.Items)
            {
                lsbShop.Items.Add((string)item);
            }
            lsbCart.Items.Clear();
        }
    }
}
