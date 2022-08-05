using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassEx2.Iteams;

namespace ClassEx2
{
    public partial class DisplayAllProduct : Form
    {
        public DisplayAllProduct()
        {
            InitializeComponent();
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = Item.get_add_products();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var item = Item.findOne(search.Text);
            if (item == null)
            {  
                MessageBox.Show("Item not found!");
            }
            lblOb.Text = item.object_name;
            lblcount.Text = item.count;
            lblprice.Text = item.price; 
               
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblprice_Click(object sender, EventArgs e)
        {

        }
    }
}
