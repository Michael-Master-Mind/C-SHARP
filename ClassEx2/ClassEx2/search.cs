﻿using System;
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
    public partial class search : Form
    {
        public search()
        {
            InitializeComponent();
            
        }

        private void search_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var item = Item.findOne(textBox1.Text);
            if (item == null)
            {
                MessageBox.Show("Item not found!");
            }
            lblOb.Text = item.object_name;
            lblcount.Text = item.count;
            lblprice.Text = item.price;
        }
    }
}
